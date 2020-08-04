namespace R3BinderTools.Compilation.NSIS
{
    using Microsoft.Win32;

    public static class GetInstall
    {
        /// <summary>
        /// Метод для получения компилятора NSIS
        /// </summary>
        /// <returns></returns>
        public static string ConsoleNsis()
        {
            string result = string.Empty;

            try
            {
                // Путь к файлу
                const string REGPATH = @"NSIS.Script\shell\compile\command";
                // Получаем раздел для чтения
                using RegistryKey Root = Registry.ClassesRoot.OpenSubKey(REGPATH);
                // Получаем имя-значение строки
                string winrarPath = (Root?.GetValue(""))?.ToString();
                // Преобразовываем в полный путь до файла
                string RemoveBrackets = winrarPath.Substring(1, winrarPath.Length - 7);
                // Заменяем полученный файл на новый 
                string ReplaceNsis = RemoveBrackets.Replace("makensisw.exe", "makensis.exe");
                result = ReplaceNsis; // Присваиваем пустой строке новый путь к файлу
            }
            catch { }
            return result; // Возвращяем полный путь к компилятору
        }
    }
}