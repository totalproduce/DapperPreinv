using System.Windows.Controls;

namespace Bsdl.FreshTrade.UI.Basic.Utilities.WpfControls
{
    public class DataGridHelper
    {
        public static void FocusOnGridRow(DataGrid grid, int index)
        {
            if (!grid.HasItems || (index < 0) || (grid.Items.Count <= index))
            {
                return;
            }

            grid.SelectedItem = grid.Items[index];
            grid.Focus();
            grid.ScrollIntoView(grid.SelectedItem);
        }

        public static void FocusOnCell(DataGrid grid, int rowIndex, int colIndex)
        {
            // Exit if grid row/column doesn't exist
            if (!grid.HasItems || (rowIndex < 0) || (grid.Items.Count <= rowIndex) || (colIndex < 0) || (grid.Columns.Count <= colIndex))
            {
                return;
            }

            grid.SelectedItem = grid.Items[rowIndex];
            grid.Focus();

            DataGridCellInfo cellInfo = new DataGridCellInfo(grid.SelectedItem, grid.Columns[colIndex]);
            grid.CurrentCell = cellInfo;

            grid.ScrollIntoView(grid.SelectedItem);

            //grid.BeginEdit();
        }

        public static DataGridCell GetDataGridCell(DataGridRow row, DataGridColumn col)
        {
            //DataGridCellInfo cellInfo = new DataGridCellInfo(grid.Items[rowIndex], grid.Columns[colIndex]);
            DataGridCellInfo cellInfo = new DataGridCellInfo(row, col);
            return GetDataGridCell(cellInfo);
        }

        public static DataGridCell GetDataGridCell(DataGridCellInfo cellInfo)
        {
            if (!cellInfo.IsValid)
            {
                return null;
            }

            var cellContent = cellInfo.Column.GetCellContent(cellInfo.Item);
            if (cellContent == null)
            {
                return null;
            }
            return cellContent.Parent as DataGridCell;
        }

    }
}
