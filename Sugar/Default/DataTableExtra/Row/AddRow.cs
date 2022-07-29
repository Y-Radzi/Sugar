using System.Data;

namespace Sugar
{
    public static partial class DataTableExtra
    {
        public static void AddRow(this DataTable dataTable, int rowCount)
        {
            if (dataTable.Columns.Count == 0)
                dataTable.AddColumn();

            for (int i = 0; i < rowCount; i++)
                dataTable.Rows.Add();
        }

        public static void AddRow(this DataTable dataTable)
        {
            dataTable.AddRow(1);
        }
    }
}
