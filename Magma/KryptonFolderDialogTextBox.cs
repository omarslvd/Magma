using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Magma
{
    public class KryptonFolderDialogTextBox : KryptonTextBox
    {
        public KryptonFolderDialogTextBox()
        {
            ButtonSpecAny button = new ButtonSpecAny();

            button.Text = "...";
            button.Click += Button_Click;

            this.ButtonSpecs.Add(button);
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            DialogResult dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                this.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
