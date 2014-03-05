namespace GridEXTutorial17CSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GridEX1 = new Janus.Windows.GridEX.GridEX();
            this.jSNorthWindDataSet = new GridEXTutorial17CSharp.JSNorthWindDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new GridEXTutorial17CSharp.JSNorthWindDataSetTableAdapters.ProductsTableAdapter();
            this.categoriesTableAdapter1 = new GridEXTutorial17CSharp.JSNorthWindDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSNorthWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Cat(1)");
            this.imageList1.Images.SetKeyName(1, "Cat(2)");
            this.imageList1.Images.SetKeyName(2, "Cat(3)");
            this.imageList1.Images.SetKeyName(3, "Cat(4)");
            this.imageList1.Images.SetKeyName(4, "Cat(5)");
            this.imageList1.Images.SetKeyName(5, "Cat(6)");
            this.imageList1.Images.SetKeyName(6, "Cat(7)");
            this.imageList1.Images.SetKeyName(7, "Cat(8)");
            this.imageList1.Images.SetKeyName(8, "header");
            this.imageList1.Images.SetKeyName(9, "product");
            this.imageList1.Images.SetKeyName(10, "onsale");
            this.imageList1.Images.SetKeyName(11, "discontinued");
            // 
            // GridEX1
            // 
            this.GridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.GridEX1.DataSource = this.productsBindingSource;
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.GridEX1.DesignTimeLayout = gridEXLayout1;
            this.GridEX1.ImageList = this.imageList1;
            this.GridEX1.KeepRowSettings = false;
            this.GridEX1.Location = new System.Drawing.Point(7, 16);
            this.GridEX1.Name = "GridEX1";
            this.GridEX1.ScrollBarWidth = 17;
            this.GridEX1.Size = new System.Drawing.Size(584, 385);
            this.GridEX1.TabIndex = 1;
            this.GridEX1.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.GridEX1_FormattingRow);
            // 
            // jSNorthWindDataSet
            // 
            this.jSNorthWindDataSet.DataSetName = "JSNorthWindDataSet";
            this.jSNorthWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.jSNorthWindDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 416);
            this.Controls.Add(this.GridEX1);
            this.Name = "Form1";
            this.Text = "Tutorial 17 - Using Image Columns";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSNorthWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imageList1;
        internal Janus.Windows.GridEX.GridEX GridEX1;
        private JSNorthWindDataSet jSNorthWindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private GridEXTutorial17CSharp.JSNorthWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private GridEXTutorial17CSharp.JSNorthWindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
    }
}

