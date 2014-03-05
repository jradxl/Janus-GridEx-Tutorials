namespace GridEXTutorial22CSharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.gridEXTutorialsDataDataSet1 = new GridEXTutorial22CSharp.GridEXTutorialsDataDataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNewMessage = new System.Windows.Forms.Button();
            this.messagesTableAdapter1 = new GridEXTutorial22CSharp.GridEXTutorialsDataDataSetTableAdapters.MessagesTableAdapter();
            this.brnReplyMessage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTutorialsDataDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX1.ColumnAutoResize = true;
            this.gridEX1.DataMember = "Messages";
            this.gridEX1.DataSource = this.gridEXTutorialsDataDataSet1;
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEXLayout1;
            this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEX1.GridLines = Janus.Windows.GridEX.GridLines.None;
            this.gridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.gridEX1.ImageList = this.imageList1;
            this.gridEX1.Location = new System.Drawing.Point(12, 34);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(536, 337);
            this.gridEX1.TabIndex = 0;
            // 
            // gridEXTutorialsDataDataSet1
            // 
            this.gridEXTutorialsDataDataSet1.DataSetName = "GridEXTutorialsDataDataSet";
            this.gridEXTutorialsDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "OrdersDetails16.ico");
            // 
            // btnNewMessage
            // 
            this.btnNewMessage.Location = new System.Drawing.Point(12, 3);
            this.btnNewMessage.Name = "btnNewMessage";
            this.btnNewMessage.Size = new System.Drawing.Size(98, 25);
            this.btnNewMessage.TabIndex = 1;
            this.btnNewMessage.Text = "New Message...";
            this.btnNewMessage.UseVisualStyleBackColor = true;
            this.btnNewMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
            // 
            // messagesTableAdapter1
            // 
            this.messagesTableAdapter1.ClearBeforeFill = true;
            // 
            // brnReplyMessage
            // 
            this.brnReplyMessage.Location = new System.Drawing.Point(116, 3);
            this.brnReplyMessage.Name = "brnReplyMessage";
            this.brnReplyMessage.Size = new System.Drawing.Size(98, 25);
            this.brnReplyMessage.TabIndex = 2;
            this.brnReplyMessage.Text = "Reply Message...";
            this.brnReplyMessage.UseVisualStyleBackColor = true;
            this.brnReplyMessage.Click += new System.EventHandler(this.btnReplyMessage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(220, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Message";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 380);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.brnReplyMessage);
            this.Controls.Add(this.btnNewMessage);
            this.Controls.Add(this.gridEX1);
            this.Name = "Form1";
            this.Text = "Tutorial 22 - Using GridEX SelfReferencing HierarchicalMode";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTutorialsDataDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private System.Windows.Forms.Button btnNewMessage;
        private GridEXTutorialsDataDataSet gridEXTutorialsDataDataSet1;
        private GridEXTutorial22CSharp.GridEXTutorialsDataDataSetTableAdapters.MessagesTableAdapter messagesTableAdapter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button brnReplyMessage;
        private System.Windows.Forms.Button btnDelete;
    }
}

