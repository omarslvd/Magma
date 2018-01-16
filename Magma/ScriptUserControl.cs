using ComponentFactory.Krypton.Toolkit;
using Magma.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Magma
{
    public partial class ScriptUserControl : UserControl
    {
        public string Path { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<ParameterControl> ParameterControls { get; set; }

        public ScriptUserControl()
        {
            InitializeComponent();

            ParameterControls = new List<ParameterControl>();
        }

        private void ScriptUserControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                if (!string.IsNullOrEmpty(Title))
                {
                    TitleKryptonLabel.Text = Title;
                }

                if (!string.IsNullOrEmpty(Description))
                {
                    DescriptionKryptonWrapLabel.Text = Description;
                }

                ParameterTableLayoutPanel.Controls.Clear();
                ParameterTableLayoutPanel.ColumnCount = 0;
                ParameterTableLayoutPanel.RowCount = 0;

                if (ParameterControls.Count > 0)
                {
                    ParameterTableLayoutPanel.ColumnCount = 3;
                    ParameterTableLayoutPanel.RowCount = ParameterControls.Count;

                    for (int i = 0; i < ParameterControls.Count; i++)
                    {
                        ParameterControl parameterControl = ParameterControls[i];

                        KryptonLabel kryptonLabel = new KryptonLabel();

                        kryptonLabel.Name = $"{parameterControl.Name}KryptonLabel";

                        if (string.IsNullOrEmpty(parameterControl.DisplayName))
                        {
                            parameterControl.DisplayName = parameterControl.Name;
                        }

                        if (parameterControl.IsRequired)
                        {
                            kryptonLabel.Text = parameterControl.DisplayName;
                        }
                        else
                        {
                            kryptonLabel.Text = $"{parameterControl.DisplayName} (optional)";
                        }

                        if (parameterControl.ControlType == ParameterControlType.Numeric)
                        {
                            KryptonNumericUpDown kryptonNumericUpDown = new KryptonNumericUpDown();

                            //kryptonNumericUpDown.DecimalPlaces = 4;
                            kryptonNumericUpDown.ResetText();
                            parameterControl.Control = kryptonNumericUpDown;

                            kryptonNumericUpDown.Name = $"{parameterControl.Name}KryptonNumericUpDown";
                            kryptonNumericUpDown.Dock = DockStyle.Fill;

                            ParameterTableLayoutPanel.Controls.Add(kryptonLabel, 0, i);
                            ParameterTableLayoutPanel.Controls.Add(kryptonNumericUpDown, 1, i);
                        }
                        else if (parameterControl.ControlType == ParameterControlType.FileDialog)
                        {
                            KryptonFileDialogTextBox kryptonFileDialogTextBox = new KryptonFileDialogTextBox();

                            parameterControl.Control = kryptonFileDialogTextBox;

                            kryptonFileDialogTextBox.Name = $"{parameterControl.Name}KryptonFileDialogTextBox";
                            kryptonFileDialogTextBox.Dock = DockStyle.Fill;

                            ParameterTableLayoutPanel.Controls.Add(kryptonLabel, 0, i);
                            ParameterTableLayoutPanel.Controls.Add(kryptonFileDialogTextBox, 1, i);
                        }
                        else if (parameterControl.ControlType == ParameterControlType.FolderDialog)
                        {
                            KryptonFolderDialogTextBox kryptonFolderDialogTextBox = new KryptonFolderDialogTextBox();

                            parameterControl.Control = kryptonFolderDialogTextBox;

                            kryptonFolderDialogTextBox.Name = $"{parameterControl.Name}KryptonFolderDialogTextBox";
                            kryptonFolderDialogTextBox.Dock = DockStyle.Fill;

                            ParameterTableLayoutPanel.Controls.Add(kryptonLabel, 0, i);
                            ParameterTableLayoutPanel.Controls.Add(kryptonFolderDialogTextBox, 1, i);
                        }
                        else
                        {
                            KryptonTextBox kryptonTextBox = new KryptonTextBox();

                            parameterControl.Control = kryptonTextBox;

                            kryptonTextBox.Name = $"{parameterControl.Name}KryptonTextBox";
                            kryptonTextBox.Dock = DockStyle.Fill;

                            ParameterTableLayoutPanel.Controls.Add(kryptonLabel, 0, i);
                            ParameterTableLayoutPanel.Controls.Add(kryptonTextBox, 1, i);
                        }

                        if (!string.IsNullOrEmpty(parameterControl.HelpText))
                        {
                            PictureBox pictureBox = new PictureBox();

                            pictureBox.Size = new Size(16, 16);
                            pictureBox.Image = Resources.Help;

                            InternalToolTip.SetToolTip(pictureBox, parameterControl.HelpText);

                            ParameterTableLayoutPanel.Controls.Add(pictureBox, 2, i);
                        }

                        ParameterTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }

                    ParameterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    ParameterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    ParameterTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                }
            }
        }
    }
}
