using System.Windows.Forms;

namespace Magma
{
    public static class ScreenNotification
    {
        public static void Wait(Form form)
        {
            Wait(form, true);
        }

        public static void Wait(Form form, bool applyCursor)
        {
            if (applyCursor)
            {
                form.Cursor = Cursors.WaitCursor;
            }

            TaskbarManager.SetProgressState(TaskbarProgressBarState.Indeterminate);
        }

        public static void Default(Form form)
        {
            Default(form, true);
        }

        public static void Default(Form form, bool applyCursor)
        {
            if (applyCursor)
            {
                form.Cursor = Cursors.Default;
            }

            TaskbarManager.SetProgressState(TaskbarProgressBarState.NoProgress);
        }
    }
}
