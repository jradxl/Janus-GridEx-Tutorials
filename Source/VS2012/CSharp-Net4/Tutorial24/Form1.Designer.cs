
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using Janus.Windows.GridEX;

namespace GridEXTutorial24
{

	public partial class Form1 : System.Windows.Forms.Form
	{

		
        /// <summary>
        /// Form overrides dispose to clean up the component list.
        /// </summary>
        /// <param name="disposing"></param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
				components.Dispose();
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.GridEX1 = new Janus.Windows.GridEX.GridEX();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			//
			//GridEX1
			//
			this.GridEX1.Location = new System.Drawing.Point(12, 23);
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.ScrollBarWidth = 17;
			this.GridEX1.Size = new System.Drawing.Size(692, 376);
			this.GridEX1.TabIndex = 0;
			//
			//ImageList1
			//
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "taskIcon");
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0), (float)(13.0));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 411);
			this.Controls.Add(this.GridEX1);
			this.Name = "Form1";
			this.Text = "Tutorial 21 -Creating GridEX columns in code";
			((System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);

			this.Load += new System.EventHandler(Form1_Load);

		}
		internal Janus.Windows.GridEX.GridEX GridEX1;
		internal System.Windows.Forms.ImageList ImageList1;

	}

} //end of root namespace