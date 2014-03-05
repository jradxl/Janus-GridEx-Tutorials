using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace GridEXTutorial14CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLayout();
        }
        private void LoadLayout()
        {
            string layoutDir = GetLayoutDirectory() + @"\GridEXLayout.gxl";
            if (FileExists(layoutDir))
            {
                FileStream layoutStream;
                layoutStream = new FileStream(layoutDir, FileMode.Open);
                GridEX1.LoadLayoutFile(layoutStream);
                layoutStream.Close();
            }
        }
        private string GetLayoutDirectory()
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(Application.ExecutablePath).Parent;
            while (currentDirectory != null)
            {
                DirectoryInfo[] childDirectories = currentDirectory.GetDirectories();
                foreach (DirectoryInfo childDir in childDirectories)
                {

                    if (childDir.Name == "LayoutData")
                    {
                        return childDir.FullName;
                    }

                }
                currentDirectory = currentDirectory.Parent;
            }
            return "";
        }
        private bool FileExists(string fileName)
        {
            FileInfo fInfo = new FileInfo(fileName);
            return fInfo.Exists;
        }
        private void GridEX1_CurrentLayoutChanged(object sender, EventArgs e)
        {
            //clear the DataTable used by the previous layout
            jsNorthWindDataSet1.Clear();

            //When layouts are persisted into a file,
            //the DataSource and DataMember properties are
            //not persisted so you must reset them at run time
            //instead of resseting the DataSource and DataMember
            //properties when the layout is made, this could be done
            //in all the layouts at once in the LayoutLoad event
            if (GridEX1.CurrentLayout != null)
            {
                switch (GridEX1.CurrentLayout.Key)
                {
                    case "Customers":
                        customersTableAdapter1.Fill(jsNorthWindDataSet1.Customers);
                        GridEX1.SetDataBinding(jsNorthWindDataSet1, "Customers");
                        break;
                    case "Products":
                        productsTableAdapter1.Fill(jsNorthWindDataSet1.Products);
                        GridEX1.SetDataBinding(jsNorthWindDataSet1, "Products");
                        break;
                    case "Suppliers":
                        suppliersTableAdapter1.Fill(jsNorthWindDataSet1.Suppliers);
                        GridEX1.SetDataBinding(jsNorthWindDataSet1, "Suppliers");
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GridEX1.CurrentLayout == null || GridEX1.CurrentLayout.Key != "Customers")
            {
                GridEX1.CurrentLayout = GridEX1.Layouts["Customers"];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GridEX1.CurrentLayout == null || GridEX1.CurrentLayout.Key != "Products")
            {
                GridEX1.CurrentLayout = GridEX1.Layouts["Products"];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GridEX1.CurrentLayout == null || GridEX1.CurrentLayout.Key != "Suppliers")
            {
                GridEX1.CurrentLayout = GridEX1.Layouts["Suppliers"];
            }
        }

        private void GridEX1_CurrentLayoutChanging(object sender, CancelEventArgs e)
        {
            //To persist user changes in the current layout,
            //call the Update method explicitly before changing the layout
            if (GridEX1.CurrentLayout != null)
            {
                GridEX1.CurrentLayout.Update();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            DialogResult result;
            string layoutDir;
            FileStream layoutStream;

            result = MessageBox.Show("Do you want to preserve the changes in " +
                    "the GridEX control layout?", "Preserve changes", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (result == System.Windows.Forms.DialogResult.Yes)
            {
                DirectoryInfo dInfo;
                dInfo = new DirectoryInfo(Application.ExecutablePath).Parent;
                dInfo = new DirectoryInfo(dInfo.FullName + @"\LayoutData");
                if (!dInfo.Exists) dInfo.Create();
                layoutDir = dInfo.FullName + @"\GridEXLayout.gxl";
                layoutStream = new FileStream(layoutDir, FileMode.Create);
                GridEX1.SaveLayoutFile(layoutStream);
                layoutStream.Close();
            }
        }

    }
}