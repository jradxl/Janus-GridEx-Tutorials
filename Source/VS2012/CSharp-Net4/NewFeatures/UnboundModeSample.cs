using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
namespace NewFeatures
{
    public partial class UnboundModeSample : UserControl
    {
        public UnboundModeSample()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadGrid();
        }
        private void LoadGrid()
        {
            //Set GridEX in unbound mode
            this.gridEX1.BoundMode = BoundMode.Unbound;
            this.gridEX1.AllowAddNew = InheritableBoolean.True;
            this.gridEX1.AllowDelete = InheritableBoolean.True;
            this.gridEX1.RowHeaders = InheritableBoolean.True;
            //Create root table and columns
            GridEXTable gridTable = new GridEXTable();
            //Assign the table as the root table of the grid
            gridEX1.RootTable = gridTable;
            GridEXColumn column;
            column = gridTable.Columns.Add("Id", ColumnType.Text);
            column.DataTypeCode = TypeCode.Int32;
            column = gridTable.Columns.Add("Name", ColumnType.Text);
            column.DataTypeCode = TypeCode.String;
            column = gridTable.Columns.Add("Date", ColumnType.Text, EditType.CalendarCombo);
            column.DataTypeCode = TypeCode.DateTime;
            column.DefaultValue = DateTime.Today;
            column.FormatString = "d";



            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            GridEXRow newItem = this.gridEX1.AddItem();
            //To set values in a GridEXRow, you must do it between BeginEdit, EndEdit calls
            newItem.BeginEdit();
            newItem.Cells["Id"].Value = 0;
            newItem.Cells["Name"].Value = "New Item";
            newItem.EndEdit();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            GridEXRow currentRow = gridEX1.GetRow();
            if (currentRow == null || currentRow.RowType != RowType.Record)
            {
                MessageBox.Show("Select the row to delete","UnboundMode Sample",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            currentRow.Delete();
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            this.gridEX1.ClearItems();
        }
    }
}
