namespace Tutorial21
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
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnInsertItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound;
            this.gridEX1.CardInnerSpacing = 0;
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEXLayout1;
            this.gridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.gridEX1.KeepRowSettings = true;
            this.gridEX1.Location = new System.Drawing.Point(12, 54);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckIndividualRows;
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(549, 374);
            this.gridEX1.TabIndex = 0;
            this.gridEX1.UseGroupRowSelector = false;
            this.gridEX1.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.gridEX1_FormattingRow);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 11);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(104, 37);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnInsertItem
            // 
            this.btnInsertItem.Location = new System.Drawing.Point(122, 13);
            this.btnInsertItem.Name = "btnInsertItem";
            this.btnInsertItem.Size = new System.Drawing.Size(121, 35);
            this.btnInsertItem.TabIndex = 2;
            this.btnInsertItem.Text = "Insert Item";
            this.btnInsertItem.UseVisualStyleBackColor = true;
            this.btnInsertItem.Click += new System.EventHandler(this.btnInsertItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(249, 11);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(140, 36);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove Selected Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearItems
            // 
            this.btnClearItems.Location = new System.Drawing.Point(395, 11);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(141, 35);
            this.btnClearItems.TabIndex = 4;
            this.btnClearItems.Text = "Clear Items";
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 440);
            this.Controls.Add(this.btnClearItems);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnInsertItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gridEX1);
            this.Name = "Form1";
            this.Text = "Tutorial 21 - Using GridEX Control in Unbound Mode";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnInsertItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearItems;
    }
}

