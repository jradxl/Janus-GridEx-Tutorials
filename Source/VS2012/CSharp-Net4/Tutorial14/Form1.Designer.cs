namespace GridEXTutorial14CSharp
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
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout gridEXLayout3 = new Janus.Windows.GridEX.GridEXLayout();
            this.jsNorthWindDataSet1 = new GridEXTutorial14CSharp.JSNorthWindDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GridEX1 = new Janus.Windows.GridEX.GridEX();
            this.customersTableAdapter1 = new GridEXTutorial14CSharp.JSNorthWindDataSetTableAdapters.CustomersTableAdapter();
            this.productsTableAdapter1 = new GridEXTutorial14CSharp.JSNorthWindDataSetTableAdapters.ProductsTableAdapter();
            this.suppliersTableAdapter1 = new GridEXTutorial14CSharp.JSNorthWindDataSetTableAdapters.SuppliersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // jsNorthWindDataSet1
            // 
            this.jsNorthWindDataSet1.DataSetName = "JSNorthWindDataSet";
            this.jsNorthWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Show Suppliers";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Show Products";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show Customers";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridEX1
            // 
            this.GridEX1.AllowChildTableGroups = true;
            this.GridEX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.GridEX1.CardInnerSpacing = 0;
            this.GridEX1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridEX1.DataMember = "Customers";
            this.GridEX1.DataSource = this.jsNorthWindDataSet1;
            this.GridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GridEX1.KeepRowSettings = false;
            gridEXLayout1.DataMember = "Customers";
            gridEXLayout1.DataSource = this.jsNorthWindDataSet1;
            gridEXLayout1.IsCurrentLayout = true;
            gridEXLayout1.Key = "Customers";
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            gridEXLayout2.DataMember = "Products";
            gridEXLayout2.DataSource = this.jsNorthWindDataSet1;
            gridEXLayout2.Key = "Products";
            gridEXLayout2.LayoutString = resources.GetString("gridEXLayout2.LayoutString");
            gridEXLayout3.DataMember = "Suppliers";
            gridEXLayout3.DataSource = this.jsNorthWindDataSet1;
            gridEXLayout3.Key = "Suppliers";
            gridEXLayout3.LayoutString = resources.GetString("gridEXLayout3.LayoutString");
            this.GridEX1.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            gridEXLayout1,
            gridEXLayout2,
            gridEXLayout3});
            this.GridEX1.Location = new System.Drawing.Point(3, 40);
            this.GridEX1.Name = "GridEX1";
            this.GridEX1.ScrollBarWidth = 17;
            this.GridEX1.Size = new System.Drawing.Size(656, 383);
            this.GridEX1.TabIndex = 11;
            this.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.GridEX1.CurrentLayoutChanged += new System.EventHandler(this.GridEX1_CurrentLayoutChanged);
            this.GridEX1.CurrentLayoutChanging += new System.ComponentModel.CancelEventHandler(this.GridEX1_CurrentLayoutChanging);
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter1
            // 
            this.suppliersTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 426);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridEX1);
            this.Name = "Form1";
            this.Text = "Tutorial 14 - Using a Layout File to Preserve GridEX Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        internal Janus.Windows.GridEX.GridEX GridEX1;
        private JSNorthWindDataSet jsNorthWindDataSet1;
        private GridEXTutorial14CSharp.JSNorthWindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private GridEXTutorial14CSharp.JSNorthWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private GridEXTutorial14CSharp.JSNorthWindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter1;

    }
}

