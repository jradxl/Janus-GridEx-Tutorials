using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
namespace GridEXTutorial18CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jSNorthWindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.jSNorthWindDataSet.Order_Details);

        }

        private void GridEX1_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (e.Row.RowType == RowType.Record)
            {
                decimal result = 0;

                //You can get the values directly from the GridEXRow object
                short quantity = (short)e.Row.Cells["Quantity"].Value;
                decimal unitPrice = (decimal)e.Row.Cells["UnitPrice"].Value;
                float discount = (float)e.Row.Cells["Discount"].Value;
                result = Convert.ToDecimal(quantity) * unitPrice * Convert.ToDecimal(1 - discount);

                /*
                //or you can get the values from the Order_DetailsRow this GridEXRow represents.
                System.Data.DataRowView rowView = (System.Data.DataRowView)e.Row.DataRow;
                NorthWind.Order_DetailsRow detail = (NorthWind.Order_DetailsRow)rowView.Row;
				
                result = Convert.ToDecimal(detail.Quantity) * detail.UnitPrice * Convert.ToDecimal(((float)1-detail.Discount));
                */
                e.Row.Cells["Total"].Value = result;
            }
        }
    }
}