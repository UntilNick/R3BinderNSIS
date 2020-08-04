namespace R3BinderTools.Helpers
{
    using System;
    using System.IO;

    public static class GlobalPath
    {
        public static readonly string CurrDir = Environment.CurrentDirectory;
        public static readonly string AppDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public static readonly string ManifestFile = Path.Combine(AppDir, "app.manifest");
        public static readonly string ScriptPath = Path.Combine(CurrDir, "Compiler.nsi");
        public static readonly string CurrNsis = Path.Combine(CurrDir, @"NSIS\makensis.exe");
    }
}