using System.Data;

namespace Sugar
{
    public static partial class DataTableExtra
    {
        public static void DeleteLastColumn(this DataTable dataTable)
        {
            if (dataTable.Columns.Count > 0)
                dataTable.Columns.RemoveAt(dataTable.Columns.Count - 1);
        }

    }
}
