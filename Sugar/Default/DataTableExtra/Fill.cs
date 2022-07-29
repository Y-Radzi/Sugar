using System.Data;

namespace Sugar
{
    public static partial class DataTableExtra
    {
        /// <summary>
        /// Clear dataTable and set array as object data
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="array"></param>
        public static void Fill(this DataTable dataTable, object[,] array)
        {
            dataTable.Clear();
            dataTable.AddColumn(array.GetLength(1));
            dataTable.AddRow(array.GetLength(0));
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    dataTable.Rows[i][j] = array[i, j];
        }

    }
}
