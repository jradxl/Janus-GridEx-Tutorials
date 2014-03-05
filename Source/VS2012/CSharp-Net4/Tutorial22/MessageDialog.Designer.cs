namespace GridEXTutorial22CSharp
{
    partial class MessageDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editSubject = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editMessage = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editFrom = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editSubject
            // 
            this.editSubject.Location = new System.Drawing.Point(67, 12);
            this.editSubject.Name = "editSubject";
            this.editSubject.Size = new System.Drawing.Size(342, 20);
            this.editSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // editMessage
            // 
            this.editMessage.Location = new System.Drawing.Point(15, 64);
            this.editMessage.Multiline = true;
            this.editMessage.Name = "editMessage";
            this.editMessage.Size = new System.Drawing.Size(394, 198);
            this.editMessage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From:";
            // 
            // editFrom
            // 
            this.editFrom.Location = new System.Drawing.Point(67, 38);
            this.editFrom.Name = "editFrom";
            this.editFrom.Size = new System.Drawing.Size(342, 20);
            this.editFrom.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(243, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 26);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(329, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 26);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 303);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editFrom);
            this.Controls.Add(this.editMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editSubject);
            this.Name = "MessageDialog";
            this.Text = "New Message";
            this.Load += new System.EventHandler(this.NewMessageDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.GridEX.EditControls.EditBox editSubject;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.EditBox editMessage;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.GridEX.EditControls.EditBox editFrom;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}