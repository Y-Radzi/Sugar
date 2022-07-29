using System.Data;

namespace Sugar
{
    public static partial class DataTableExtra
    {
        public static void AddColumn(this DataTable dataTable, string columnName)
        {
            dataTable.Columns.Add(new DataColumn() { ColumnName = columnName });
        }

        /// <summary>
        /// Adds column with index's name
        /// </summary>
        /// <param name="dataTable"></param>
        public static void AddColumn(this DataTable dataTable)
        {
            dataTable.AddColumn(dataTable.Columns.Count.ToString());
        }

        public static void AddColumn(this DataTable dataTable, int columnsCount)
        {
            for (int i = 0; i < columnsCount; i++)
                dataTable.AddColumn();
        }

    }
}
