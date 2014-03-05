namespace GridEXTutorial10CSharp
{
    partial class AppearanceDialog
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
            this.chkOffice2003 = new System.Windows.Forms.CheckBox();
            this.chkRecordNavigator = new System.Windows.Forms.CheckBox();
            this.chkAlternatingRows = new System.Windows.Forms.CheckBox();
            this.chkGroupByBox = new System.Windows.Forms.CheckBox();
            this.chkRowHeaders = new System.Windows.Forms.CheckBox();
            this.cboGridlineStyle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGridlines = new System.Windows.Forms.ComboBox();
            this.Gridlines = new System.Windows.Forms.Label();
            this.cboButtomAppearance = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboHeaderAppearance = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkVisualStyles = new System.Windows.Forms.CheckBox();
            this.cboBorder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkOffice2003
            // 
            this.chkOffice2003.Location = new System.Drawing.Point(4, 87);
            this.chkOffice2003.Name = "chkOffice2003";
            this.chkOffice2003.Size = new System.Drawing.Size(140, 24);
            this.chkOffice2003.TabIndex = 33;
            this.chkOffice2003.Text = "VisualStyle Office 2003";
            this.chkOffice2003.CheckedChanged += new System.EventHandler(this.chkOffice2003_CheckedChanged);
            // 
            // chkRecordNavigator
            // 
            this.chkRecordNavigator.Location = new System.Drawing.Point(288, 87);
            this.chkRecordNavigator.Name = "chkRecordNavigator";
            this.chkRecordNavigator.Size = new System.Drawing.Size(112, 24);
            this.chkRecordNavigator.TabIndex = 32;
            this.chkRecordNavigator.Text = "Record Navigator";
            this.chkRecordNavigator.CheckedChanged += new System.EventHandler(this.chkRecordNavigator_CheckedChanged);
            // 
            // chkAlternatingRows
            // 
            this.chkAlternatingRows.Location = new System.Drawing.Point(156, 87);
            this.chkAlternatingRows.Name = "chkAlternatingRows";
            this.chkAlternatingRows.Size = new System.Drawing.Size(136, 24);
            this.chkAlternatingRows.TabIndex = 31;
            this.chkAlternatingRows.Text = "Alternating Rows";
            this.chkAlternatingRows.CheckedChanged += new System.EventHandler(this.chkAlternatingRows_CheckedChanged);
            // 
            // chkGroupByBox
            // 
            this.chkGroupByBox.Location = new System.Drawing.Point(156, 55);
            this.chkGroupByBox.Name = "chkGroupByBox";
            this.chkGroupByBox.Size = new System.Drawing.Size(112, 24);
            this.chkGroupByBox.TabIndex = 30;
            this.chkGroupByBox.Text = "Group By Box";
            this.chkGroupByBox.CheckedChanged += new System.EventHandler(this.chkGroupByBox_CheckedChanged);
            // 
            // chkRowHeaders
            // 
            this.chkRowHeaders.Location = new System.Drawing.Point(288, 55);
            this.chkRowHeaders.Name = "chkRowHeaders";
            this.chkRowHeaders.Size = new System.Drawing.Size(104, 24);
            this.chkRowHeaders.TabIndex = 29;
            this.chkRowHeaders.Text = "Row Headers";
            this.chkRowHeaders.CheckedChanged += new System.EventHandler(this.chkRowHeaders_CheckedChanged);
            // 
            // cboGridlineStyle
            // 
            this.cboGridlineStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGridlineStyle.Location = new System.Drawing.Point(252, 231);
            this.cboGridlineStyle.Name = "cboGridlineStyle";
            this.cboGridlineStyle.Size = new System.Drawing.Size(132, 21);
            this.cboGridlineStyle.TabIndex = 28;
            this.cboGridlineStyle.SelectedIndexChanged += new System.EventHandler(this.cboGridlineStyle_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Gridline Style:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboGridlines
            // 
            this.cboGridlines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGridlines.Location = new System.Drawing.Point(252, 203);
            this.cboGridlines.Name = "cboGridlines";
            this.cboGridlines.Size = new System.Drawing.Size(132, 21);
            this.cboGridlines.TabIndex = 26;
            this.cboGridlines.SelectedIndexChanged += new System.EventHandler(this.cboGridlines_SelectedIndexChanged);
            // 
            // Gridlines
            // 
            this.Gridlines.Location = new System.Drawing.Point(4, 207);
            this.Gridlines.Name = "Gridlines";
            this.Gridlines.Size = new System.Drawing.Size(240, 20);
            this.Gridlines.TabIndex = 25;
            this.Gridlines.Text = "Gridlines:";
            this.Gridlines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboButtomAppearance
            // 
            this.cboButtomAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboButtomAppearance.Location = new System.Drawing.Point(252, 175);
            this.cboButtomAppearance.Name = "cboButtomAppearance";
            this.cboButtomAppearance.Size = new System.Drawing.Size(132, 21);
            this.cboButtomAppearance.TabIndex = 24;
            this.cboButtomAppearance.SelectedIndexChanged += new System.EventHandler(this.cboButtomAppearance_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Scrollbars and dropdown buttons appearance:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 36);
            this.label3.TabIndex = 22;
            this.label3.Tag = "";
            this.label3.Text = "Some of the appearance settings are not applied when running on Windows XP and Vi" +
                "sual Styles is checked.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboHeaderAppearance
            // 
            this.cboHeaderAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeaderAppearance.Location = new System.Drawing.Point(252, 147);
            this.cboHeaderAppearance.Name = "cboHeaderAppearance";
            this.cboHeaderAppearance.Size = new System.Drawing.Size(132, 21);
            this.cboHeaderAppearance.TabIndex = 21;
            this.cboHeaderAppearance.SelectedIndexChanged += new System.EventHandler(this.cboHeaderAppearance_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Header Appearance:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkVisualStyles
            // 
            this.chkVisualStyles.Location = new System.Drawing.Point(4, 55);
            this.chkVisualStyles.Name = "chkVisualStyles";
            this.chkVisualStyles.Size = new System.Drawing.Size(136, 24);
            this.chkVisualStyles.TabIndex = 19;
            this.chkVisualStyles.Text = "Use XP Visual Styles";
            this.chkVisualStyles.CheckedChanged += new System.EventHandler(this.chkVisualStyles_CheckedChanged);
            // 
            // cboBorder
            // 
            this.cboBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBorder.Location = new System.Drawing.Point(252, 119);
            this.cboBorder.Name = "cboBorder";
            this.cboBorder.Size = new System.Drawing.Size(132, 21);
            this.cboBorder.TabIndex = 18;
            this.cboBorder.SelectedIndexChanged += new System.EventHandler(this.cboBorder_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Border Style:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppearanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 262);
            this.Controls.Add(this.chkOffice2003);
            this.Controls.Add(this.chkRecordNavigator);
            this.Controls.Add(this.chkAlternatingRows);
            this.Controls.Add(this.chkGroupByBox);
            this.Controls.Add(this.chkRowHeaders);
            this.Controls.Add(this.cboGridlineStyle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboGridlines);
            this.Controls.Add(this.Gridlines);
            this.Controls.Add(this.cboButtomAppearance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboHeaderAppearance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkVisualStyles);
            this.Controls.Add(this.cboBorder);
            this.Controls.Add(this.label1);
            this.Name = "AppearanceDialog";
            this.Text = "Customize Appearance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOffice2003;
        private System.Windows.Forms.CheckBox chkRecordNavigator;
        private System.Windows.Forms.CheckBox chkAlternatingRows;
        private System.Windows.Forms.CheckBox chkGroupByBox;
        private System.Windows.Forms.CheckBox chkRowHeaders;
        private System.Windows.Forms.ComboBox cboGridlineStyle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGridlines;
        private System.Windows.Forms.Label Gridlines;
        private System.Windows.Forms.ComboBox cboButtomAppearance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboHeaderAppearance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkVisualStyles;
        private System.Windows.Forms.ComboBox cboBorder;
        private System.Windows.Forms.Label label1;
    }
}