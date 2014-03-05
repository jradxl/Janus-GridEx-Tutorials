using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
namespace Tutorial21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gridEX1.AddItem("Item 1", DateTime.Now);
            this.gridEX1.AddItem("Item 2", DateTime.Now);
            this.gridEX1.AddItem("Item 3", DateTime.Now);
            this.gridEX1.AddItem("Item 4", DateTime.Now);
            this.gridEX1.AddItem("Item 5", DateTime.Now);
            this.gridEX1.Row = 0;
        }

       

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Add a new row at the end of the list specifying its cell values.
            GridEXRow newRow = this.gridEX1.AddItem();
            //To edit values in cells of a row, call BeginEdit/EndEdit methods
            newRow.BeginEdit();
            newRow.Cells["Name"].Value = "AddItem";
            newRow.Cells["Date"].Value = DateTime.Now;
            newRow.EndEdit();
            //Move to the new item
            this.gridEX1.MoveTo(newRow);
        }

        private void btnInsertItem_Click(object sender, EventArgs e)
        {
            //Insert the item at the begining of the list.
            GridEXRow newRow = this.gridEX1.AddItem(this.gridEX1.Row);
            //To edit values in cells of a row, call BeginEdit/EndEdit methods
            newRow.BeginEdit();
            newRow.Cells["Name"].Value = "InsertItem";
            newRow.Cells["Date"].Value = DateTime.Now;
            newRow.EndEdit();

            //Move to the new item
            gridEX1.MoveTo(newRow);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //Get selected row
            GridEXRow item = gridEX1.CurrentRow;
            if (item != null && item.RowType == RowType.Record)
            {
                //Delete the row.
                item.Delete();
            }
            else
            {
                MessageBox.Show("Select an item to delete.");
            }
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            //Clear all items in GridEX
            this.gridEX1.ClearItems();
        }

        private void gridEX1_FormattingRow(object sender, RowLoadEventArgs e)
        {

        }


        
    }
}