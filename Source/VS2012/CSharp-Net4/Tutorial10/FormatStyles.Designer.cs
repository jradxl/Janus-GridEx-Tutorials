namespace GridEXTutorial10CSharp
{
    partial class FormatStyles
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
            this.optControlStyle = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.optGroupRow = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.optCardHeader = new System.Windows.Forms.RadioButton();
            this.optCardCaption = new System.Windows.Forms.RadioButton();
            this.optGroupByBoxInfo = new System.Windows.Forms.RadioButton();
            this.optGroupByBox = new System.Windows.Forms.RadioButton();
            this.optSelectedRow = new System.Windows.Forms.RadioButton();
            this.optAlternatingRow = new System.Windows.Forms.RadioButton();
            this.optHeader = new System.Windows.Forms.RadioButton();
            this.optRow = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // optControlStyle
            // 
            this.optControlStyle.Location = new System.Drawing.Point(24, 314);
            this.optControlStyle.Name = "optControlStyle";
            this.optControlStyle.Size = new System.Drawing.Size(116, 20);
            this.optControlStyle.TabIndex = 25;
            this.optControlStyle.Text = "Control Style";
            this.optControlStyle.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "ScrollBar and drop Down buttons style:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optGroupRow
            // 
            this.optGroupRow.Location = new System.Drawing.Point(8, 174);
            this.optGroupRow.Name = "optGroupRow";
            this.optGroupRow.Size = new System.Drawing.Size(144, 20);
            this.optGroupRow.TabIndex = 23;
            this.optGroupRow.Text = "Group Row Style";
            this.optGroupRow.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Card View Styles:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.Control;
            this.propertyGrid1.Location = new System.Drawing.Point(158, 5);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid1.Size = new System.Drawing.Size(318, 336);
            this.propertyGrid1.TabIndex = 21;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // optCardHeader
            // 
            this.optCardHeader.Location = new System.Drawing.Point(24, 258);
            this.optCardHeader.Name = "optCardHeader";
            this.optCardHeader.Size = new System.Drawing.Size(116, 20);
            this.optCardHeader.TabIndex = 20;
            this.optCardHeader.Text = "Card Header Style";
            this.optCardHeader.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // optCardCaption
            // 
            this.optCardCaption.Location = new System.Drawing.Point(24, 230);
            this.optCardCaption.Name = "optCardCaption";
            this.optCardCaption.Size = new System.Drawing.Size(116, 20);
            this.optCardCaption.TabIndex = 19;
            this.optCardCaption.Text = "Card Caption Style";
            this.optCardCaption.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // optGroupByBoxInfo
            // 
            this.optGroupByBoxInfo.Location = new System.Drawing.Point(8, 146);
            this.optGroupByBoxInfo.Name = "optGroupByBoxInfo";
            this.optGroupByBoxInfo.Size = new System.Drawing.Size(144, 20);
            this.optGroupByBoxInfo.TabIndex = 18;
            this.optGroupByBoxInfo.Text = "Group By Box Info Style";
            this.optGroupByBoxInfo.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // optGroupByBox
            // 
            this.optGroupByBox.Location = new System.Drawing.Point(8, 118);
            this.optGroupByBox.Name = "optGroupByBox";
            this.optGroupByBox.Size = new System.Drawing.Size(144, 20);
            this.optGroupByBox.TabIndex = 17;
            this.optGroupByBox.Text = "Group By Box Style";
            this.optGroupByBox.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // optSelectedRow
            // 
            this.optSelectedRow.Location = new System.Drawing.Point(8, 90);
            this.optSelectedRow.Name = "optSelectedRow";
            this.optSelectedRow.Size = new System.Drawing.Size(144, 20);
            this.optSelectedRow.TabIndex = 16;
            this.optSelectedRow.Text = "Selected Row Style";
            this.optSelectedRow.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // optAlternatingRow
            // 
            this.optAlternatingRow.Location = new System.Drawing.Point(8, 62);
            this.optAlternatingRow.Name = "optAlternatingRow";
            this.optAlternatingRow.Size = new System.Drawing.Size(144, 20);
            this.optAlternatingRow.TabIndex = 15;
            this.optAlternatingRow.Text = "Alternating Row Style";
            this.optAlternatingRow.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // optHeader
            // 
            this.optHeader.Location = new System.Drawing.Point(8, 34);
            this.optHeader.Name = "optHeader";
            this.optHeader.Size = new System.Drawing.Size(144, 20);
            this.optHeader.TabIndex = 14;
            this.optHeader.Text = "Header Style";
            this.optHeader.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // optRow
            // 
            this.optRow.Location = new System.Drawing.Point(8, 6);
            this.optRow.Name = "optRow";
            this.optRow.Size = new System.Drawing.Size(144, 20);
            this.optRow.TabIndex = 13;
            this.optRow.Text = "Row Style";
            this.optRow.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // FormatStyles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 346);
            this.Controls.Add(this.optControlStyle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optGroupRow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.optCardHeader);
            this.Controls.Add(this.optCardCaption);
            this.Controls.Add(this.optGroupByBoxInfo);
            this.Controls.Add(this.optGroupByBox);
            this.Controls.Add(this.optSelectedRow);
            this.Controls.Add(this.optAlternatingRow);
            this.Controls.Add(this.optHeader);
            this.Controls.Add(this.optRow);
            this.Name = "FormatStyles";
            this.Text = "FormatStyles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton optControlStyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optGroupRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.RadioButton optCardHeader;
        private System.Windows.Forms.RadioButton optCardCaption;
        private System.Windows.Forms.RadioButton optGroupByBoxInfo;
        private System.Windows.Forms.RadioButton optGroupByBox;
        private System.Windows.Forms.RadioButton optSelectedRow;
        private System.Windows.Forms.RadioButton optAlternatingRow;
        private System.Windows.Forms.RadioButton optHeader;
        private System.Windows.Forms.RadioButton optRow;
    }
}