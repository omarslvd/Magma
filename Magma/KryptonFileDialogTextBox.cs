using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Magma
{
    public class KryptonFileDialogTextBox : KryptonTextBox
    {
        public KryptonFileDialogTextBox()
        {
            ButtonSpecAny button = new ButtonSpecAny();

            button.Text = "...";
            button.Click += Button_Click;

            this.ButtonSpecs.Add(button);
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                this.Text = openFileDialog.FileName;
            }
        }
    }
}
