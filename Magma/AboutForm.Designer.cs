namespace Magma
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OKKryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NameKryptonLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.VersionKryptonLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.GitHubKryptonLinkLabel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magma.Properties.Resources.MarvelComicsMagma;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 251);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OKKryptonButton
            // 
            this.OKKryptonButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKKryptonButton.Location = new System.Drawing.Point(287, 215);
            this.OKKryptonButton.Name = "OKKryptonButton";
            this.OKKryptonButton.Size = new System.Drawing.Size(90, 25);
            this.OKKryptonButton.TabIndex = 1;
            this.OKKryptonButton.Values.Text = "OK";
            this.OKKryptonButton.Click += new System.EventHandler(this.OKKryptonButton_Click);
            // 
            // NameKryptonLabel
            // 
            this.NameKryptonLabel.Location = new System.Drawing.Point(173, 22);
            this.NameKryptonLabel.Name = "NameKryptonLabel";
            this.NameKryptonLabel.Size = new System.Drawing.Size(208, 20);
            this.NameKryptonLabel.TabIndex = 2;
            this.NameKryptonLabel.Values.Text = "Magma - PowerShell Script Executor";
            // 
            // VersionKryptonLabel
            // 
            this.VersionKryptonLabel.Location = new System.Drawing.Point(173, 48);
            this.VersionKryptonLabel.Name = "VersionKryptonLabel";
            this.VersionKryptonLabel.Size = new System.Drawing.Size(45, 20);
            this.VersionKryptonLabel.TabIndex = 3;
            this.VersionKryptonLabel.Values.Text = "1.0.0.0";
            // 
            // GitHubKryptonLinkLabel
            // 
            this.GitHubKryptonLinkLabel.Location = new System.Drawing.Point(173, 74);
            this.GitHubKryptonLinkLabel.Name = "GitHubKryptonLinkLabel";
            this.GitHubKryptonLinkLabel.Size = new System.Drawing.Size(214, 20);
            this.GitHubKryptonLinkLabel.TabIndex = 4;
            this.GitHubKryptonLinkLabel.Values.Text = "https://github.com/omarslvd/Magma";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OKKryptonButton;
            this.ClientSize = new System.Drawing.Size(389, 252);
            this.Controls.Add(this.GitHubKryptonLinkLabel);
            this.Controls.Add(this.VersionKryptonLabel);
            this.Controls.Add(this.NameKryptonLabel);
            this.Controls.Add(this.OKKryptonButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton OKKryptonButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel NameKryptonLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel VersionKryptonLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel GitHubKryptonLinkLabel;
    }
}