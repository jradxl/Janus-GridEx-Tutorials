namespace NewFeatures
{
    partial class HierarchicalGroupingSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HierarchicalGroupingSample));
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.jsNorthWindDataSet1 = new NewFeatures.JSNorthWindDataSet();
            this.customersTableAdapter1 = new NewFeatures.JSNorthWindDataSetTableAdapters.CustomersTableAdapter();
            this.order_DetailsTableAdapter1 = new NewFeatures.JSNorthWindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.ordersTableAdapter1 = new NewFeatures.JSNorthWindDataSetTableAdapters.OrdersTableAdapter();
            this.productsTableAdapter1 = new NewFeatures.JSNorthWindDataSetTableAdapters.ProductsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.gridEX1.Hierarchical = true;
            this.gridEX1.KeepRowSettings = false;
            this.gridEX1.Location = new System.Drawing.Point(0, 48);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(638, 348);
            this.gridEX1.TabIndex = 0;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.gridEX1.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.gridEX1_LoadingRow);
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
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "See how Customers Table is grouped by ProductID that belongs to OrderDetails Tabl" +
                "e";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HierarchicalGroupingSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HierarchicalGroupingSample";
            this.Size = new System.Drawing.Size(638, 396);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private JSNorthWindDataSet jsNorthWindDataSet1;
        private NewFeatures.JSNorthWindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NewFeatures.JSNorthWindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
        private NewFeatures.JSNorthWindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private NewFeatures.JSNorthWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.Label label1;
    }
}
