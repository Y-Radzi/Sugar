using System.Data;

namespace Sugar
{
    public static partial class DataTableExtra
    {
        /// <summary>
        /// DataTable's data as string
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="rowDivider"></param>
        /// <param name="columnDivider"></param>
        /// <returns></returns>
        public static string Display(this DataTable dataTable, string rowDivider, string columnDivider, bool isUseRowIndex)
        {
            string result = "";
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (i != 0)
                    result += rowDivider;

                if (isUseRowIndex)
                    result += $"{i}{StringExtra.SplitterHeaderOfLineDefault}";

                for (int j = 0; j < dataTable.Columns.Count; j++)
                    result += ((j == 0) ? "" : columnDivider) + dataTable.Rows[i][j].ToString();
            }
            return result;
        }

        /// <summary>
        /// DataTable's data as string with default dividers
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static string Display(this DataTable dataTable)
        {
            return dataTable.Display(StringExtra.SplitterRowDefault, StringExtra.SplitterColumnDefault, false);
        }
    }
}
