namespace R3BinderTools
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;

    using Helpers;

    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                using (new Mutex(true, string.Concat(@"Local\{", MutEx.GetGUID(), "}"), out bool flag))
                {
                    if (flag)
                    {
                        Application.Run(new BindFrm());
                    }
                }
            }
            catch (Exception ex) 
            {
                File.WriteAllText(Path.Combine(GlobalPath.CurrDir, "RunError.txt"), 
                $"{ex.Message}{Environment.NewLine}");
            }
        }
    }
}