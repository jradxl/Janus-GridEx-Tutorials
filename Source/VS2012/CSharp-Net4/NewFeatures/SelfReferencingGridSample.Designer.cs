namespace NewFeatures
{
    partial class SelfReferencingGridSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelfReferencingGridSample));
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.gridEX1.CardInnerSpacing = 0;
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEX1.ImageList = this.imageList1;
            this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEX1.GroupRowFormatStyle.BackColor = System.Drawing.SystemColors.Window;
            this.gridEX1.GroupRowFormatStyle.BackColorGradient = System.Drawing.SystemColors.Window;
            this.gridEX1.KeepRowSettings = false;
            this.gridEX1.Location = new System.Drawing.Point(0, 70);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(670, 375);
            this.gridEX1.TabIndex = 0;
            this.gridEX1.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)(((((((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls)
                        | Janus.Windows.GridEX.ThemedArea.Headers)
                        | Janus.Windows.GridEX.ThemedArea.GroupByBox)
                        | Janus.Windows.GridEX.ThemedArea.TreeGliphs)
                        | Janus.Windows.GridEX.ThemedArea.ControlBorder)
                        | Janus.Windows.GridEX.ThemedArea.Cards)
                        | Janus.Windows.GridEX.ThemedArea.Gridlines)
                        | Janus.Windows.GridEX.ThemedArea.CheckBoxes)));
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Orderblue.ico");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 70);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "Group by Date (Include All Rows)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Group by Date (Parent Rows Only)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Child Element";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Root Element";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelfReferencingGridSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.panel1);
            this.Name = "SelfReferencingGridSample";
            this.Size = new System.Drawing.Size(670, 445);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
