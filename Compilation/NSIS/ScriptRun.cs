namespace R3BinderTools.Compilation.NSIS
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    using Helpers;
    using Properties;

    public static class ScriptRun
    {
        /// <summary>
        /// Метод для запуска процесса с передачей параметров
        /// </summary>
        /// <param name="filename">Имя файла для запуска</param>
        /// <param name="args">Аргументы для передачи запуска</param>
        /// <param name="StatusCompile">Вывод сообщения</param>
        /// <returns></returns>
        public static bool RunFile(string filename, string args, Label StatusCompile)
        {
            if (!string.IsNullOrWhiteSpace(filename))
            {
                try
                {
                    string line = string.Empty;
                    var PwsHide = ProcessWindowStyle.Hidden;
                    var startInfo = new ProcessStartInfo
                    {
                        FileName = filename,
                        CreateNoWindow = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        WindowStyle = PwsHide,
                        Arguments = args
                    };
                    using var info = Process.Start(startInfo);
                    info.Refresh();
                    info.WaitForExit();

                    // Читаем весь поток вывода данных 
                    while (!info.StandardOutput.EndOfStream)
                    {
                        line = info.StandardOutput.ReadLine();
                    }
                    // Проверяем на совпадение строки
                    if (line.Contains("Total size:"))
                    {
                        MusicPlay.Inizialize(Resources.GoodBuild);
                        StatusCompile.Location = new Point(74, 388);
                        ControlActive.CheckMessage(StatusCompile, "Билд создан успешно!", Color.YellowGreen, 5000);
                    }
                    else
                    {
                        MusicPlay.Inizialize(Resources.Error_Build);
                        StatusCompile.Location = new Point(58, 388); 
                        ControlActive.CheckMessage(StatusCompile, "Ошибка создания билд файла!", Color.YellowGreen, 5000);
                        try
                        {
                            line = info.StandardError.ReadLine();
                            File.WriteAllText("nsiError.txt", $"Ошибка скрипта: {line}\r\n");
                        }
                        catch { }
                    }
                    return true;
                }
                catch (Exception) { return false; }
            }
            return true;
        }
    }
}