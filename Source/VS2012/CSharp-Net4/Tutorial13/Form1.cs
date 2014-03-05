using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GridEXTutorial13CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GridEX1_CurrentLayoutChanged(object sender, EventArgs e)
        {
            //clear the DataTable used by the previous layout
            jsNorthWindDataSet1.Clear();
            if (GridEX1.CurrentLayout != null)
            {
                switch (GridEX1.CurrentLayout.Key)
                {
                    case "Customers":
                        customersTableAdapter1.Fill(jsNorthWindDataSet1.Customers);
                        break;
                    case "Products":
                        productsTableAdapter1.Fill(jsNorthWindDataSet1.Products);
                        break;
                    case "Suppliers":
                        suppliersTableAdapter1.Fill(jsNorthWindDataSet1.Suppliers);
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GridEX1.CurrentLayout == null || GridEX1.CurrentLayout.Key != "Customers")
            {
                GridEX1.CurrentLayout = GridEX1.Layouts["Customers"];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GridEX1.CurrentLayout == null || GridEX1.CurrentLayout.Key != "Products")
            {
                GridEX1.CurrentLayout = GridEX1.Layouts["Products"];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GridEX1.CurrentLayout == null || GridEX1.CurrentLayout.Key != "Suppliers")
            {
                GridEX1.CurrentLayout = GridEX1.Layouts["Suppliers"];
            }
        }
    }
}