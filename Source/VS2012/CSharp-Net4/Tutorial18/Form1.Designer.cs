namespace GridEXTutorial18CSharp
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
            this.GridEX1 = new Janus.Windows.GridEX.GridEX();
            this.jSNorthWindDataSet = new GridEXTutorial18CSharp.JSNorthWindDataSet();
            this.order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_DetailsTableAdapter = new GridEXTutorial18CSharp.JSNorthWindDataSetTableAdapters.Order_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSNorthWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEX1
            // 
            this.GridEX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.GridEX1.DataSource = this.order_DetailsBindingSource;
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.GridEX1.DesignTimeLayout = gridEXLayout1;
            this.GridEX1.KeepRowSettings = false;
            this.GridEX1.Location = new System.Drawing.Point(9, 12);
            this.GridEX1.Name = "GridEX1";
            this.GridEX1.ScrollBarWidth = 17;
            this.GridEX1.Size = new System.Drawing.Size(671, 446);
            this.GridEX1.TabIndex = 1;
            this.GridEX1.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.GridEX1_LoadingRow);
            // 
            // jSNorthWindDataSet
            // 
            this.jSNorthWindDataSet.DataSetName = "JSNorthWindDataSet";
            this.jSNorthWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_DetailsBindingSource
            // 
            this.order_DetailsBindingSource.DataMember = "Order Details";
            this.order_DetailsBindingSource.DataSource = this.jSNorthWindDataSet;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 471);
            this.Controls.Add(this.GridEX1);
            this.Name = "Form1";
            this.Text = "Tutorial 18 - Using Unbound Columns";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSNorthWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Janus.Windows.GridEX.GridEX GridEX1;
        private JSNorthWindDataSet jSNorthWindDataSet;
        private System.Windows.Forms.BindingSource order_DetailsBindingSource;
        private GridEXTutorial18CSharp.JSNorthWindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;

    }
}

