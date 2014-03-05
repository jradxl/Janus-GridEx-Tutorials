namespace GridEXTutorial15CSharp
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
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.jSNorthWindDataSet = new GridEXTutorial15CSharp.JSNorthWindDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new GridEXTutorial15CSharp.JSNorthWindDataSetTableAdapters.CustomersTableAdapter();
            this.txtCustom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSNorthWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.gridEX1.DataSource = this.customersBindingSource;
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEXLayout1;
            this.gridEX1.KeepRowSettings = false;
            this.gridEX1.Location = new System.Drawing.Point(12, 41);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.RecordNavigator = true;
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(545, 325);
            this.gridEX1.TabIndex = 0;
            this.gridEX1.EndCustomEdit += new Janus.Windows.GridEX.EndCustomEditEventHandler(this.gridEX1_EndCustomEdit);
            this.gridEX1.InitCustomEdit += new Janus.Windows.GridEX.InitCustomEditEventHandler(this.gridEX1_InitCustomEdit);
            // 
            // jSNorthWindDataSet
            // 
            this.jSNorthWindDataSet.DataSetName = "JSNorthWindDataSet";
            this.jSNorthWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.jSNorthWindDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // txtCustom
            // 
            this.txtCustom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustom.Location = new System.Drawing.Point(12, 12);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(100, 13);
            this.txtCustom.TabIndex = 2;
            this.txtCustom.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 378);
            this.Controls.Add(this.txtCustom);
            this.Controls.Add(this.gridEX1);
            this.Name = "Form1";
            this.Text = "Tutorial 15 - Using Custom Edit Events";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSNorthWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private JSNorthWindDataSet jSNorthWindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private GridEXTutorial15CSharp.JSNorthWindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        internal System.Windows.Forms.TextBox txtCustom;
    }
}

