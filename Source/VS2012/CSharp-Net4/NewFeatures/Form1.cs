using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace NewFeatures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNavigatorGrid();
        }

        private void LoadNavigatorGrid()
        {
            GridEXColumn column;
            this.grdNavigator.GroupByBoxVisible = false;
            this.grdNavigator.HideSelection = HideSelection.Highlight;
            this.grdNavigator.ColumnHeaders = InheritableBoolean.False;
            this.grdNavigator.VisualStyle = VisualStyle.Office2003;
            this.grdNavigator.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
            this.grdNavigator.ColumnAutoResize = true;
            this.grdNavigator.GridLines = GridLines.None;

            this.grdNavigator.BoundMode = BoundMode.Unbound;
            this.grdNavigator.RootTable = new GridEXTable();
            column = this.grdNavigator.RootTable.Columns.Add("Text");
            column.Selectable = false;
            column = this.grdNavigator.RootTable.Columns.Add("Category");
            column.Visible = false;
            column = this.grdNavigator.RootTable.Columns.Add("LeftPaneType");
            column.Visible = false;

            this.grdNavigator.AddItem("Unbound Mode", "GridEX Control", typeof(UnboundModeSample));
            this.grdNavigator.AddItem("Card View GridLines And InnerSpacing", "GridEX Control", typeof(CardViewSample));
            this.grdNavigator.AddItem("Grouping rows in RootTable by columns in a child table.", "GridEX Control", typeof(HierarchicalGroupingSample));
            this.grdNavigator.AddItem("SelfReferencing GridEX Control", "GridEX Control", typeof(SelfReferencingGridSample));
            this.grdNavigator.AddItem("MultipleValues Column", "GridEX Control", typeof(MultipleValuesSample));
            this.grdNavigator.AddItem("Custom Group Rows", "GridEX Control", typeof(CustomGroupRowsSample));
            this.grdNavigator.RootTable.Groups.Add("Category");
        }
        private UserControl leftPaneControl;
        private UserControl LeftPaneControl
        {
            get
            {
                return this.leftPaneControl;
            }
            set
            {
                if (this.leftPaneControl != value)
                {
                    if (this.leftPaneControl != null)
                    {
                        this.leftPaneControl.Dispose();
                    }
                    this.leftPaneControl = value;
                    if (this.leftPaneControl != null)
                    {
                        this.leftPaneControl.Dock = DockStyle.Fill;
                        this.splitContainer1.Panel2.Controls.Add(this.leftPaneControl);
                    }
                }
            }
        }

        private void grdNavigator_SelectionChanged(object sender, EventArgs e)
        {
            GridEXRow currentRow = this.grdNavigator.GetRow();
            if (currentRow != null && currentRow.RowType == RowType.Record)
            {
                Type controlType = (Type)currentRow.Cells["LeftPaneType"].Value;
                this.LeftPaneControl = (UserControl)Activator.CreateInstance(controlType);
            }
            else
            {
                this.LeftPaneControl = null;
            }
        }
    }
}