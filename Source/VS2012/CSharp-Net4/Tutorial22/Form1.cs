using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
namespace GridEXTutorial22CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void CreateMessage(object parentId,string subject)
        {
            MessageDialog message = new MessageDialog();
            message.Subject = subject;
            if (message.ShowDialog() == DialogResult.OK)
            {

                //Add a new row to the dataset with parentMessageID set to DBNull
                GridEXTutorialsDataDataSet.MessagesRow newMessage;
                newMessage = this.gridEXTutorialsDataDataSet1.Messages.NewMessagesRow();
                newMessage.Subject = message.Subject;
                if (message.From.Length == 0)
                {
                    newMessage.From = "ANONIMOUS";
                }
                else
                {
                    newMessage.From = message.From;
                }
                newMessage.Message = message.Message;
                newMessage.Date = DateTime.Now;
                if (parentId != null)
                {
                    newMessage.ParentMessageID = (int)parentId;
                }
                //Add the row to the dataset and it will be displayed
                //automatically in the grid.
                gridEXTutorialsDataDataSet1.Messages.Rows.Add(newMessage);
                //Select the new row in grid
                gridEX1.MoveTo(gridEX1.GetRow(newMessage));
                gridEX1.Focus();

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            messagesTableAdapter1.Fill(gridEXTutorialsDataDataSet1.Messages);
        }
        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            this.CreateMessage(null, "New Message");
        }
        private void btnReplyMessage_Click(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null && 
                gridEX1.CurrentRow.RowType == RowType.Record)
            {
                CreateMessage(gridEX1.GetValue("MessageID"), 
                    "RE: " + gridEX1.GetValue("Subject"));
            }
            else
            {
                MessageBox.Show("Select the message to reply." ,
                    "",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridEX1.CurrentRow != null && 
                gridEX1.CurrentRow.RowType == RowType.Record)
            {
                gridEX1.Delete();
            }
            else
            {
                MessageBox.Show("Select the message you want to delete", 
                    "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}