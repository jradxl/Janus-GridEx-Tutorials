using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace GridEXTutorial15CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.gridEX1.RetrieveStructure();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jSNorthWindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.jSNorthWindDataSet.Customers);

        }

        private void gridEX1_InitCustomEdit(object sender, Janus.Windows.GridEX.InitCustomEditEventArgs e)
        {
            //For the sample, we will use BackColor Yellow in the textbox
            //if the cell is in a new row
            if (e.Row.RowType == RowType.NewRecord)
            {
                txtCustom.BackColor = Color.Yellow;
            }
            else
            {
                txtCustom.BackColor = e.FormatStyle.BackColor;
            }

            //When the user start edition by pressing a key, 
            //the EditChar property holds the char that 
            //started the edition. If edition was started 
            //because the user clicked in the cell the 
            //EditChar returns (char)0
            if (Char.IsLetterOrDigit(e.EditChar))
            {
                txtCustom.Text = e.EditChar.ToString();
                txtCustom.SelectionStart = txtCustom.Text.Length;
            }
            else
            {
                if (e.Value == null)
                {
                    txtCustom.Text = "";
                }
                else
                {
                    txtCustom.Text = e.Value.ToString();
                }
                txtCustom.SelectionLength = txtCustom.Text.Length;
            }
            //Set the EditControl property to let the GridEX control
            //know which control to position in the cell.
            e.EditControl = txtCustom;
        }

        private void gridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
        {
            //If e.CancelUpdate is true, the user canceled the edit
            //pressing Esc, do not set the value in this case.
            if (!e.CancelUpdate)
            {
                if (e.Value.ToString() != txtCustom.Text)
                {
                    e.Value = txtCustom.Text;
                }
            }
        }
    }
}