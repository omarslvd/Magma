using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Magma
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            KryptonPage kryptonPage = new KryptonPage("Hello World!");
            ScriptUserControl scriptUserControl = new ScriptUserControl();

            scriptUserControl.Dock = DockStyle.Fill;

            scriptUserControl.Title = "Hello World!";
            scriptUserControl.Description = "This is a description :)";

            List<ParameterControl> parameterControls = new List<ParameterControl>();

            parameterControls.Add(new ParameterControl() { Name = "one", DisplayName = "Mega display name", IsRequired = true, HelpText = "Help 1" });
            parameterControls.Add(new ParameterControl() { Name = "two", HelpText = "Help 2" });

            scriptUserControl.ParameterControls = parameterControls;

            kryptonPage.Controls.Add(scriptUserControl);

            MainKryptonNavigator.Pages.Add(kryptonPage);

            MainKryptonNavigator.SelectedPage = kryptonPage;
        }

        private void MainKryptonNavigator_TabCountChanged(object sender, EventArgs e)
        {
            MainKryptonNavigator.Visible = MainKryptonNavigator.Pages.Count > 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            kryptonWrapLabel1.Text = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede";
        }
    }
}
