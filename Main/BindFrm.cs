namespace R3BinderTools
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    using Helpers;

    public partial class BindFrm : Form
    {
        public BindFrm()
        {
            InitializeComponent();
            this.LogoText.MouseDown += Controls_MouseDown;
            this.UPanel.MouseDown += Controls_MouseDown;
        }

        protected void Controls_MouseDown(object sender, MouseEventArgs e)
        {
            // Если пользователь нажал левую кнопку мыши
            if (e.Button.Equals(MouseButtons.Left))
            {
                ((Control)sender).Capture = false; // захват элемента управления
                // Посылаем сообщение переместить элемент управления
                var m = Message.Create(this.Handle, 0xa1, new IntPtr(0x2), IntPtr.Zero);
                // Обработчик сообщения
                WndProc(ref m);
            }
        }

        private void AppExit_Click(object sender, EventArgs e)
        {
            // Убираем фокус с кнопки
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();
            // Показываем анимацию при завершение программы
            ControlActive.ShowAnima(this.Handle, 500, Enums.AnimateWindowFlags.AW_VER_POSITIVE | Enums.AnimateWindowFlags.AW_HIDE);
            Application.Exit(); // Закрываем программу
        }

        private void BindFrm_Load(object sender, EventArgs e)
        {
            // Показываем анимацию при старте
            ControlActive.ShowAnima(this.Handle, 500, Enums.AnimateWindowFlags.AW_VER_POSITIVE | Enums.AnimateWindowFlags.AW_ACTIVATE);
        }

        private void ShowBinExe_Click(object sender, EventArgs e)
        {
            this.LogoText.Text = "MultiBinder files [Release]";
            // Показать новую форму
            ControlActive.ControlVisible(this.MainPanel, new Compilation.CodeDOM.MultiBinderFrm());
            // Проверяем и удаляем файл манифеста
            if (File.Exists(GlobalPath.ManifestFile))
            {
                try
                {
                    File.Delete(GlobalPath.ManifestFile);
                }
                catch { }
            }
            // Убираем фокус с кнопки
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();
        }

        private void ShowNsis_Click(object sender, EventArgs e)
        {
            // Убираем фокус с кнопки
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();
            // Проверяем файл nsis 
            if (File.Exists(Compilation.NSIS.GetInstall.ConsoleNsis()) || File.Exists(Path.Combine(GlobalPath.CurrDir, @"NSIS\makensis.exe")))
            {
                // Если файл есть, показываем форму
                ControlActive.ControlVisible(this.MainPanel, new Compilation.NSIS.NsisBinderFrm());
                this.LogoText.Text = "NSIS binder files [Release]";
            }
            else
            {
                LogoText.Text = "R3BinderTools [Release]";
                this.MainPanel.Controls.Clear(); // Отчищяем все формы
                // Выводим сообщение
                this.NsisStatus.Location = new Point(132, 7);
                ControlActive.CheckMessage(this.NsisStatus, "NSIS не обнаружен", Color.Coral, 5000);
                Process.Start("https://nsis.sourceforge.io/Download"); // предлагаем пользователю установить NSIS
            }
        }
    }
}
