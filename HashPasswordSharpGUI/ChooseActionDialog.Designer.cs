namespace de.janbusch.HashPasswordSharp
{
    partial class ChooseActionDialog
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
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowQRCode = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pbQrCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(12, 40);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(154, 23);
            this.btnCopyToClipboard.TabIndex = 0;
            this.btnCopyToClipboard.Text = "&Copy password to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 69);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(106, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show &password";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your password was generated. What would you like to do?";
            // 
            // btnShowQRCode
            // 
            this.btnShowQRCode.Location = new System.Drawing.Point(172, 40);
            this.btnShowQRCode.Name = "btnShowQRCode";
            this.btnShowQRCode.Size = new System.Drawing.Size(154, 23);
            this.btnShowQRCode.TabIndex = 1;
            this.btnShowQRCode.Text = "&Show password as QR-Code";
            this.btnShowQRCode.UseVisualStyleBackColor = true;
            this.btnShowQRCode.Click += new System.EventHandler(this.btnShowQRCode_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // pbQrCode
            // 
            this.pbQrCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbQrCode.BackColor = System.Drawing.Color.White;
            this.pbQrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQrCode.Location = new System.Drawing.Point(12, 98);
            this.pbQrCode.Name = "pbQrCode";
            this.pbQrCode.Size = new System.Drawing.Size(313, 313);
            this.pbQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQrCode.TabIndex = 4;
            this.pbQrCode.TabStop = false;
            // 
            // ChooseActionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 423);
            this.Controls.Add(this.pbQrCode);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowQRCode);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnCopyToClipboard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseActionDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password generated!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseActionDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowQRCode;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbQrCode;
    }
}