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
    public partial class HierarchicalGroupingSample : UserControl
    {
        public HierarchicalGroupingSample()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.customersTableAdapter1.Fill(this.jsNorthWindDataSet1.Customers);
            this.ordersTableAdapter1.Fill(this.jsNorthWindDataSet1.Orders);
            this.order_DetailsTableAdapter1.Fill(this.jsNorthWindDataSet1.Order_Details);
            this.productsTableAdapter1.Fill(this.jsNorthWindDataSet1.Products);
            this.SetGridSettings();
            this.label1.Text = "Customers Table is grouped by ProductID that belongs to OrderDetails Table\n\rNotice that Customer rows can be duplicated in this scenario when a customer has more than one product ordered";

            
        }
        private void SetGridSettings()
        {
            //Bind Products DropDown:
            this.gridEX1.DropDowns["Products"].SetDataBinding(this.jsNorthWindDataSet1.Products, "");

            //Adding a GroupHeaderTotal:
            GridEXGroupHeaderTotal groupTotal = new GridEXGroupHeaderTotal();
            groupTotal.AggregateFunction = AggregateFunction.Count;
            groupTotal.TotalFormatMode = FormatMode.UseStringFormat;
            groupTotal.TotalFormatString = "{0} Customers";
            this.gridEX1.RootTable.GroupHeaderTotals.Add(groupTotal);

            this.gridEX1.RowHeaders = InheritableBoolean.True;
            this.gridEX1.GroupMode = GroupMode.Collapsed;

            //Group Customers by Order_Details.Product:
            this.gridEX1.RootTable.Groups.Add(this.gridEX1.Tables["OrderDetails"].Columns["ProductID"]);


        }

        private void gridEX1_LoadingRow(object sender, RowLoadEventArgs e)
        {
            if (e.Row.RowType == RowType.Record)
            {
                if (e.Row.Table.Key == "OrderDetails")
                {
                    //Calculate Total value in order details row
                    e.Row.Cells["Total"].Value = GetDecimalValueSafe(e.Row.Cells["Quantity"]) * GetDecimalValueSafe(e.Row.Cells["UnitPrice"])*
                            (1-GetDecimalValueSafe(e.Row.Cells["Discount"]));
                }
            }
        }
        private decimal GetDecimalValueSafe(GridEXCell cell)
        {
            if (cell.Value == null || cell.Value == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(cell.Value);
            }
        }
    }
}
