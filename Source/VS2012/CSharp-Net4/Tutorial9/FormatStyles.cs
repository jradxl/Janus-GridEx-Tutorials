using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GridEXTutorial9CSharp
{
    public partial class FormatStyles : Form
    {
        public FormatStyles()
        {
            InitializeComponent();
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
            this.optAlternatingRow.Tag = this.grid.AlternatingRowFormatStyle;
            this.optCardCaption.Tag = this.grid.CardCaptionFormatStyle;
            this.optCardHeader.Tag = this.grid.CardColumnHeaderFormatStyle;
            this.optGroupByBox.Tag = this.grid.GroupByBoxFormatStyle;
            this.optGroupByBoxInfo.Tag = this.grid.GroupByBoxInfoFormatStyle;
            this.optGroupRow.Tag = this.grid.GroupRowFormatStyle;
            this.optHeader.Tag = this.grid.HeaderFormatStyle;
            this.optRow.Tag = this.grid.RowFormatStyle;
            this.optSelectedRow.Tag = this.grid.SelectedFormatStyle;
            this.optControlStyle.Tag = this.grid.ControlStyle;

            this.optRow.Checked = true;
        }

        private void option_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                this.propertyGrid1.SelectedObject = button.Tag;
            }
        }
    }
}