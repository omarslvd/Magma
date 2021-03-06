﻿using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Magma
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainKryptonNavigator.Pages.Clear();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                FileInfo fi = new FileInfo(path);
                string fileName = fi.Name.Replace(fi.Extension, "");
                string synopsis = "";

                ScreenNotification.Wait(this);
                EnabledControls(false);
                StatusToolStripStatusLabel.Text = "Opening file...";

                KryptonPage kryptonPage = new KryptonPage(fileName);
                ScriptUserControl scriptUserControl = new ScriptUserControl();
                List<ParameterControl> parameterControls = new List<ParameterControl>();

                scriptUserControl.Dock = DockStyle.Fill;

                scriptUserControl.Path = path;
                scriptUserControl.Title = fileName;

                using (PowerShell powerShellInstance = PowerShell.Create())
                {
                    ExecuteMainScript(powerShellInstance, path);

                    Collection<string> results = ExecuteScript(powerShellInstance, $"(Get-Help {fileName} -Full).Synopsis");

                    synopsis = results[0];

                    results = ExecuteScript(powerShellInstance, $"(Get-Help {fileName} -Full).Parameters.Parameter.Count");

                    int count = Convert.ToInt32(results[0]);

                    for (int i = 0; i < count; i++)
                    {
                        string name = "";
                        string description = "";
                        Type dataType = null;
                        ParameterControlType parameterControlType = ParameterControlType.Text;
                        bool isRequired = false;
                        string defaultValue = "";
                        string helpText = "";

                        results = ExecuteScript(powerShellInstance, $"(Get-Help {fileName} -Full).Parameters.Parameter[{i}].Name");

                        name = results[0];

                        results = ExecuteScript(powerShellInstance, $"(Get-Help {fileName} -Full).Parameters.Parameter[{i}].Description.Text");

                        description = results.Count > 0 ? results[0] : "";

                        results = ExecuteScript(powerShellInstance, $"(Get-Help {fileName} -Full).Parameters.Parameter[{i}].Type.Name");

                        dataType = Type.GetType($"System.{results[0]}");

                        parameterControlType = description.Contains("[TEXT]") ? ParameterControlType.Text :
                            description.Contains("[NUMERIC]") ? ParameterControlType.Numeric :
                            description.Contains("[DATETIME]") ? ParameterControlType.DateTime :
                            description.Contains("[FILEDIALOG]") ? ParameterControlType.FileDialog :
                            description.Contains("[FOLDERDIALOG]") ? ParameterControlType.FolderDialog :
                            dataType == typeof(Int32) || dataType == typeof(Int64) || dataType == typeof(Byte) || dataType == typeof(Decimal) || dataType == typeof(Single) || dataType == typeof(Double) ? ParameterControlType.Numeric : ParameterControlType.Text;

                        description = description.Replace("[TEXT]", "").Replace("[NUMERIC]", "").Replace("[DATETIME]", "").Replace("[FILEDIALOG]", "").Replace("[FOLDERDIALOG]", "");

                        results = ExecuteScript(powerShellInstance, $"(Get-Help {fileName} -Full).Parameters.Parameter[{i}].Required");

                        isRequired = results[0].ToString().Equals("true", StringComparison.InvariantCultureIgnoreCase) ? true : false;

                        results = ExecuteScript(powerShellInstance, $"(Get-Help {fileName} -Full).Parameters.Parameter[{i}].DefaultValue");

                        defaultValue = results.Count > 0 ? results[0].ToString() : "";

                        results = ExecuteScript(powerShellInstance, $"(Get-Command -Name '{fileName}').Parameters['{name}'].Attributes.HelpMessage");

                        helpText = results.Count > 0 ? results[0] : "";

                        parameterControls.Add(new ParameterControl() { Name = name, DisplayName = description, DataType = dataType, ControlType = parameterControlType, IsRequired = isRequired, DefaultValue = defaultValue, HelpText = helpText });
                    }
                }

                scriptUserControl.Description = synopsis;

                scriptUserControl.ParameterControls = parameterControls;

                kryptonPage.Tag = scriptUserControl;

                kryptonPage.Controls.Add(scriptUserControl);

                MainKryptonNavigator.Pages.Add(kryptonPage);

                MainKryptonNavigator.SelectedPage = kryptonPage;

                StatusToolStripStatusLabel.Text = "Ready";
                EnabledControls(true);
                ScreenNotification.Default(this);
            }
        }

        private void RunToolStripButton_Click(object sender, EventArgs e)
        {
            KryptonPage kryptonPage = MainKryptonNavigator.SelectedPage;
            ScriptUserControl scriptUserControl = (ScriptUserControl)kryptonPage.Tag;

            string path = scriptUserControl.Path;
            FileInfo fi = new FileInfo(path);
            string fileName = fi.Name.Replace(fi.Extension, "");
            string script = "";

            ScreenNotification.Wait(this);
            EnabledControls(false);
            StatusToolStripStatusLabel.Text = "Executing script...";

            foreach (ParameterControl parameterControl in scriptUserControl.ParameterControls)
            {
                if (string.IsNullOrEmpty(parameterControl.Control.Text) && parameterControl.IsRequired)
                {
                    MessageBox.Show($"The {parameterControl.DisplayName} parameter is required");

                    StatusToolStripStatusLabel.Text = "Ready";
                    EnabledControls(true);
                    ScreenNotification.Default(this);

                    return;
                }
            }

            using (PowerShell powerShellInstance = PowerShell.Create())
            {
                ExecuteMainScript(powerShellInstance, path);

                script = $"{scriptUserControl.Title} ";

                Dictionary<string, string> parameters = new Dictionary<string, string>();

                foreach (ParameterControl parameterControl in scriptUserControl.ParameterControls)
                {
                    string value = "";

                    if (parameterControl.DataType == typeof(string))
                    {
                        value = $"'{parameterControl.Control.Text}'";
                    }
                    else if (parameterControl.DataType == typeof(string))
                    {
                        value = $"(Get-Date -date '{parameterControl.Control.Text}')";
                    }
                    else
                    {
                        value = parameterControl.Control.Text;
                    }

                    if (!string.IsNullOrEmpty(value))
                    {
                        parameters.Add($"-{parameterControl.Name}", value);
                    }
                }

                script = $"{scriptUserControl.Title} " + String.Join(" ", parameters.Select(x => $"{x.Key} {x.Value}"));

                Collection<string> results = ExecuteScript(powerShellInstance, script);

                if (results.Count > 0)
                {
                    MessageBox.Show(results[0].ToString());
                }
            }

            StatusToolStripStatusLabel.Text = "Ready";
            EnabledControls(true);
            ScreenNotification.Default(this);
        }

        private void AboutToolStripButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();

            aboutForm.ShowDialog();
        }

        private void MainKryptonNavigator_TabCountChanged(object sender, EventArgs e)
        {
            RunToolStripButton.Enabled = MainKryptonNavigator.Visible = MainKryptonNavigator.Pages.Count > 0;
        }

        private Collection<string> ExecuteMainScript(PowerShell PowerShellInstance, string path)
        {
            Collection<string> results = new Collection<string>();
            FileInfo fi = new FileInfo(path);
            string fileName = fi.Name.Replace(fi.Extension, "");

            string script = File.ReadAllText(path);

            PowerShellInstance.AddScript(script);

            Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

            StringBuilder sb = new StringBuilder();

            if (PowerShellInstance.Streams.Error.Count > 0)
            {
                foreach (ErrorRecord error in PowerShellInstance.Streams.Error)
                {
                    sb.AppendLine(error.Exception.Message);
                    sb.AppendLine();
                }

                MessageBox.Show(sb.ToString());
            }

            foreach (PSObject outputItem in PSOutput)
            {
                if (outputItem != null)
                {
                    results.Add(outputItem.BaseObject.ToString());
                }
            }

            return results;
        }

        private Collection<string> ExecuteScript(PowerShell PowerShellInstance, string script)
        {
            Collection<string> results = new Collection<string>();

            PowerShellInstance.AddScript(script);

            Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

            StringBuilder sb = new StringBuilder();

            if (PowerShellInstance.Streams.Error.Count > 0)
            {
                foreach (ErrorRecord error in PowerShellInstance.Streams.Error)
                {
                    sb.AppendLine(error.Exception.Message);
                    sb.AppendLine();
                }

                MessageBox.Show(sb.ToString());
            }

            foreach (PSObject outputItem in PSOutput)
            {
                if (outputItem != null)
                {
                    results.Add(outputItem.BaseObject.ToString());
                }
            }

            return results;
        }

        private void EnabledControls(bool enabled)
        {
            OpenToolStripButton.Enabled = RunToolStripButton.Enabled = MainKryptonNavigator.Enabled = enabled;
        }
    }
}
