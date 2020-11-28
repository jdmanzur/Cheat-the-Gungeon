namespace CheatEnterTheGungeon
{
    partial class mainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelCheatsSubMenu = new System.Windows.Forms.Panel();
            this.btnBlanks = new System.Windows.Forms.Button();
            this.btnHealf = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.btnCheats = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelProcessStatus = new System.Windows.Forms.Panel();
            this.labelProcessStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.processStatus = new System.ComponentModel.BackgroundWorker();
            this.panelSideMenu.SuspendLayout();
            this.panelCheatsSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panelProcessStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelCheatsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCheats);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.Image = global::CheatEnterTheGungeon.Properties.Resources.ponto;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 271);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(250, 45);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "    Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // panelCheatsSubMenu
            // 
            this.panelCheatsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelCheatsSubMenu.Controls.Add(this.btnBlanks);
            this.panelCheatsSubMenu.Controls.Add(this.btnHealf);
            this.panelCheatsSubMenu.Controls.Add(this.btnMoney);
            this.panelCheatsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCheatsSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelCheatsSubMenu.Name = "panelCheatsSubMenu";
            this.panelCheatsSubMenu.Size = new System.Drawing.Size(250, 126);
            this.panelCheatsSubMenu.TabIndex = 1;
            // 
            // btnBlanks
            // 
            this.btnBlanks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBlanks.FlatAppearance.BorderSize = 0;
            this.btnBlanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlanks.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlanks.ForeColor = System.Drawing.Color.LightGray;
            this.btnBlanks.Location = new System.Drawing.Point(0, 80);
            this.btnBlanks.Name = "btnBlanks";
            this.btnBlanks.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBlanks.Size = new System.Drawing.Size(250, 40);
            this.btnBlanks.TabIndex = 2;
            this.btnBlanks.Text = "Blanks";
            this.btnBlanks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlanks.UseVisualStyleBackColor = true;
            this.btnBlanks.Click += new System.EventHandler(this.btnBlanks_Click);
            // 
            // btnHealf
            // 
            this.btnHealf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHealf.FlatAppearance.BorderSize = 0;
            this.btnHealf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealf.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealf.ForeColor = System.Drawing.Color.LightGray;
            this.btnHealf.Location = new System.Drawing.Point(0, 40);
            this.btnHealf.Name = "btnHealf";
            this.btnHealf.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHealf.Size = new System.Drawing.Size(250, 40);
            this.btnHealf.TabIndex = 1;
            this.btnHealf.Text = "Health";
            this.btnHealf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHealf.UseVisualStyleBackColor = true;
            this.btnHealf.Click += new System.EventHandler(this.btnHealf_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoney.FlatAppearance.BorderSize = 0;
            this.btnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoney.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoney.ForeColor = System.Drawing.Color.LightGray;
            this.btnMoney.Location = new System.Drawing.Point(0, 0);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMoney.Size = new System.Drawing.Size(250, 40);
            this.btnMoney.TabIndex = 0;
            this.btnMoney.Text = "Money";
            this.btnMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnCheats
            // 
            this.btnCheats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheats.FlatAppearance.BorderSize = 0;
            this.btnCheats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheats.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheats.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheats.Image = global::CheatEnterTheGungeon.Properties.Resources.jogos;
            this.btnCheats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheats.Location = new System.Drawing.Point(0, 100);
            this.btnCheats.Name = "btnCheats";
            this.btnCheats.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCheats.Size = new System.Drawing.Size(250, 45);
            this.btnCheats.TabIndex = 0;
            this.btnCheats.Text = "     Cheats";
            this.btnCheats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheats.UseVisualStyleBackColor = true;
            this.btnCheats.Click += new System.EventHandler(this.btnCheats_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CheatEnterTheGungeon.Properties.Resources.controle_1_;
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelChildForm.Controls.Add(this.panelProcessStatus);
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 561);
            this.panelChildForm.TabIndex = 2;
            // 
            // panelProcessStatus
            // 
            this.panelProcessStatus.Controls.Add(this.labelProcessStatus);
            this.panelProcessStatus.Controls.Add(this.label1);
            this.panelProcessStatus.Location = new System.Drawing.Point(38, 45);
            this.panelProcessStatus.Name = "panelProcessStatus";
            this.panelProcessStatus.Size = new System.Drawing.Size(586, 100);
            this.panelProcessStatus.TabIndex = 1;
            // 
            // labelProcessStatus
            // 
            this.labelProcessStatus.AutoSize = true;
            this.labelProcessStatus.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProcessStatus.Location = new System.Drawing.Point(99, 41);
            this.labelProcessStatus.Name = "labelProcessStatus";
            this.labelProcessStatus.Size = new System.Drawing.Size(160, 82);
            this.labelProcessStatus.TabIndex = 1;
            this.labelProcessStatus.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::CheatEnterTheGungeon.Properties.Resources.header;
            this.pictureBox2.Location = new System.Drawing.Point(46, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(578, 283);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // processStatus
            // 
            this.processStatus.WorkerReportsProgress = true;
            this.processStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processStatus_DoWork);
            this.processStatus.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.processStatus_ProgressChanged);
            this.processStatus.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.processStatus_RunWorkerCompleted);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "mainForm";
            this.Text = "Cheat Enter th Gungeon v0.0.1";
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.panelSideMenu.ResumeLayout(false);
            this.panelCheatsSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelProcessStatus.ResumeLayout(false);
            this.panelProcessStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelCheatsSubMenu;
        private System.Windows.Forms.Button btnBlanks;
        private System.Windows.Forms.Button btnHealf;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnCheats;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelProcessStatus;
        private System.ComponentModel.BackgroundWorker processStatus;
        private System.Windows.Forms.Label labelProcessStatus;
        private System.Windows.Forms.Label label1;
    }
}

