namespace NewFeatures
{
    partial class UnboundModeSample
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
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnClearItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.gridEX1.CardInnerSpacing = 0;
            this.gridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.gridEX1.KeepRowSettings = false;
            this.gridEX1.Location = new System.Drawing.Point(6, 50);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckIndividualRows;
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(426, 377);
            this.gridEX1.TabIndex = 0;
            this.gridEX1.UseGroupRowSelector = false;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(6, 13);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(130, 31);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "AddItem";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(144, 13);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(130, 31);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Delete Current Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnClearItems
            // 
            this.btnClearItems.Location = new System.Drawing.Point(282, 13);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(130, 31);
            this.btnClearItems.TabIndex = 4;
            this.btnClearItems.Text = "Clear Items";
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // UnboundModeSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClearItems);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gridEX1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UnboundModeSample";
            this.Size = new System.Drawing.Size(435, 440);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnClearItems;
    }
}
