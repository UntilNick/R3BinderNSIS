namespace R3BinderTools.Compilation.NSIS
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using GenTools;
    using Helpers;

    public partial class NsisBinderFrm : UserControl
    {
        public NsisBinderFrm()
        {
            InitializeComponent();
            this.MenuFiles.Renderer = new ToolStripProfessionalRenderer(new Design.MenuPalette());
            this.FileVerTextBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.VersionTextBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
        }

        protected void TextBoxOnTextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 46)
                e.Handled = true;
        }
        private void NsisBinderFrm_Load(object sender, EventArgs e)
        {
            this.ListFiles.AllowDrop = true;
            this.AutoGenNsis.Enabled = false;
            if (File.Exists(GlobalPath.ScriptPath))
            {
                File.Delete(GlobalPath.ScriptPath);
            }
        }
        private void PropetriesBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.PropetriesBox.Checked == true)
            {
                this.NameTextBox.Enabled = true;
                this.VersionTextBox.Enabled = true;
                this.CompanyTextBox.Enabled = true;
                this.DescriptTextBox.Enabled = true;
                this.CopyrightTextBox.Enabled = true;
                this.FileDescriptTextBox.Enabled = true;
                this.FileVerTextBox.Enabled = true;
                this.TradeMarkTextBox.Enabled = true;
                this.AutoGenNsis.Enabled = true;
            }
            else
            {
                this.NameTextBox.Enabled = false;
                this.VersionTextBox.Enabled = false;
                this.CompanyTextBox.Enabled = false;
                this.DescriptTextBox.Enabled = false;
                this.CopyrightTextBox.Enabled = false;
                this.FileDescriptTextBox.Enabled = false;
                this.FileVerTextBox.Enabled = false;
                this.TradeMarkTextBox.Enabled = false;
                this.AutoGenNsis.Enabled = false;
            }
        }
        private void AddIcoBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddIcoBox.Checked == true)
            {
                using var ofd = new OpenFileDialog
                {
                    Title = "Выберите иконку для билд файла",
                    Filter = "Icon|*.ico",
                    AutoUpgradeEnabled = true,
                    CheckFileExists = true,
                    RestoreDirectory = true
                };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.IconTextBox.Text = ofd.FileName;
                    this.IcoViewer.ImageLocation = this.IconTextBox.Text;
                    this.IcoViewer.BorderStyle = BorderStyle.None;
                    this.LsizeIco.Visible = true;
                    this.LsizeIco.Text = $"Размер иконки: {GetFileSize.Inizialize(new FileInfo(this.IconTextBox.Text).Length)}";
                }
                else
                {
                    this.IcoViewer.BorderStyle = BorderStyle.FixedSingle;
                    this.IconTextBox.Clear();
                    AddIcoBox.Checked = false;
                    this.LsizeIco.Visible = false;
                }
            }
            else
            {
                this.IcoViewer.BorderStyle = BorderStyle.FixedSingle;
                this.IconTextBox.Clear();
                this.IcoViewer.Image = null;
                this.LsizeIco.Visible = false;
            }
        }
        private void AddFileItem_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.CountFiles.Focus();

            using var ofd = new OpenFileDialog
            {
                Title = "Выберите файл, который хотите соединить",
                Filter = "Все файлы (*.*)|*.*|exe файлы|*.exe;|dll файлы|*.dll;",
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                Multiselect = true,
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string multi in ofd.FileNames)
                {
                    if (!this.ListFiles.Items.Contains(multi))
                    {
                        this.ListFiles.Items.Add(multi);
                        this.CountFiles.Text = $"Список файлов для соединения: {this.ListFiles.Items.Count}";
                    }
                    else
                    {
                        StatusCompile.Location = new Point(50, 386); 
                        ControlActive.CheckMessage(StatusCompile, "Такой файл уже есть в списке", Color.YellowGreen, 5000);
                    }
                }
            }
        }
        private void RemoveFileItem_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.CountFiles.Focus();

            if (this.ListFiles.SelectedIndex != -1)
            {
                this.ListFiles.Items.RemoveAt(this.ListFiles.SelectedIndex);
                this.CountFiles.Text = $"Список файлов для соединения: {this.ListFiles.Items.Count}";
            }
            else
            {
                StatusCompile.Location = new Point(20, 386);
                ControlActive.CheckMessage(StatusCompile, "Выберите элемент из списка для удаления.", Color.YellowGreen, 5000);
            }
        }
        private void CleanAllItems_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.CountFiles.Focus();
            this.ListFiles.Items.Clear();
            this.CountFiles.Text = $"Список файлов для соединения: {this.ListFiles.Items.Count}";
        }
        private void ListFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!this.ListFiles.Items.Contains(file))
                {
                    this.ListFiles.Items.Add(file);
                    this.CountFiles.Text = $"Список файлов для соединения: {this.ListFiles.Items.Count}";
                }
                else
                {
                    StatusCompile.Location = new Point(51, 386);
                    ControlActive.CheckMessage(StatusCompile, "Такой файл уже есть в списке", Color.YellowGreen, 5000);
                }
            }
        }
        private void ListFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void AutoGenNsis_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.CountFiles.Focus();

            this.NameTextBox.Text = GenX.GetUpdate();
            this.VersionTextBox.Text = Convert.ToString($"{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}");
            this.CompanyTextBox.Text = GenX.GetUpdate();
            this.DescriptTextBox.Text = GenX.GenerateIdentifier(15);
            this.CopyrightTextBox.Text = GenX.GenerateIdentifier(15);
            this.FileDescriptTextBox.Text = GenX.GenerateIdentifier(15);
            this.FileVerTextBox.Text = Convert.ToString($"{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}");
            this.TradeMarkTextBox.Text = GenX.GenerateIdentifier(4);
        }

        private void CreateBuild_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.CountFiles.Focus();

            // Проверяем на пустую строку текстбокс с именем билд файла
            if (!string.IsNullOrWhiteSpace(this.FileNameTextBox.Text))
            {
                // Проверяем есть ли файлы для подгрузки
                if (this.ListFiles.Items.Count > 0)
                {
                    var script = new NsiBuild()
                    {
                        CheckIsHideFiles = this.HideFilesBox,
                        PropetiesBuild = this.PropetriesBox,
                        CheckIcon = this.AddIcoBox,
                        VIProductName = this.NameTextBox.Text,
                        VICompanyName = this.CompanyTextBox.Text,
                        VIDescriptionName = this.DescriptTextBox.Text,
                        VICopyright = this.CopyrightTextBox.Text,
                        VIFileDescription = this.FileDescriptTextBox.Text,
                        VIProductVersion = this.VersionTextBox.Text,
                        VIFileVersion = this.FileVerTextBox.Text,
                        VILegalTrademarks = this.TradeMarkTextBox.Text,
                        BuildName = this.FileNameTextBox.Text,
                        IconPath = IconTextBox.Text,
                        CheckAdmin = this.AdmRunBuildBox,
                        SpisokFiles = this.ListFiles,
                        CheckSuicide = this.SuicideBuildBox,
                        CheckIsAdminRunFiles = RunFileWithAdminBox
                    };

                    Task.Run(() => ScriptGen.Inizialize(script)).Wait();
                    Task.Run(() =>
                    {
                        if (File.Exists(GlobalPath.ScriptPath))
                        {
                            if (File.Exists(GetInstall.ConsoleNsis()))
                            {
                                ScriptRun.RunFile(GetInstall.ConsoleNsis(), GlobalPath.ScriptPath, StatusCompile);
                            }
                            else if (File.Exists(GlobalPath.CurrNsis))
                            {
                                ScriptRun.RunFile(GlobalPath.CurrNsis, GlobalPath.ScriptPath, StatusCompile);
                            }
                            try
                            {
                                File.Delete(GlobalPath.ScriptPath);
                            }
                            catch { }
                        }
                    }).Wait();
                }
                else
                {
                    this.StatusCompile.Location = new Point(43, 386);
                    ControlActive.CheckMessage(StatusCompile, "Добавьте файлы для компиляции", Color.YellowGreen, 5000);
                }
            }
            else
            {
                this.StatusCompile.Location = new Point(65, 386);
                ControlActive.CheckMessage(StatusCompile, "Введите имя билд файла", Color.YellowGreen, 5000);
            }
        }
    }
}