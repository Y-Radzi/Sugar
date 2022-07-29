using System.Data;

namespace Sugar
{
    public static partial class DataTableExtra
    {
        public static void DeleteLastRow(this DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
                dataTable.Rows.RemoveAt(dataTable.Rows.Count - 1);
        }
    }
}
