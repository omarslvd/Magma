namespace Magma
{
    public enum ParameterDataType : int
    {
        String = 1,
        Char,
        Byte,
        Int,
        Long,
        Bool,
        Decimal,
        Single,
        Double,
        DateTime
    }

    public enum ParameterControlType : int
    {
        Text = 1,
        Numeric,
        DateTime,
        FileDialog,
        FolderDialog
    }
}
