using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GridEXTutorial22CSharp
{
    public partial class MessageDialog : Form
    {
        public MessageDialog()
        {
            InitializeComponent();
        }

        private void NewMessageDialog_Load(object sender, EventArgs e)
        {

        }
        public string Subject
        {
            get
            {
                return this.editSubject.Text;
            }
            set
            {
                this.editSubject.Text = value;
            }
        }
        public string From
        {
            get
            {
                return this.editFrom.Text;
            }
            set
            {
                this.editFrom.Text = value;
            }
        }
        public string Message
        {
            get
            {
                return this.editMessage.Text;
            }
            set
            {
                this.editMessage.Text = value;
            }
        }
    }
}