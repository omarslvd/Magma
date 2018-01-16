using ComponentFactory.Krypton.Toolkit;

namespace Magma
{
    public partial class AboutForm : KryptonForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OKKryptonButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
