namespace R3BinderTools.Compilation.NSIS
{
    partial class NsisBinderFrm
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
            this.IconText = new System.Windows.Forms.Label();
            this.IconTextBox = new System.Windows.Forms.TextBox();
            this.IcoViewer = new System.Windows.Forms.PictureBox();
            this.DragInfo = new System.Windows.Forms.Label();
            this.CountFiles = new System.Windows.Forms.Label();
            this.ListFiles = new System.Windows.Forms.ListBox();
            this.MenuFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorOne = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorTwo = new System.Windows.Forms.ToolStripSeparator();
            this.CleanAllItems = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AssVerText = new System.Windows.Forms.Label();
            this.FileDescriptTextBox = new System.Windows.Forms.TextBox();
            this.AssGuidText = new System.Windows.Forms.Label();
            this.TradeMarkTextBox = new System.Windows.Forms.TextBox();
            this.NsiCompanyText = new System.Windows.Forms.Label();
            this.CompanyTextBox = new System.Windows.Forms.TextBox();
            this.AssFVText = new System.Windows.Forms.Label();
            this.FileVerTextBox = new System.Windows.Forms.TextBox();
            this.AssCopyText = new System.Windows.Forms.Label();
            this.CopyrightTextBox = new System.Windows.Forms.TextBox();
            this.AssProdText = new System.Windows.Forms.Label();
            this.DescriptTextBox = new System.Windows.Forms.TextBox();
            this.NsiDescText = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NsiVersionText = new System.Windows.Forms.Label();
            this.VersionTextBox = new System.Windows.Forms.TextBox();
            this.LsizeIco = new System.Windows.Forms.Label();
            this.StatusCompile = new System.Windows.Forms.Label();
            this.AutoGenNsis = new R3BinderTools.Design.BindButton();
            this.RunFileWithAdminBox = new R3BinderTools.Design.BinderBox();
            this.PropetriesBox = new R3BinderTools.Design.BinderBox();
            this.HideFilesBox = new R3BinderTools.Design.BinderBox();
            this.AdmRunBuildBox = new R3BinderTools.Design.BinderBox();
            this.SuicideBuildBox = new R3BinderTools.Design.BinderBox();
            this.AddIcoBox = new R3BinderTools.Design.BinderBox();
            this.CreateBuild = new R3BinderTools.Design.BindButton();
            ((System.ComponentModel.ISupportInitialize)(this.IcoViewer)).BeginInit();
            this.MenuFiles.SuspendLayout();
            this.SuspendLayout();
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
            this.IconText.TabIndex = 189;
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
            this.IconTextBox.TabIndex = 188;
            this.IconTextBox.TabStop = false;
            // 
            // IcoViewer
            // 
            this.IcoViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IcoViewer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IcoViewer.Location = new System.Drawing.Point(8, 172);
            this.IcoViewer.Name = "IcoViewer";
            this.IcoViewer.Size = new System.Drawing.Size(93, 54);
            this.IcoViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IcoViewer.TabIndex = 187;
            this.IcoViewer.TabStop = false;
            // 
            // DragInfo
            // 
            this.DragInfo.AutoSize = true;
            this.DragInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DragInfo.Location = new System.Drawing.Point(611, 4);
            this.DragInfo.Name = "DragInfo";
            this.DragInfo.Size = new System.Drawing.Size(83, 13);
            this.DragInfo.TabIndex = 186;
            this.DragInfo.Text = "[Drag and Drop]";
            // 
            // CountFiles
            // 
            this.CountFiles.AutoSize = true;
            this.CountFiles.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CountFiles.Location = new System.Drawing.Point(1, 3);
            this.CountFiles.Name = "CountFiles";
            this.CountFiles.Size = new System.Drawing.Size(181, 13);
            this.CountFiles.TabIndex = 185;
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
            this.ListFiles.TabIndex = 184;
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
            // FileNameTextBox
            // 
            this.FileNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.FileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.FileNameTextBox.Location = new System.Drawing.Point(493, 378);
            this.FileNameTextBox.MaxLength = 20;
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.FileNameTextBox.TabIndex = 213;
            this.FileNameTextBox.TabStop = false;
            this.FileNameTextBox.Text = "BuildName";
            this.FileNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(398, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 212;
            this.label1.Text = "FileName:";
            // 
            // AssVerText
            // 
            this.AssVerText.AutoSize = true;
            this.AssVerText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssVerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssVerText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssVerText.Location = new System.Drawing.Point(398, 281);
            this.AssVerText.Name = "AssVerText";
            this.AssVerText.Size = new System.Drawing.Size(86, 13);
            this.AssVerText.TabIndex = 210;
            this.AssVerText.Text = "FileDescription:";
            // 
            // FileDescriptTextBox
            // 
            this.FileDescriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.FileDescriptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileDescriptTextBox.Enabled = false;
            this.FileDescriptTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.FileDescriptTextBox.Location = new System.Drawing.Point(493, 278);
            this.FileDescriptTextBox.MaxLength = 7;
            this.FileDescriptTextBox.Name = "FileDescriptTextBox";
            this.FileDescriptTextBox.Size = new System.Drawing.Size(200, 20);
            this.FileDescriptTextBox.TabIndex = 209;
            this.FileDescriptTextBox.TabStop = false;
            this.FileDescriptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssGuidText
            // 
            this.AssGuidText.AutoSize = true;
            this.AssGuidText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssGuidText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssGuidText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssGuidText.Location = new System.Drawing.Point(398, 346);
            this.AssGuidText.Name = "AssGuidText";
            this.AssGuidText.Size = new System.Drawing.Size(65, 13);
            this.AssGuidText.TabIndex = 208;
            this.AssGuidText.Text = "Trademark:";
            // 
            // TradeMarkTextBox
            // 
            this.TradeMarkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.TradeMarkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TradeMarkTextBox.Enabled = false;
            this.TradeMarkTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.TradeMarkTextBox.Location = new System.Drawing.Point(493, 343);
            this.TradeMarkTextBox.MaxLength = 7;
            this.TradeMarkTextBox.Name = "TradeMarkTextBox";
            this.TradeMarkTextBox.Size = new System.Drawing.Size(200, 20);
            this.TradeMarkTextBox.TabIndex = 207;
            this.TradeMarkTextBox.TabStop = false;
            this.TradeMarkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NsiCompanyText
            // 
            this.NsiCompanyText.AutoSize = true;
            this.NsiCompanyText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.NsiCompanyText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.NsiCompanyText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NsiCompanyText.Location = new System.Drawing.Point(398, 215);
            this.NsiCompanyText.Name = "NsiCompanyText";
            this.NsiCompanyText.Size = new System.Drawing.Size(86, 13);
            this.NsiCompanyText.TabIndex = 206;
            this.NsiCompanyText.Text = "CompanyName:";
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.CompanyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyTextBox.Enabled = false;
            this.CompanyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.CompanyTextBox.Location = new System.Drawing.Point(493, 212);
            this.CompanyTextBox.MaxLength = 100;
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.Size = new System.Drawing.Size(200, 20);
            this.CompanyTextBox.TabIndex = 205;
            this.CompanyTextBox.TabStop = false;
            this.CompanyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssFVText
            // 
            this.AssFVText.AutoSize = true;
            this.AssFVText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssFVText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssFVText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssFVText.Location = new System.Drawing.Point(398, 324);
            this.AssFVText.Name = "AssFVText";
            this.AssFVText.Size = new System.Drawing.Size(68, 13);
            this.AssFVText.TabIndex = 204;
            this.AssFVText.Text = "FileVersion:";
            // 
            // FileVerTextBox
            // 
            this.FileVerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.FileVerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileVerTextBox.Enabled = false;
            this.FileVerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.FileVerTextBox.Location = new System.Drawing.Point(493, 321);
            this.FileVerTextBox.MaxLength = 7;
            this.FileVerTextBox.Name = "FileVerTextBox";
            this.FileVerTextBox.Size = new System.Drawing.Size(200, 20);
            this.FileVerTextBox.TabIndex = 203;
            this.FileVerTextBox.TabStop = false;
            this.FileVerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssCopyText
            // 
            this.AssCopyText.AutoSize = true;
            this.AssCopyText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssCopyText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssCopyText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssCopyText.Location = new System.Drawing.Point(398, 259);
            this.AssCopyText.Name = "AssCopyText";
            this.AssCopyText.Size = new System.Drawing.Size(59, 13);
            this.AssCopyText.TabIndex = 202;
            this.AssCopyText.Text = "Copyright:";
            // 
            // CopyrightTextBox
            // 
            this.CopyrightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.CopyrightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CopyrightTextBox.Enabled = false;
            this.CopyrightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.CopyrightTextBox.Location = new System.Drawing.Point(493, 256);
            this.CopyrightTextBox.MaxLength = 100;
            this.CopyrightTextBox.Name = "CopyrightTextBox";
            this.CopyrightTextBox.Size = new System.Drawing.Size(200, 20);
            this.CopyrightTextBox.TabIndex = 201;
            this.CopyrightTextBox.TabStop = false;
            this.CopyrightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssProdText
            // 
            this.AssProdText.AutoSize = true;
            this.AssProdText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.AssProdText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.AssProdText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssProdText.Location = new System.Drawing.Point(398, 237);
            this.AssProdText.Name = "AssProdText";
            this.AssProdText.Size = new System.Drawing.Size(67, 13);
            this.AssProdText.TabIndex = 200;
            this.AssProdText.Text = "Description:";
            // 
            // DescriptTextBox
            // 
            this.DescriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.DescriptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptTextBox.Enabled = false;
            this.DescriptTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.DescriptTextBox.Location = new System.Drawing.Point(493, 234);
            this.DescriptTextBox.MaxLength = 100;
            this.DescriptTextBox.Name = "DescriptTextBox";
            this.DescriptTextBox.Size = new System.Drawing.Size(200, 20);
            this.DescriptTextBox.TabIndex = 199;
            this.DescriptTextBox.TabStop = false;
            this.DescriptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NsiDescText
            // 
            this.NsiDescText.AutoSize = true;
            this.NsiDescText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.NsiDescText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.NsiDescText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NsiDescText.Location = new System.Drawing.Point(398, 193);
            this.NsiDescText.Name = "NsiDescText";
            this.NsiDescText.Size = new System.Drawing.Size(79, 13);
            this.NsiDescText.TabIndex = 198;
            this.NsiDescText.Text = "ProductName:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Enabled = false;
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.NameTextBox.Location = new System.Drawing.Point(493, 190);
            this.NameTextBox.MaxLength = 100;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 197;
            this.NameTextBox.TabStop = false;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NsiVersionText
            // 
            this.NsiVersionText.AutoSize = true;
            this.NsiVersionText.Font = new System.Drawing.Font("Georgia", 7.25F);
            this.NsiVersionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.NsiVersionText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NsiVersionText.Location = new System.Drawing.Point(398, 302);
            this.NsiVersionText.Name = "NsiVersionText";
            this.NsiVersionText.Size = new System.Drawing.Size(88, 13);
            this.NsiVersionText.TabIndex = 196;
            this.NsiVersionText.Text = "ProductVersion:";
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.VersionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VersionTextBox.Enabled = false;
            this.VersionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.VersionTextBox.Location = new System.Drawing.Point(493, 299);
            this.VersionTextBox.MaxLength = 100;
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.Size = new System.Drawing.Size(200, 20);
            this.VersionTextBox.TabIndex = 195;
            this.VersionTextBox.TabStop = false;
            this.VersionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LsizeIco
            // 
            this.LsizeIco.AutoSize = true;
            this.LsizeIco.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LsizeIco.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LsizeIco.Location = new System.Drawing.Point(126, 200);
            this.LsizeIco.Name = "LsizeIco";
            this.LsizeIco.Size = new System.Drawing.Size(0, 16);
            this.LsizeIco.TabIndex = 214;
            this.LsizeIco.Visible = false;
            // 
            // StatusCompile
            // 
            this.StatusCompile.AutoSize = true;
            this.StatusCompile.ForeColor = System.Drawing.Color.GreenYellow;
            this.StatusCompile.Location = new System.Drawing.Point(58, 388);
            this.StatusCompile.Name = "StatusCompile";
            this.StatusCompile.Size = new System.Drawing.Size(0, 13);
            this.StatusCompile.TabIndex = 216;
            // 
            // AutoGenNsis
            // 
            this.AutoGenNsis.BackColor = System.Drawing.Color.Transparent;
            this.AutoGenNsis.BGColor = "#508ef5";
            this.AutoGenNsis.FontColor = "#ffffff";
            this.AutoGenNsis.Location = new System.Drawing.Point(493, 404);
            this.AutoGenNsis.Name = "AutoGenNsis";
            this.AutoGenNsis.Size = new System.Drawing.Size(200, 31);
            this.AutoGenNsis.TabIndex = 218;
            this.AutoGenNsis.TabStop = false;
            this.AutoGenNsis.Text = "Сгенерировать свойства";
            this.AutoGenNsis.Click += new System.EventHandler(this.AutoGenNsis_Click);
            // 
            // RunFileWithAdminBox
            // 
            this.RunFileWithAdminBox.AutoSize = true;
            this.RunFileWithAdminBox.BackColor = System.Drawing.Color.Transparent;
            this.RunFileWithAdminBox.Location = new System.Drawing.Point(8, 255);
            this.RunFileWithAdminBox.Name = "RunFileWithAdminBox";
            this.RunFileWithAdminBox.Size = new System.Drawing.Size(260, 20);
            this.RunFileWithAdminBox.TabIndex = 217;
            this.RunFileWithAdminBox.TabStop = false;
            this.RunFileWithAdminBox.Text = "Запускать файлы от имени Администратора";
            this.RunFileWithAdminBox.UseVisualStyleBackColor = false;
            // 
            // PropetriesBox
            // 
            this.PropetriesBox.AutoSize = true;
            this.PropetriesBox.BackColor = System.Drawing.Color.Transparent;
            this.PropetriesBox.Location = new System.Drawing.Point(401, 160);
            this.PropetriesBox.Name = "PropetriesBox";
            this.PropetriesBox.Size = new System.Drawing.Size(214, 20);
            this.PropetriesBox.TabIndex = 194;
            this.PropetriesBox.TabStop = false;
            this.PropetriesBox.Text = "Добавить свойства для билд файла";
            this.PropetriesBox.UseVisualStyleBackColor = false;
            this.PropetriesBox.CheckedChanged += new System.EventHandler(this.PropetriesBox_CheckedChanged);
            // 
            // HideFilesBox
            // 
            this.HideFilesBox.AutoSize = true;
            this.HideFilesBox.BackColor = System.Drawing.Color.Transparent;
            this.HideFilesBox.Location = new System.Drawing.Point(8, 278);
            this.HideFilesBox.Name = "HideFilesBox";
            this.HideFilesBox.Size = new System.Drawing.Size(212, 20);
            this.HideFilesBox.TabIndex = 193;
            this.HideFilesBox.TabStop = false;
            this.HideFilesBox.Text = "Скрывать файлы после распаковки";
            this.HideFilesBox.UseVisualStyleBackColor = false;
            // 
            // AdmRunBuildBox
            // 
            this.AdmRunBuildBox.AutoSize = true;
            this.AdmRunBuildBox.BackColor = System.Drawing.Color.Transparent;
            this.AdmRunBuildBox.Location = new System.Drawing.Point(8, 232);
            this.AdmRunBuildBox.Name = "AdmRunBuildBox";
            this.AdmRunBuildBox.Size = new System.Drawing.Size(233, 20);
            this.AdmRunBuildBox.TabIndex = 192;
            this.AdmRunBuildBox.TabStop = false;
            this.AdmRunBuildBox.Text = "Запуск билд файла от Администратора";
            this.AdmRunBuildBox.UseVisualStyleBackColor = false;
            // 
            // SuicideBuildBox
            // 
            this.SuicideBuildBox.AutoSize = true;
            this.SuicideBuildBox.BackColor = System.Drawing.Color.Transparent;
            this.SuicideBuildBox.Location = new System.Drawing.Point(8, 301);
            this.SuicideBuildBox.Name = "SuicideBuildBox";
            this.SuicideBuildBox.Size = new System.Drawing.Size(251, 20);
            this.SuicideBuildBox.TabIndex = 191;
            this.SuicideBuildBox.TabStop = false;
            this.SuicideBuildBox.Text = "Само-удаление билд файла после запуска";
            this.SuicideBuildBox.UseVisualStyleBackColor = false;
            // 
            // AddIcoBox
            // 
            this.AddIcoBox.AutoSize = true;
            this.AddIcoBox.BackColor = System.Drawing.Color.Transparent;
            this.AddIcoBox.Location = new System.Drawing.Point(107, 173);
            this.AddIcoBox.Name = "AddIcoBox";
            this.AddIcoBox.Size = new System.Drawing.Size(202, 20);
            this.AddIcoBox.TabIndex = 190;
            this.AddIcoBox.TabStop = false;
            this.AddIcoBox.Text = "Добавить иконку для билд файла";
            this.AddIcoBox.UseVisualStyleBackColor = false;
            this.AddIcoBox.CheckedChanged += new System.EventHandler(this.AddIcoBox_CheckedChanged);
            // 
            // CreateBuild
            // 
            this.CreateBuild.BackColor = System.Drawing.Color.Transparent;
            this.CreateBuild.BGColor = "#508ef5";
            this.CreateBuild.FontColor = "#ffffff";
            this.CreateBuild.Location = new System.Drawing.Point(8, 405);
            this.CreateBuild.Name = "CreateBuild";
            this.CreateBuild.Size = new System.Drawing.Size(251, 30);
            this.CreateBuild.TabIndex = 219;
            this.CreateBuild.TabStop = false;
            this.CreateBuild.Text = "Создать новый билд файла";
            this.CreateBuild.Click += new System.EventHandler(this.CreateBuild_Click);
            // 
            // NsisBinderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.CreateBuild);
            this.Controls.Add(this.AutoGenNsis);
            this.Controls.Add(this.RunFileWithAdminBox);
            this.Controls.Add(this.StatusCompile);
            this.Controls.Add(this.LsizeIco);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AssVerText);
            this.Controls.Add(this.FileDescriptTextBox);
            this.Controls.Add(this.AssGuidText);
            this.Controls.Add(this.TradeMarkTextBox);
            this.Controls.Add(this.NsiCompanyText);
            this.Controls.Add(this.CompanyTextBox);
            this.Controls.Add(this.AssFVText);
            this.Controls.Add(this.FileVerTextBox);
            this.Controls.Add(this.AssCopyText);
            this.Controls.Add(this.CopyrightTextBox);
            this.Controls.Add(this.AssProdText);
            this.Controls.Add(this.DescriptTextBox);
            this.Controls.Add(this.NsiDescText);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NsiVersionText);
            this.Controls.Add(this.VersionTextBox);
            this.Controls.Add(this.PropetriesBox);
            this.Controls.Add(this.HideFilesBox);
            this.Controls.Add(this.AdmRunBuildBox);
            this.Controls.Add(this.SuicideBuildBox);
            this.Controls.Add(this.AddIcoBox);
            this.Controls.Add(this.IconText);
            this.Controls.Add(this.IconTextBox);
            this.Controls.Add(this.IcoViewer);
            this.Controls.Add(this.DragInfo);
            this.Controls.Add(this.CountFiles);
            this.Controls.Add(this.ListFiles);
            this.Name = "NsisBinderFrm";
            this.Size = new System.Drawing.Size(696, 443);
            this.Load += new System.EventHandler(this.NsisBinderFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IcoViewer)).EndInit();
            this.MenuFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.BinderBox AddIcoBox;
        private System.Windows.Forms.Label IconText;
        private System.Windows.Forms.TextBox IconTextBox;
        private System.Windows.Forms.PictureBox IcoViewer;
        private System.Windows.Forms.Label DragInfo;
        private System.Windows.Forms.Label CountFiles;
        private System.Windows.Forms.ListBox ListFiles;
        private Design.BinderBox SuicideBuildBox;
        private Design.BinderBox HideFilesBox;
        private Design.BinderBox AdmRunBuildBox;
        private Design.BinderBox PropetriesBox;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AssVerText;
        private System.Windows.Forms.TextBox FileDescriptTextBox;
        private System.Windows.Forms.Label AssGuidText;
        private System.Windows.Forms.TextBox TradeMarkTextBox;
        private System.Windows.Forms.Label NsiCompanyText;
        private System.Windows.Forms.TextBox CompanyTextBox;
        private System.Windows.Forms.Label AssFVText;
        private System.Windows.Forms.TextBox FileVerTextBox;
        private System.Windows.Forms.Label AssCopyText;
        private System.Windows.Forms.TextBox CopyrightTextBox;
        private System.Windows.Forms.Label AssProdText;
        private System.Windows.Forms.TextBox DescriptTextBox;
        private System.Windows.Forms.Label NsiDescText;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NsiVersionText;
        private System.Windows.Forms.TextBox VersionTextBox;
        private System.Windows.Forms.Label LsizeIco;
        private System.Windows.Forms.Label StatusCompile;
        private System.Windows.Forms.ContextMenuStrip MenuFiles;
        private System.Windows.Forms.ToolStripMenuItem AddFileItem;
        private System.Windows.Forms.ToolStripSeparator SeparatorOne;
        private System.Windows.Forms.ToolStripMenuItem RemoveFileItem;
        private System.Windows.Forms.ToolStripSeparator SeparatorTwo;
        private System.Windows.Forms.ToolStripMenuItem CleanAllItems;
        private Design.BinderBox RunFileWithAdminBox;
        private Design.BindButton AutoGenNsis;
        private Design.BindButton CreateBuild;
    }
}
