namespace NewFeatures
{
    partial class CustomGroupRowsSample
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomGroupRowsSample));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.jsNorthWindDataSet1 = new NewFeatures.JSNorthWindDataSet();
            this.customersTableAdapter1 = new NewFeatures.JSNorthWindDataSetTableAdapters.CustomersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 34);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Group Owner Contacts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Group US Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridEX1
            // 
            this.gridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.gridEX1.CardInnerSpacing = 0;
            this.gridEX1.DataMember = "Customers";
            this.gridEX1.DataSource = this.jsNorthWindDataSet1;
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEXLayout1;
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEX1.KeepRowSettings = false;
            this.gridEX1.Location = new System.Drawing.Point(0, 34);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(455, 300);
            this.gridEX1.TabIndex = 1;
            // 
            // jsNorthWindDataSet1
            // 
            this.jsNorthWindDataSet1.DataSetName = "JSNorthWindDataSet";
            this.jsNorthWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // CustomGroupRowsSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.panel1);
            this.Name = "CustomGroupRowsSample";
            this.Size = new System.Drawing.Size(455, 334);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Janus.Windows.GridEX.GridEX gridEX1;
        private JSNorthWindDataSet jsNorthWindDataSet1;
        private NewFeatures.JSNorthWindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
