namespace GridEXTutorial12CSharp
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
            this.fillGridButton = new System.Windows.Forms.Button();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // fillGridButton
            // 
            this.fillGridButton.Location = new System.Drawing.Point(12, 12);
            this.fillGridButton.Name = "fillGridButton";
            this.fillGridButton.Size = new System.Drawing.Size(145, 28);
            this.fillGridButton.TabIndex = 0;
            this.fillGridButton.Text = "Fill Grid...";
            this.fillGridButton.UseVisualStyleBackColor = true;
            this.fillGridButton.Click += new System.EventHandler(this.fillGridButton_Click);
            // 
            // gridEX1
            // 
            this.gridEX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEX1.BoundMode = Janus.Windows.GridEX.BoundMode.Bound;
            this.gridEX1.KeepRowSettings = false;
            this.gridEX1.Location = new System.Drawing.Point(12, 46);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.ScrollBarWidth = 17;
            this.gridEX1.Size = new System.Drawing.Size(621, 349);
            this.gridEX1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 407);
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.fillGridButton);
            this.Name = "Form1";
            this.Text = "Tutorial 12 - Binding GridEX Control at Run Time";
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fillGridButton;
        private Janus.Windows.GridEX.GridEX gridEX1;
    }
}

