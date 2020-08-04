namespace R3BinderTools.Helpers
{
    using System;
    using System.Runtime.InteropServices;

    internal static partial class NativeMethods
    {
        [DllImport("user32.dll")]
        internal extern static IntPtr SetFocus(IntPtr hWnd);

        [DllImport("user32.dll")]
        internal static extern bool AnimateWindow(IntPtr hWnd, int time, Enums.AnimateWindowFlags flags);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        internal extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);
    }
}