namespace de.janbusch.HashPasswordSharp.HelpGuide
{
    partial class Guide
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
            this.label1 = new System.Windows.Forms.Label();
            this.guidePanel = new System.Windows.Forms.Panel();
            this.comboBoxTopic = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "The HashPasswordSharp User Guide";
            // 
            // guidePanel
            // 
            this.guidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guidePanel.Location = new System.Drawing.Point(12, 36);
            this.guidePanel.Name = "guidePanel";
            this.guidePanel.Size = new System.Drawing.Size(527, 312);
            this.guidePanel.TabIndex = 1;
            // 
            // comboBoxTopic
            // 
            this.comboBoxTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTopic.DisplayMember = "Title";
            this.comboBoxTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTopic.FormattingEnabled = true;
            this.comboBoxTopic.Location = new System.Drawing.Point(374, 12);
            this.comboBoxTopic.Name = "comboBoxTopic";
            this.comboBoxTopic.Size = new System.Drawing.Size(165, 21);
            this.comboBoxTopic.TabIndex = 2;
            this.comboBoxTopic.ValueMember = "Title";
            // 
            // Guide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 360);
            this.Controls.Add(this.comboBoxTopic);
            this.Controls.Add(this.guidePanel);
            this.Controls.Add(this.label1);
            this.Name = "Guide";
            this.Text = "HashPasswordSharp Guide";
            this.Load += new System.EventHandler(this.Guide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel guidePanel;
        private System.Windows.Forms.ComboBox comboBoxTopic;
    }
}