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
    public partial class CustomGroupRowsSample : UserControl
    {
        public CustomGroupRowsSample()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.customersTableAdapter1.Fill(this.jsNorthWindDataSet1.Customers);
            this.SetGridSettings();
        }
        private void SetGridSettings()
        {
            this.gridEX1.VisualStyle = VisualStyle.Office2003;
            this.gridEX1.AllowAddNew = InheritableBoolean.True;
            this.gridEX1.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GridEXCustomGroup customGroup = new GridEXCustomGroup();

            GridEXCustomGroupRow groupRow;
            groupRow = new GridEXCustomGroupRow("US Customers",this.gridEX1.RootTable.Columns["Country"],"USA");
            groupRow.ShowWhenEmpty = true;
            customGroup.GroupRows.Add(groupRow);

            groupRow = new GridEXCustomGroupRow("Foreign Customers");
            groupRow.Condition = new GridEXFilterCondition(gridEX1.RootTable.Columns["Country"], ConditionOperator.NotEqual, "USA");
            groupRow.ShowWhenEmpty = true;
            customGroup.GroupRows.Add(groupRow);

            this.gridEX1.RootTable.Groups.Clear();
            GridEXGroup group = new GridEXGroup(customGroup);
            group.HeaderCaption = "US and foreign customers";
            this.gridEX1.RootTable.Groups.Add(group);
            this.gridEX1.GetRow(0).Expanded = true;

        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            GridEXCustomGroup customGroup = new GridEXCustomGroup();
            GridEXCustomGroupRow groupRow;
            groupRow = new GridEXCustomGroupRow("Owner", this.gridEX1.RootTable.Columns["ContactTitle"], "Owner");
            groupRow.ShowWhenEmpty = true;
            customGroup.GroupRows.Add(groupRow);

            groupRow = new GridEXCustomGroupRow("Other");
            groupRow.Condition = new GridEXFilterCondition(gridEX1.RootTable.Columns["ContactTitle"], ConditionOperator.NotEqual, "Owner");
            groupRow.ShowWhenEmpty = true;
            customGroup.GroupRows.Add(groupRow);

            this.gridEX1.RootTable.Groups.Clear();
            GridEXGroup group = new GridEXGroup(customGroup);
            group.GroupPrefix = "Contact Title:";
            group.HeaderCaption = "Contact Title";
            this.gridEX1.RootTable.Groups.Add(group);
            this.gridEX1.GetRow(0).Expanded = true;

        }
    }
}
