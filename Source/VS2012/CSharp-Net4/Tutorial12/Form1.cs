using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GridEXTutorial12CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fillGridButton_Click(object sender, EventArgs e)
        {
            //binding control at runtime
            //First, get the table you want to bind to the control and populate it
            //in this sample we create a table in memory but 
            //you can also create a table 
            //using OleDBConnection and OleDBDataAdapter object
            DataTable myTable = new DataTable("GridEXTest");

            //creating the columns in the table
            myTable.Columns.Add("Number", typeof(int));
            myTable.Columns.Add("Text", typeof(string));
            myTable.Columns.Add("Date", typeof(DateTime));

            //adding rows
            myTable.Rows.Add(1, "Text 1", DateTime.Today);
            myTable.Rows.Add(2, "Text 2", DateTime.Today);
            myTable.Rows.Add(3, "Text 3", DateTime.Today);

            //call SetDataBinding method to bind the control at run time 
            //and be able to set DataSource and DataMember properties 
            //at the same time
            gridEX1.SetDataBinding(myTable, "");

            //Once the control is bound, call Retrieve Structure method 
            //to force the control to create the table(s) and column(s) 
            //defined in the DataSource
            gridEX1.RetrieveStructure();

        }


    }
}