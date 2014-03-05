using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewFeatures
{
    public partial class NewMessageDialog : Form
    {
        public NewMessageDialog()
        {
            InitializeComponent();
        }

        public string Subject
        {
            get
            {
                return this.txtSubject.Text;
            }
            set
            {
                this.txtSubject.Text = value;
            }
        }

        public string User
        {
            get
            {
                return this.txtUser.Text;
            }
        }


    }
}