namespace GridEXTutorial6CSharp
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
            this.jsNorthWindDataSet1 = new GridEXTutorial6CSharp.JSNorthWindDataSet();
            this.productsTableAdapter1 = new GridEXTutorial6CSharp.JSNorthWindDataSetTableAdapters.ProductsTableAdapter();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GridEX1 = new Janus.Windows.GridEX.GridEX();
            this.categoriesTableAdapter1 = new GridEXTutorial6CSharp.JSNorthWindDataSetTableAdapters.CategoriesTableAdapter();
            this.suppliersTableAdapter1 = new GridEXTutorial6CSharp.JSNorthWindDataSetTableAdapters.SuppliersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // jsNorthWindDataSet1
            // 
            this.jsNorthWindDataSet1.DataSetName = "JSNorthWindDataSet";
            this.jsNorthWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.ImageList1.Images.SetKeyName(0, "product.bmp");
            this.ImageList1.Images.SetKeyName(1, "header.bmp");
            // 
            // GridEX1
            // 
            this.GridEX1.AllowChildTableGroups = true;
            this.GridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.GridEX1.CardCaptionPrefix = "Product:";
            this.GridEX1.CardColumnHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.GridEX1.CenterSingleCard = false;
            this.GridEX1.DataMember = "Products";
            this.GridEX1.DataSource = this.jsNorthWindDataSet1;
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.GridEX1.DesignTimeLayout = gridEXLayout1;
            this.GridEX1.ImageList = this.ImageList1;
            this.GridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridEX1.KeepRowSettings = false;
            this.GridEX1.Location = new System.Drawing.Point(12, 31);
            this.GridEX1.Name = "GridEX1";
            this.GridEX1.ScrollBarWidth = 17;
            this.GridEX1.Size = new System.Drawing.Size(608, 343);
            this.GridEX1.TabIndex = 1;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter1
            // 
            this.suppliersTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "View:";
            // 
            // ViewCombo
            // 
            this.ViewCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewCombo.Location = new System.Drawing.Point(45, 4);
            this.ViewCombo.Name = "ViewCombo";
            this.ViewCombo.Size = new System.Drawing.Size(132, 21);
            this.ViewCombo.TabIndex = 7;
            this.ViewCombo.SelectedIndexChanged += new System.EventHandler(this.ViewCombo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewCombo);
            this.Controls.Add(this.GridEX1);
            this.Name = "Form1";
            this.Text = "Tutorial 6 - Enhancing Card View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JSNorthWindDataSet jsNorthWindDataSet1;
        private GridEXTutorial6CSharp.JSNorthWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        internal System.Windows.Forms.ImageList ImageList1;
        internal Janus.Windows.GridEX.GridEX GridEX1;
        private GridEXTutorial6CSharp.JSNorthWindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private GridEXTutorial6CSharp.JSNorthWindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox ViewCombo;
    }
}

