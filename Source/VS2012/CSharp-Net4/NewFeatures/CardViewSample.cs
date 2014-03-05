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
    public partial class CardViewSample : UserControl
    {
        public CardViewSample()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.customersTableAdapter1.Fill(this.jsNorthWindDataSet1.Customers);
            SetGridSettings();
        }
        private void SetGridSettings()
        {
            this.gridEX1.View = Janus.Windows.GridEX.View.CardView;
            this.gridEX1.GridLineStyle = GridLineStyle.Solid;
            this.gridEX1.CardInnerSpacing = 4;
            this.gridEX1.CardViewGridlines = CardViewGridlines.FieldsOnly;
            this.gridEX1.RootTable.Columns["Icon"].CardIcon = true;
            this.gridEX1.RootTable.Columns["Icon"].Visible = false;
            this.gridEX1.RootTable.Columns["Icon"].ImageIndex = 0;
            this.gridEX1.RootTable.Columns["CompanyName"].CardCaption = true;

            //Set the BackColor of card (RowFormatStyle) equal to the backcolor or a header
            //And set the backcolor of each cell equal to SystemColors.Window

            this.gridEX1.RowFormatStyle.BackColor = this.gridEX1.HeaderFormatStyle.BackColor;
            foreach (GridEXColumn col in this.gridEX1.RootTable.Columns)
            {
                col.CellStyle.BackColor = SystemColors.Window;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.gridEX1.CardInnerSpacing == 0)
            {
                this.gridEX1.CardInnerSpacing = 4;
                this.button1.Text = "Remove InnerSpacing";
            }
            else
            {
                this.gridEX1.CardInnerSpacing = 0;
                this.button1.Text = "Use InnerSpacing";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.gridEX1.CardViewGridlines = CardViewGridlines.FieldsOnly;
            }
            else
            {
                this.gridEX1.CardViewGridlines = CardViewGridlines.None;
            }
        }
      
    }
}
