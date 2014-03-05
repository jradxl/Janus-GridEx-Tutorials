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
    public partial class SelfReferencingGridSample : UserControl
    {
        private DataTable data;
        public SelfReferencingGridSample()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.CreateDummySource();
            this.SetGridSettings();
        }
        private void CreateDummySource()
        {
            data = new DataTable("DummyData");
            data.Columns.Add("MessageID", typeof(int));

            data.Columns.Add("Subject", typeof(string));
            data.Columns.Add("From", typeof(string));
            data.Columns.Add("Date", typeof(DateTime));
            data.Columns.Add("ParentMessageID", typeof(int));

            int parentId;
            //Creating sample rows
            parentId = this.AddMessage("Hello World", "John", new DateTime(2005, 12, 8), DBNull.Value);
            //child rows of Message 1
            this.AddMessage("Re: Hello World", "Paul", new DateTime(2005, 12, 9), parentId);
            this.AddMessage("Re: Hello World", "Mary", new DateTime(2005, 12, 9), parentId);
            parentId = this.AddMessage("New Message", "Paul", new DateTime(2005, 12, 9), DBNull.Value);
            parentId = this.AddMessage("Re: New Message", "John", new DateTime(2005, 12, 9), parentId);
            this.AddMessage("Re Re: New Message", "John", new DateTime(2005, 12, 10), parentId);

        }
        int lastId = 0;
        private int AddMessage(string subject, string from, DateTime date, object parentId)
        {
            lastId++;
            data.Rows.Add(lastId, subject, from, date, parentId);
            return lastId;
        }
        private void SetGridSettings()
        {
            this.gridEX1.DataSource = data;
            this.gridEX1.RetrieveStructure();
            this.gridEX1.VisualStyle = VisualStyle.Office2003;

            this.gridEX1.GridLines = GridLines.None;
            this.gridEX1.HideSelection = HideSelection.Highlight;
            //SelfRerencing setting

            //Indicate that the root table must be treated as a self referencing table
            this.gridEX1.RootTable.HierarchicalMode = HierarchicalMode.SelfReferencing;

            //Specify the Parent and child fields
            this.gridEX1.RootTable.SelfReferencingSettings.ParentDataMember = "MessageID";
            this.gridEX1.RootTable.SelfReferencingSettings.ChildDataMember = "ParentMessageID";

            //specify where the expand button appears
            this.gridEX1.RootTable.SelfReferencingSettings.ExpandColumn = this.gridEX1.RootTable.Columns["Subject"];

            //hiding some columns:
            this.gridEX1.RootTable.Columns["MessageID"].Visible = false;
            this.gridEX1.RootTable.Columns["ParentMessageID"].Visible = false;


            this.gridEX1.RootTable.Columns["Subject"].ColumnType = ColumnType.ImageAndText;
            this.gridEX1.RootTable.Columns["Subject"].ImageIndex = 0;
            this.gridEX1.RootTable.Columns["Subject"].Width = 300;
            this.gridEX1.RootTable.Columns["From"].Width = 100;
            this.gridEX1.RootTable.Columns["Date"].Width = 100;

            //Setting selectable false in all column to select the complete row when a cell is clicked
            foreach (GridEXColumn col in this.gridEX1.RootTable.Columns)
            {
                col.Selectable = false;
            }
            this.gridEX1.ColumnAutoResize = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMessageDialog dialog = new NewMessageDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int messageId = this.AddMessage(dialog.Subject, dialog.User, DateTime.Today, DBNull.Value);
                //Find messageid in the control to select the new item
                gridEX1.Find(gridEX1.RootTable.Columns["MessageID"], ConditionOperator.Equal, messageId, -1, 1);

            }
            dialog.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridEXRow currentRow = this.gridEX1.GetRow();
            if (currentRow == null || currentRow.RowType != RowType.Record)
            {
                MessageBox.Show("Select a row first.");
            }
            else
            {
                NewMessageDialog dialog = new NewMessageDialog();
                dialog.Subject = "Re: " + currentRow.Cells["Subject"].Text;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int messageId = this.AddMessage(dialog.Subject, dialog.User, DateTime.Today, currentRow.Cells["MessageID"].Value);
                    //Find messageid in the control to select the new item
                    gridEX1.Find(gridEX1.RootTable.Columns["MessageID"], ConditionOperator.Equal, messageId, -1, 1);
                }
                dialog.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.gridEX1.RootTable.Groups.Clear();
            this.gridEX1.RootTable.SelfReferencingSettings.HierarchicalGroupMode = HierarchicalGroupMode.ParentRows;
            this.gridEX1.RootTable.Groups.Add("Date");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.gridEX1.RootTable.Groups.Clear();
            this.gridEX1.RootTable.SelfReferencingSettings.HierarchicalGroupMode = HierarchicalGroupMode.AllRows;
            this.gridEX1.RootTable.Groups.Add("Date");
        }
    }
}
