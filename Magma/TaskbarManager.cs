using System.Drawing;

namespace Magma
{
    public sealed class TaskbarManager
    {
        private TaskbarManager()
        {
        }

        public static void SetOverlayIcon(Icon icon)
        {
            if (Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.IsPlatformSupported)
            {
                Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance.SetOverlayIcon(icon, "");
            }
        }

        public static void SetProgressState(TaskbarProgressBarState state)
        {
            if (Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.IsPlatformSupported)
            {
                Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance.SetProgressState((Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState)state);
            }
        }

        public static void SetProgressValue(int currentValue, int maximumValue)
        {
            if (Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.IsPlatformSupported)
            {
                Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance.SetProgressValue(currentValue, maximumValue);
            }
        }
    }
}
