using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace GridEXTutorial20CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGridEXControl();
        }
        private void BindGridEXControl()
        {
            DataSet ds = new DataSet();
            DataTable table = new DataTable("Messages");

            table.Columns.Add(new DataColumn("From", typeof(string)));
            table.Columns.Add(new DataColumn("Subject", typeof(string)));
            table.Columns.Add(new DataColumn("Date", typeof(DateTime)));

            ds.Tables.Add(table);

            table.Rows.Add("john@mail.com", "Greetings", new DateTime(2002, 2, 5));
            table.Rows.Add("jenny@mail.com", "Invitation", new DateTime(2002, 2, 7));
            table.Rows.Add("chris@mail.com", "A question", new DateTime(2002, 2, 10));
            table.Rows.Add("ana@mail.com", "How are you?", new DateTime(2002, 2, 12));
            table.Rows.Add("katherine@mail.com", "Greetings", new DateTime(2002, 2, 14));
            table.Rows.Add("bill@mail.com", "Hi", new DateTime(2002, 2, 18));
            table.Rows.Add("ronald@mail.com", "No Subject", new DateTime(2002, 2, 20));
            GridEX1.SetDataBinding(ds, "Messages");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GridEXRow[] checkedRows;

            //get an array with all the rows that the user checked.
            checkedRows = GridEX1.GetCheckedRows();
            //if the user didn't check any row, you will get an empty array
            if (checkedRows.Length == 0)
            {
                MessageBox.Show("Select at least 1 message to be deleted.");
            }
            else
            {
                string message;
                message = String.Format("You are about to delete {0} message(s)." +
                            "\n\rDo you want to continue?", checkedRows.Length);
                if (MessageBox.Show(message, "Janus Tutorial", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (GridEXRow row in checkedRows)
                    {
                        ((DataRowView)row.DataRow).Delete();
                    }
                }

            }
        }
    }
}