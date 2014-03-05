using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace GridEXTutorial17CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jSNorthWindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.jSNorthWindDataSet.Products);
            this.categoriesTableAdapter1.Fill(this.jSNorthWindDataSet.Categories);

            GridEXColumn categories;
            categories = GridEX1.RootTable.Columns["CategoryID"];
            categories.HasValueList = true;
            categories.ColumnType = ColumnType.ImageAndText;
            categories.EditType = EditType.DropDownList;
            GridEXValueListItemCollection valueList;
            valueList = categories.ValueList;
            foreach (JSNorthWindDataSet.CategoriesRow row in jSNorthWindDataSet.Categories.Rows)
            {
                GridEXValueListItem item;
                item = new GridEXValueListItem(row.CategoryID,
                                            row.CategoryName);
                //set image Key for items 
                item.ImageKey = "Cat(" + row.CategoryID + ")";
                valueList.Add(item);
            }
        }

        private void GridEX1_FormattingRow(object sender, RowLoadEventArgs e)
        {
            if (e.Row.RowType == RowType.Record)
            {
                if ((bool)e.Row.Cells["Discontinued"].Value)
                {
                    e.Row.Cells["StatusIcon"].ImageKey = "discontinued";
                }
                else if ((bool)e.Row.Cells["OnSale"].Value)
                {
                    e.Row.Cells["StatusIcon"].ImageKey = "onsale";
                }
            }
        }
    }
}