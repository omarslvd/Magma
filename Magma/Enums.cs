namespace Magma
{
    public enum ParameterControlType : int
    {
        Text = 1,
        Numeric,
        DateTime,
        FileDialog,
        FolderDialog
    }

    public enum TaskbarProgressBarState : int
    {
        NoProgress = 0,
        Indeterminate = 1,
        Normal = 2,
        Error = 4,
        Paused = 8
    }
}
