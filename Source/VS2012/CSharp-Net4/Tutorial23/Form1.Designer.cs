namespace GridEXTutorial23CSharp
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
            Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.gridEXTutorialsDataDataSet1 = new GridEXTutorial23CSharp.GridEXTutorialsDataDataSet();
            this.contactCategoriesTableAdapter1 = new GridEXTutorial23CSharp.GridEXTutorialsDataDataSetTableAdapters.ContactCategoriesTableAdapter();
            this.contacts_ContactCategoriesTableAdapter1 = new GridEXTutorial23CSharp.GridEXTutorialsDataDataSetTableAdapters.Contacts_ContactCategoriesTableAdapter();
            this.contactsTableAdapter1 = new GridEXTutorial23CSharp.GridEXTutorialsDataDataSetTableAdapters.ContactsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTutorialsDataDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.DataMember = "Contacts";
            this.gridEX1.DataSource = this.gridEXTutorialsDataDataSet1;
            gridEXLayout2.LayoutString = resources.GetString("gridEXLayout2.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEXLayout2;
            this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEX1.Location = new System.Drawing.Point(12, 48);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(778, 376);
            this.gridEX1.TabIndex = 0;
            // 
            // gridEXTutorialsDataDataSet1
            // 
            this.gridEXTutorialsDataDataSet1.DataSetName = "GridEXTutorialsDataDataSet";
            this.gridEXTutorialsDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactCategoriesTableAdapter1
            // 
            this.contactCategoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // contacts_ContactCategoriesTableAdapter1
            // 
            this.contacts_ContactCategoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // contactsTableAdapter1
            // 
            this.contactsTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridEX1);
            this.Name = "Form1";
            this.Text = "Tutorial 23 - Using MultipleValues columns";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTutorialsDataDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private GridEXTutorialsDataDataSet gridEXTutorialsDataDataSet1;
        private GridEXTutorial23CSharp.GridEXTutorialsDataDataSetTableAdapters.ContactCategoriesTableAdapter contactCategoriesTableAdapter1;
        private GridEXTutorial23CSharp.GridEXTutorialsDataDataSetTableAdapters.Contacts_ContactCategoriesTableAdapter contacts_ContactCategoriesTableAdapter1;
        private GridEXTutorial23CSharp.GridEXTutorialsDataDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}

