namespace NewFeatures
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdNavigator = new Janus.Windows.GridEX.GridEX();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grdNavigator);
            this.splitContainer1.Size = new System.Drawing.Size(697, 450);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // grdNavigator
            // 
            this.grdNavigator.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.grdNavigator.CardInnerSpacing = 0;
            this.grdNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNavigator.KeepRowSettings = false;
            this.grdNavigator.Location = new System.Drawing.Point(0, 0);
            this.grdNavigator.Name = "grdNavigator";
            this.grdNavigator.ScrollBarWidth = 17;
            this.grdNavigator.Size = new System.Drawing.Size(232, 450);
            this.grdNavigator.TabIndex = 0;
            this.grdNavigator.SelectionChanged += new System.EventHandler(this.grdNavigator_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "Form1";
            this.Text = "GridEX New Features";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNavigator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Janus.Windows.GridEX.GridEX grdNavigator;

    }
}

