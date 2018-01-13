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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.scriptUserControl1 = new Magma.ScriptUserControl();
            this.scriptUserControl2 = new Magma.ScriptUserControl();
            this.scriptUserControl3 = new Magma.ScriptUserControl();
            this.MainToolStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainKryptonNavigator)).BeginInit();
            this.MainKryptonNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
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
            this.kryptonPage1,
            this.kryptonPage2});
            this.MainKryptonNavigator.SelectedIndex = 1;
            this.MainKryptonNavigator.Size = new System.Drawing.Size(464, 274);
            this.MainKryptonNavigator.TabIndex = 3;
            this.MainKryptonNavigator.TabCountChanged += new System.EventHandler(this.MainKryptonNavigator_TabCountChanged);
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.tableLayoutPanel2);
            this.kryptonPage1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(462, 247);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "BF9D04E63E224EE47F9A9E984E66E50B";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.kryptonTextBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.kryptonLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.kryptonTextBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 177);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.kryptonTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTextBox1.Location = new System.Drawing.Point(97, 3);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(340, 26);
            this.kryptonTextBox1.TabIndex = 1;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Text = "...";
            this.buttonSpecAny1.UniqueName = "B8B3122702A24B8295BB78E429513E69";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 35);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "krypton";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTextBox2.Location = new System.Drawing.Point(97, 35);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(340, 23);
            this.kryptonTextBox2.TabIndex = 3;
            this.kryptonTextBox2.Text = "kryptonTextBox2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magma.Properties.Resources.Help;
            this.pictureBox1.Location = new System.Drawing.Point(443, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.MainToolTip.SetToolTip(this.pictureBox1, "Help Text");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonWrapLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(12, 45);
            this.kryptonWrapLabel1.Margin = new System.Windows.Forms.Padding(12, 6, 12, 12);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(83, 13);
            this.kryptonWrapLabel1.StateCommon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel1.Text = "No description";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(59, 33);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Title";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(462, 247);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "F704AF7759D644237FAE79AE35E0E692";
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Description = null;
            this.scriptUserControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl1.Name = "scriptUserControl1";
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
            this.kryptonPage1.ResumeLayout(false);
            this.kryptonPage1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip MainToolTip;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ScriptUserControl scriptUserControl1;
        private ScriptUserControl scriptUserControl2;
        private ScriptUserControl scriptUserControl3;
    }
}