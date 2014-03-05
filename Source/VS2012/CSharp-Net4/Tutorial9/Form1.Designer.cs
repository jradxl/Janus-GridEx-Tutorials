namespace GridEXTutorial9CSharp
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
            Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new Janus.Windows.GridEX.GridEXLayout();
            this.jsNorthWindDataSet1 = new GridEXTutorial9CSharp.JSNorthWindDataSet();
            this.productsTableAdapter1 = new GridEXTutorial9CSharp.JSNorthWindDataSetTableAdapters.ProductsTableAdapter();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GridEX1 = new Janus.Windows.GridEX.GridEX();
            this.categoriesTableAdapter1 = new GridEXTutorial9CSharp.JSNorthWindDataSetTableAdapters.CategoriesTableAdapter();
            this.suppliersTableAdapter1 = new GridEXTutorial9CSharp.JSNorthWindDataSetTableAdapters.SuppliersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewCombo = new System.Windows.Forms.ComboBox();
            this.customizeButton = new System.Windows.Forms.Button();
            this.formatStylesButton = new System.Windows.Forms.Button();
            this.gridEXPrintDocument1 = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewButton = new System.Windows.Forms.Button();
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
            gridEXLayout2.LayoutString = resources.GetString("gridEXLayout2.LayoutString");
            this.GridEX1.DesignTimeLayout = gridEXLayout2;
            this.GridEX1.ImageList = this.ImageList1;
            this.GridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridEX1.KeepRowSettings = false;
            this.GridEX1.Location = new System.Drawing.Point(12, 33);
            this.GridEX1.Name = "GridEX1";
            this.GridEX1.ScrollBarWidth = 17;
            this.GridEX1.Size = new System.Drawing.Size(608, 341);
            this.GridEX1.TabIndex = 1;
            this.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
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
            // customizeButton
            // 
            this.customizeButton.Location = new System.Drawing.Point(183, 3);
            this.customizeButton.Name = "customizeButton";
            this.customizeButton.Size = new System.Drawing.Size(148, 24);
            this.customizeButton.TabIndex = 9;
            this.customizeButton.Text = "Customize Appearance...";
            this.customizeButton.Click += new System.EventHandler(this.customizeButton_Click);
            // 
            // formatStylesButton
            // 
            this.formatStylesButton.Location = new System.Drawing.Point(337, 3);
            this.formatStylesButton.Name = "formatStylesButton";
            this.formatStylesButton.Size = new System.Drawing.Size(98, 24);
            this.formatStylesButton.TabIndex = 10;
            this.formatStylesButton.Text = "FormatStyles...";
            this.formatStylesButton.Click += new System.EventHandler(this.formatStylesButton_Click);
            // 
            // gridEXPrintDocument1
            // 
            this.gridEXPrintDocument1.GridEX = this.GridEX1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.gridEXPrintDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printPreviewButton
            // 
            this.printPreviewButton.Location = new System.Drawing.Point(441, 3);
            this.printPreviewButton.Name = "printPreviewButton";
            this.printPreviewButton.Size = new System.Drawing.Size(98, 24);
            this.printPreviewButton.TabIndex = 11;
            this.printPreviewButton.Text = "Print Preview...";
            this.printPreviewButton.Click += new System.EventHandler(this.printPreviewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 387);
            this.Controls.Add(this.printPreviewButton);
            this.Controls.Add(this.formatStylesButton);
            this.Controls.Add(this.customizeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewCombo);
            this.Controls.Add(this.GridEX1);
            this.Name = "Form1";
            this.Text = "Tutorial 9 - Using GridEXPrintDocument to Print the Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JSNorthWindDataSet jsNorthWindDataSet1;
        private GridEXTutorial9CSharp.JSNorthWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        internal System.Windows.Forms.ImageList ImageList1;
        internal Janus.Windows.GridEX.GridEX GridEX1;
        private GridEXTutorial9CSharp.JSNorthWindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private GridEXTutorial9CSharp.JSNorthWindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox ViewCombo;
        private System.Windows.Forms.Button customizeButton;
        private System.Windows.Forms.Button formatStylesButton;
        private Janus.Windows.GridEX.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button printPreviewButton;
    }
}

