namespace R3BinderTools
{
    partial class BindFrm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindFrm));
            this.UPanel = new System.Windows.Forms.Panel();
            this.NsisStatus = new System.Windows.Forms.Label();
            this.AppExit = new System.Windows.Forms.Button();
            this.LogoText = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.ShowNsis = new System.Windows.Forms.Button();
            this.ShowBinExe = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ShowBndPro = new System.Windows.Forms.Button();
            this.UPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UPanel
            // 
            this.UPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.UPanel.Controls.Add(this.NsisStatus);
            this.UPanel.Controls.Add(this.AppExit);
            this.UPanel.Controls.Add(this.LogoText);
            this.UPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UPanel.Location = new System.Drawing.Point(0, 0);
            this.UPanel.Name = "UPanel";
            this.UPanel.Size = new System.Drawing.Size(696, 27);
            this.UPanel.TabIndex = 4;
            // 
            // NsisStatus
            // 
            this.NsisStatus.AutoSize = true;
            this.NsisStatus.ForeColor = System.Drawing.Color.Coral;
            this.NsisStatus.Location = new System.Drawing.Point(132, 7);
            this.NsisStatus.Name = "NsisStatus";
            this.NsisStatus.Size = new System.Drawing.Size(0, 13);
            this.NsisStatus.TabIndex = 2;
            // 
            // AppExit
            // 
            this.AppExit.FlatAppearance.BorderSize = 0;
            this.AppExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AppExit.Location = new System.Drawing.Point(669, 2);
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(28, 24);
            this.AppExit.TabIndex = 0;
            this.AppExit.TabStop = false;
            this.AppExit.Text = "X";
            this.AppExit.UseVisualStyleBackColor = true;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // LogoText
            // 
            this.LogoText.AutoSize = true;
            this.LogoText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LogoText.Location = new System.Drawing.Point(6, 6);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(125, 13);
            this.LogoText.TabIndex = 1;
            this.LogoText.Text = "R3BinderTools [Release]";
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.ControlPanel.Controls.Add(this.ShowBndPro);
            this.ControlPanel.Controls.Add(this.ShowNsis);
            this.ControlPanel.Controls.Add(this.ShowBinExe);
            this.ControlPanel.Location = new System.Drawing.Point(0, 26);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(698, 31);
            this.ControlPanel.TabIndex = 5;
            // 
            // ShowNsis
            // 
            this.ShowNsis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.ShowNsis.FlatAppearance.BorderSize = 0;
            this.ShowNsis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowNsis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowNsis.Location = new System.Drawing.Point(111, 3);
            this.ShowNsis.Name = "ShowNsis";
            this.ShowNsis.Size = new System.Drawing.Size(106, 24);
            this.ShowNsis.TabIndex = 5;
            this.ShowNsis.TabStop = false;
            this.ShowNsis.Text = "NSIS Binder";
            this.ShowNsis.UseVisualStyleBackColor = false;
            this.ShowNsis.Click += new System.EventHandler(this.ShowNsis_Click);
            // 
            // ShowBinExe
            // 
            this.ShowBinExe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.ShowBinExe.FlatAppearance.BorderSize = 0;
            this.ShowBinExe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBinExe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowBinExe.Location = new System.Drawing.Point(3, 3);
            this.ShowBinExe.Name = "ShowBinExe";
            this.ShowBinExe.Size = new System.Drawing.Size(106, 24);
            this.ShowBinExe.TabIndex = 4;
            this.ShowBinExe.TabStop = false;
            this.ShowBinExe.Text = "R3 Binder";
            this.ShowBinExe.UseVisualStyleBackColor = false;
            this.ShowBinExe.Click += new System.EventHandler(this.ShowBinExe_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 58);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(696, 443);
            this.MainPanel.TabIndex = 6;
            // 
            // ShowBndPro
            // 
            this.ShowBndPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.ShowBndPro.FlatAppearance.BorderSize = 0;
            this.ShowBndPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBndPro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowBndPro.Location = new System.Drawing.Point(219, 3);
            this.ShowBndPro.Name = "ShowBndPro";
            this.ShowBndPro.Size = new System.Drawing.Size(106, 24);
            this.ShowBndPro.TabIndex = 6;
            this.ShowBndPro.TabStop = false;
            this.ShowBndPro.Text = "Multi Binder Pro";
            this.ShowBndPro.UseVisualStyleBackColor = false;
            // 
            // BindFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(696, 501);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.UPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BindFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R3BinderTools [Release]";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BindFrm_Load);
            this.UPanel.ResumeLayout(false);
            this.UPanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UPanel;
        private System.Windows.Forms.Label NsisStatus;
        private System.Windows.Forms.Button AppExit;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button ShowNsis;
        private System.Windows.Forms.Button ShowBinExe;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ShowBndPro;
    }
}

