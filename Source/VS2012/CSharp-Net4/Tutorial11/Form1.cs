using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GridEXTutorial11CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(jsNorthWindDataSet1.Customers);
            ordersTableAdapter1.Fill(jsNorthWindDataSet1.Orders);
            order_DetailsTableAdapter1.Fill(jsNorthWindDataSet1.Order_Details);
        }
    }
}