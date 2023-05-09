using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redream
{
    internal class MyFunctions
    {
        public static int SearchValueInDatagridView(DataGridView grid, string searchValue, int cell = 0)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[cell].Value != null && row.Cells[cell].Value.ToString().ToLower() == searchValue.ToLower())
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            return rowIndex;
        }

        public static int SearchValueInList(List<string> list, string searchValue)
        {
            int index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == searchValue)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
