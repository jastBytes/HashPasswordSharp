namespace de.janbusch.HashPasswordSharp
{
    partial class HashPasswordSharp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtPassphraseReenter = new System.Windows.Forms.TextBox();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.btnDeleteLogin = new System.Windows.Forms.Button();
            this.btnDeleteHost = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxHost = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageSynchronization = new System.Windows.Forms.TabPage();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConfigPath = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageHome);
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Controls.Add(this.tabPageSynchronization);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(12, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(414, 191);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.btnGeneratePassword);
            this.tabPageHome.Controls.Add(this.txtPassphraseReenter);
            this.tabPageHome.Controls.Add(this.txtPassphrase);
            this.tabPageHome.Controls.Add(this.btnDeleteLogin);
            this.tabPageHome.Controls.Add(this.btnDeleteHost);
            this.tabPageHome.Controls.Add(this.button3);
            this.tabPageHome.Controls.Add(this.comboBoxLogin);
            this.tabPageHome.Controls.Add(this.btnAddHost);
            this.tabPageHome.Controls.Add(this.label2);
            this.tabPageHome.Controls.Add(this.label4);
            this.tabPageHome.Controls.Add(this.comboBoxHost);
            this.tabPageHome.Controls.Add(this.label3);
            this.tabPageHome.Controls.Add(this.label1);
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(406, 165);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePassword.Enabled = false;
            this.btnGeneratePassword.Location = new System.Drawing.Point(11, 132);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(387, 23);
            this.btnGeneratePassword.TabIndex = 2;
            this.btnGeneratePassword.Text = "Generate password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            // 
            // txtPassphraseReenter
            // 
            this.txtPassphraseReenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassphraseReenter.Location = new System.Drawing.Point(119, 97);
            this.txtPassphraseReenter.Name = "txtPassphraseReenter";
            this.txtPassphraseReenter.Size = new System.Drawing.Size(279, 20);
            this.txtPassphraseReenter.TabIndex = 1;
            this.txtPassphraseReenter.UseSystemPasswordChar = true;
            // 
            // txtPassphrase
            // 
            this.txtPassphrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassphrase.Location = new System.Drawing.Point(119, 71);
            this.txtPassphrase.Name = "txtPassphrase";
            this.txtPassphrase.Size = new System.Drawing.Size(279, 20);
            this.txtPassphrase.TabIndex = 0;
            this.txtPassphrase.UseSystemPasswordChar = true;
            // 
            // btnDeleteLogin
            // 
            this.btnDeleteLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLogin.Location = new System.Drawing.Point(352, 36);
            this.btnDeleteLogin.Name = "btnDeleteLogin";
            this.btnDeleteLogin.Size = new System.Drawing.Size(46, 23);
            this.btnDeleteLogin.TabIndex = 8;
            this.btnDeleteLogin.Text = "Delete";
            this.btnDeleteLogin.UseVisualStyleBackColor = true;
            // 
            // btnDeleteHost
            // 
            this.btnDeleteHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteHost.Location = new System.Drawing.Point(352, 7);
            this.btnDeleteHost.Name = "btnDeleteHost";
            this.btnDeleteHost.Size = new System.Drawing.Size(46, 23);
            this.btnDeleteHost.TabIndex = 6;
            this.btnDeleteHost.Text = "Delete";
            this.btnDeleteHost.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(307, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLogin.DisplayMember = "Name";
            this.comboBoxLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Location = new System.Drawing.Point(85, 38);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(216, 21);
            this.comboBoxLogin.TabIndex = 4;
            this.comboBoxLogin.ValueMember = "Name";
            // 
            // btnAddHost
            // 
            this.btnAddHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHost.Location = new System.Drawing.Point(307, 7);
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.Size = new System.Drawing.Size(39, 23);
            this.btnAddHost.TabIndex = 5;
            this.btnAddHost.Text = "Add";
            this.btnAddHost.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reenter passphrase:";
            // 
            // comboBoxHost
            // 
            this.comboBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxHost.DisplayMember = "Name";
            this.comboBoxHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHost.FormattingEnabled = true;
            this.comboBoxHost.Location = new System.Drawing.Point(85, 9);
            this.comboBoxHost.Name = "comboBoxHost";
            this.comboBoxHost.Size = new System.Drawing.Size(216, 21);
            this.comboBoxHost.TabIndex = 3;
            this.comboBoxHost.ValueMember = "Name";
            this.comboBoxHost.SelectedIndexChanged += new System.EventHandler(this.comboBoxHost_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter passphrase:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Host:";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.lblConfigPath);
            this.tabPageSettings.Controls.Add(this.label5);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(406, 165);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabPageSynchronization
            // 
            this.tabPageSynchronization.Location = new System.Drawing.Point(4, 22);
            this.tabPageSynchronization.Name = "tabPageSynchronization";
            this.tabPageSynchronization.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSynchronization.Size = new System.Drawing.Size(406, 165);
            this.tabPageSynchronization.TabIndex = 2;
            this.tabPageSynchronization.Text = "Sync";
            this.tabPageSynchronization.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(187, 226);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(268, 225);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(349, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(438, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "HashPassword.xml";
            this.openFileDialog.Filter = "XML|*.xml";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Choose configuration";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Current configuration:";
            // 
            // lblConfigPath
            // 
            this.lblConfigPath.AutoSize = true;
            this.lblConfigPath.Location = new System.Drawing.Point(122, 7);
            this.lblConfigPath.Name = "lblConfigPath";
            this.lblConfigPath.Size = new System.Drawing.Size(0, 13);
            this.lblConfigPath.TabIndex = 1;
            // 
            // HashPasswordSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "HashPasswordSharp";
            this.Text = "HashPasswordSharp";
            this.Shown += new System.EventHandler(this.HashPasswordSharp_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TextBox txtPassphraseReenter;
        private System.Windows.Forms.TextBox txtPassphrase;
        private System.Windows.Forms.Button btnDeleteLogin;
        private System.Windows.Forms.Button btnDeleteHost;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxLogin;
        private System.Windows.Forms.Button btnAddHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageSynchronization;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblConfigPath;
        private System.Windows.Forms.Label label5;
    }
}

