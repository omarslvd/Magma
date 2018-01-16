namespace Magma
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.MainKryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RunToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainKryptonNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.scriptUserControl1 = new Magma.ScriptUserControl();
            this.scriptUserControl2 = new Magma.ScriptUserControl();
            this.scriptUserControl3 = new Magma.ScriptUserControl();
            this.MainToolStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainKryptonNavigator)).BeginInit();
            this.MainKryptonNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainKryptonManager
            // 
            this.MainKryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButton,
            this.toolStripSeparator1,
            this.RunToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(464, 25);
            this.MainToolStrip.Stretch = true;
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = global::Magma.Properties.Resources.Folder;
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "Open...";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RunToolStripButton
            // 
            this.RunToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RunToolStripButton.Image = global::Magma.Properties.Resources.Play;
            this.RunToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunToolStripButton.Name = "RunToolStripButton";
            this.RunToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RunToolStripButton.Text = "Run";
            this.RunToolStripButton.Click += new System.EventHandler(this.RunToolStripButton_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusToolStripStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 299);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(464, 22);
            this.MainStatusStrip.TabIndex = 2;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // StatusToolStripStatusLabel
            // 
            this.StatusToolStripStatusLabel.Name = "StatusToolStripStatusLabel";
            this.StatusToolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.StatusToolStripStatusLabel.Text = "Ready";
            // 
            // MainKryptonNavigator
            // 
            this.MainKryptonNavigator.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.StandardProfile;
            this.MainKryptonNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainKryptonNavigator.Location = new System.Drawing.Point(0, 25);
            this.MainKryptonNavigator.Name = "MainKryptonNavigator";
            this.MainKryptonNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1});
            this.MainKryptonNavigator.SelectedIndex = 0;
            this.MainKryptonNavigator.Size = new System.Drawing.Size(464, 274);
            this.MainKryptonNavigator.TabIndex = 3;
            this.MainKryptonNavigator.TabCountChanged += new System.EventHandler(this.MainKryptonNavigator_TabCountChanged);
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(462, 247);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "BF9D04E63E224EE47F9A9E984E66E50B";
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Description = null;
            this.scriptUserControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Path = null;
            this.scriptUserControl1.Size = new System.Drawing.Size(339, 215);
            this.scriptUserControl1.TabIndex = 0;
            this.scriptUserControl1.Title = null;
            // 
            // scriptUserControl2
            // 
            this.scriptUserControl2.Description = null;
            this.scriptUserControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptUserControl2.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl2.Name = "scriptUserControl2";
            this.scriptUserControl2.Path = null;
            this.scriptUserControl2.Size = new System.Drawing.Size(339, 215);
            this.scriptUserControl2.TabIndex = 0;
            this.scriptUserControl2.Title = null;
            // 
            // scriptUserControl3
            // 
            this.scriptUserControl3.Description = null;
            this.scriptUserControl3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptUserControl3.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl3.Name = "scriptUserControl3";
            this.scriptUserControl3.Path = null;
            this.scriptUserControl3.Size = new System.Drawing.Size(339, 215);
            this.scriptUserControl3.TabIndex = 0;
            this.scriptUserControl3.Title = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.MainKryptonNavigator);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainToolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Magma - PowerShell Script Executor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainKryptonNavigator)).EndInit();
            this.MainKryptonNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager MainKryptonManager;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton RunToolStripButton;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusToolStripStatusLabel;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator MainKryptonNavigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip MainToolTip;
        private ScriptUserControl scriptUserControl1;
        private ScriptUserControl scriptUserControl2;
        private ScriptUserControl scriptUserControl3;
    }
}