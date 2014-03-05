namespace NewFeatures
{
    partial class CardViewSample
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
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardViewSample));
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.jsNorthWindDataSet1 = new NewFeatures.JSNorthWindDataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.customersTableAdapter1 = new NewFeatures.JSNorthWindDataSetTableAdapters.CustomersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.gridEX1.ImageList = this.imageList1;
            this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEX1.KeepRowSettings = false;
            this.gridEX1.Location = new System.Drawing.Point(0, 38);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(533, 369);
            this.gridEX1.TabIndex = 0;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // jsNorthWindDataSet1
            // 
            this.jsNorthWindDataSet1.DataSetName = "JSNorthWindDataSet";
            this.jsNorthWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Contacts16A.ico");
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 38);
            this.panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(170, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Gridlines";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Remove InnerSpacing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardViewSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.panel1);
            this.Name = "CardViewSample";
            this.Size = new System.Drawing.Size(533, 407);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsNorthWindDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private JSNorthWindDataSet jsNorthWindDataSet1;
        private NewFeatures.JSNorthWindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
