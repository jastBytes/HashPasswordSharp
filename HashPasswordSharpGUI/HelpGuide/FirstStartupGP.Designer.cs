namespace de.janbusch.HashPasswordSharp.HelpGuide
{
    partial class FirstStartupGP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateConfig = new System.Windows.Forms.Button();
            this.btnOpenConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to HashPasswordSharp!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "You have no configuration loaded or created yet. You have two options from here:";
            // 
            // btnCreateConfig
            // 
            this.btnCreateConfig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateConfig.Location = new System.Drawing.Point(53, 67);
            this.btnCreateConfig.Name = "btnCreateConfig";
            this.btnCreateConfig.Size = new System.Drawing.Size(162, 23);
            this.btnCreateConfig.TabIndex = 2;
            this.btnCreateConfig.Text = "Create new configuration";
            this.btnCreateConfig.UseVisualStyleBackColor = true;
            this.btnCreateConfig.Click += new System.EventHandler(this.btnCreateConfig_Click);
            // 
            // btnOpenConfig
            // 
            this.btnOpenConfig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenConfig.Location = new System.Drawing.Point(231, 67);
            this.btnOpenConfig.Name = "btnOpenConfig";
            this.btnOpenConfig.Size = new System.Drawing.Size(162, 23);
            this.btnOpenConfig.TabIndex = 2;
            this.btnOpenConfig.Text = "Open an existing configuration";
            this.btnOpenConfig.UseVisualStyleBackColor = true;
            this.btnOpenConfig.Click += new System.EventHandler(this.btnOpenConfig_Click);
            // 
            // FirstStartupGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOpenConfig);
            this.Controls.Add(this.btnCreateConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FirstStartupGP";
            this.Size = new System.Drawing.Size(461, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateConfig;
        private System.Windows.Forms.Button btnOpenConfig;
    }
}
