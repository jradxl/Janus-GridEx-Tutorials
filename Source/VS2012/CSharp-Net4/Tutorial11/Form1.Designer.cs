namespace GridEXTutorial11CSharp
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
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.jsNorthWindDataSet1 = new GridEXTutorial11CSharp.JSNorthWindDataSet();
            this.customersTableAdapter1 = new GridEXTutorial11CSharp.JSNorthWindDataSetTableAdapters.CustomersTableAdapter();
            this.order_DetailsTableAdapter1 = new GridEXTutorial11CSharp.JSNorthWindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.ordersTableAdapter1 = new GridEXTutorial11CSharp.JSNorthWindDataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.gridEX1.DataMember = "Customers";
            this.gridEX1.DataSource = this.jsNorthWindDataSet1;
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEXLayout1;
            this.gridEX1.Hierarchical = true;
            this.gridEX1.KeepRowSettings = false;
            this.gridEX1.Location = new System.Drawing.Point(12, 12);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(541, 367);
            this.gridEX1.TabIndex = 0;
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
            // order_DetailsTableAdapter1
            // 
            this.order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 390);
            this.Controls.Add(this.gridEX1);
            this.Name = "Form1";
            this.Text = "Tutorial 11 - Displaying Hierarchical Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private JSNorthWindDataSet jsNorthWindDataSet1;
        private GridEXTutorial11CSharp.JSNorthWindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private GridEXTutorial11CSharp.JSNorthWindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
        private GridEXTutorial11CSharp.JSNorthWindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
    }
}

