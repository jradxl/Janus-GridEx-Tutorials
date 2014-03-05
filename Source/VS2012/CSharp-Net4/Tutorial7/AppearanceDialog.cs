using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace GridEXTutorial7CSharp
{
    public partial class AppearanceDialog : Form
    {
        public AppearanceDialog()
        {
            InitializeComponent();
            this.FillComboWithEnumValues(this.cboBorder, typeof(Janus.Windows.GridEX.BorderStyle));
            this.FillComboWithEnumValues(this.cboHeaderAppearance, typeof(Janus.Windows.GridEX.Appearance));
            this.FillComboWithEnumValues(this.cboButtomAppearance, typeof(ButtonAppearance));
            this.FillComboWithEnumValues(this.cboGridlines, typeof(GridLines));
            this.FillComboWithEnumValues(this.cboGridlineStyle, typeof(GridLineStyle));
        }

        private void EnableCombos()
        {
            cboBorder.Enabled = !(chkVisualStyles.Checked || chkOffice2003.Checked);
            cboHeaderAppearance.Enabled = !(chkVisualStyles.Checked | chkOffice2003.Checked);
            cboButtomAppearance.Enabled = !chkVisualStyles.Checked;
        }
        private Janus.Windows.GridEX.GridEX grid;
        public Janus.Windows.GridEX.GridEX Grid
        {
            get
            {
                return grid;
            }
            set
            {
                this.grid = value;
                this.ReadGridProperties();
            }
        }
        private void ReadGridProperties()
        {
            if (grid != null)
            {
                if (this.grid.ThemedAreas == ThemedArea.None)
                {
                    this.chkVisualStyles.Checked = false;
                }
                else
                {
                    this.chkVisualStyles.Checked = true;
                }
                if (this.grid.VisualStyle == VisualStyle.Office2003)
                {
                    this.chkOffice2003.Checked = true;
                }
                else
                {
                    this.chkOffice2003.Checked = false;
                }
                if (this.grid.RowHeaders == InheritableBoolean.True)
                {
                    this.chkRowHeaders.Checked = true;
                }
                else
                {
                    this.chkRowHeaders.Checked = false;
                }
                this.chkGroupByBox.Checked = grid.GroupByBoxVisible;
                this.chkAlternatingRows.Checked = grid.AlternatingColors;
                this.chkRecordNavigator.Checked = grid.RecordNavigator;
                this.cboBorder.SelectedItem = this.grid.BorderStyle;
                this.cboHeaderAppearance.SelectedItem = this.grid.HeaderFormatStyle.Appearance;
                this.cboButtomAppearance.SelectedItem = this.grid.ControlStyle.ButtonAppearance;
                this.cboGridlines.SelectedItem = this.grid.GridLines;
                this.cboGridlineStyle.SelectedItem = this.grid.GridLineStyle;
            }
        }
        private void FillComboWithEnumValues(ComboBox combo, Type enumType)
        {
            System.Array values = Enum.GetValues(enumType);
            object[] styles = new object[values.Length];
            values.CopyTo(styles, 0);
            combo.Items.AddRange(styles);
        }
        private void chkVisualStyles_CheckedChanged(object sender, System.EventArgs e)
        {
            //You can use themes only in some areas of the control
            //but in this sample we use just all or none
            if (chkVisualStyles.Checked)
            {
                this.grid.ThemedAreas = ThemedArea.All;
            }
            else
            {
                this.grid.ThemedAreas = ThemedArea.None;
            }
            EnableCombos();
        }

        private void cboBorder_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.grid.BorderStyle = (Janus.Windows.GridEX.BorderStyle)this.cboBorder.SelectedItem;
        }

        private void cboHeaderAppearance_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.grid.HeaderFormatStyle.Appearance = (Janus.Windows.GridEX.Appearance)this.cboHeaderAppearance.SelectedItem;
            //changing header appearance in the dropdown too
            this.grid.DropDowns["Suppliers"].HeaderFormatStyle.Appearance = this.grid.HeaderFormatStyle.Appearance;

        }

        private void cboButtomAppearance_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.grid.ControlStyle.ButtonAppearance = (ButtonAppearance)this.cboButtomAppearance.SelectedItem;
        }

        private void cboGridlines_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.grid.GridLines = (GridLines)this.cboGridlines.SelectedItem;
        }

        private void cboGridlineStyle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.grid.GridLineStyle = (GridLineStyle)this.cboGridlineStyle.SelectedItem;
        }

        private void chkRowHeaders_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkRowHeaders.Checked)
            {
                this.grid.RowHeaders = InheritableBoolean.True;
            }
            else
            {
                this.grid.RowHeaders = InheritableBoolean.False;
            }
        }

        private void chkGroupByBox_CheckedChanged(object sender, System.EventArgs e)
        {
            this.grid.GroupByBoxVisible = chkGroupByBox.Checked;
        }

        private void chkAlternatingRows_CheckedChanged(object sender, System.EventArgs e)
        {
            this.grid.AlternatingColors = this.chkAlternatingRows.Checked;
        }

        private void chkRecordNavigator_CheckedChanged(object sender, System.EventArgs e)
        {
            this.grid.RecordNavigator = this.chkRecordNavigator.Checked;
        }

        private void chkOffice2003_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkOffice2003.Checked)
            {
                this.grid.VisualStyle = VisualStyle.Office2003;
            }
            else
            {
                this.grid.VisualStyle = VisualStyle.Standard;
            }
            EnableCombos();
        }
    }
}