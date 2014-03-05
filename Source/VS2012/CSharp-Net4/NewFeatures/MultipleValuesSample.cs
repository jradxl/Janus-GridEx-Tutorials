using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace NewFeatures
{
    public partial class MultipleValuesSample : UserControl
    {
        private DataSet dataSet;
        public MultipleValuesSample()
        {
            InitializeComponent();
        }

        private void MultipleValues_Load(object sender, EventArgs e)
        {
            this.CreateDummyData();
            this.SetGridSettings();
        }
        private void CreateDummyData()
        {
            //Creating a DataSet with two tables: Contacts and Categories with a many-to-many relation
            //using auxiliary table Contacts-Categories

            dataSet = new DataSet();

            DataTable contacts = new DataTable("Contacts");
            contacts.Columns.Add("ContactId", typeof(int));
            contacts.Columns.Add("Name", typeof(string));
            contacts.Columns.Add("Phone", typeof(string));
            contacts.PrimaryKey = new DataColumn[] { contacts.Columns["ContactId"] };

            DataTable categories = new DataTable("Categories");
            categories.Columns.Add("CategoryId", typeof(int));
            categories.Columns.Add("CategoryName", typeof(string));
            categories.PrimaryKey = new DataColumn[] { categories.Columns["CategoryId"] };

            DataTable contactCategories = new DataTable("ContactCategories");
            contactCategories.Columns.Add("ContactId", typeof(int));
            contactCategories.Columns.Add("CategoryId", typeof(int));
            contactCategories.PrimaryKey = new DataColumn[]{contactCategories.Columns["ContactId"],
                                                            contactCategories.Columns["CategoryId"]};

            dataSet.Tables.Add(contacts);
            dataSet.Tables.Add(categories);
            dataSet.Tables.Add(contactCategories);

            dataSet.Relations.Add("Contacts_ContactCategories", contacts.Columns["ContactId"], contactCategories.Columns["ContactId"]);
            dataSet.Relations.Add("Categories_ContactCategories", categories.Columns["CategoryId"], contactCategories.Columns["CategoryId"]);


            //Adding sample data
            contacts.Rows.Add(1,"Paul Wagner","(466) 123-5532");
            contacts.Rows.Add(2, "Stephanie Welles", "(423) 324-9836");
            contacts.Rows.Add(3, "James Jones", "(432) 566-8814");

            categories.Rows.Add(1, "Family");
            categories.Rows.Add(2, "Business");
            categories.Rows.Add(3, "Personal");
            categories.Rows.Add(4, "VIP");
            categories.Rows.Add(5, "Customers");
            categories.Rows.Add(6, "Suppliers");


            contactCategories.Rows.Add(1, 2);
            contactCategories.Rows.Add(1, 4);
            contactCategories.Rows.Add(1, 5);
            contactCategories.Rows.Add(2, 1);
            contactCategories.Rows.Add(3, 2);
            contactCategories.Rows.Add(3, 6);



        }
        private void SetGridSettings()
        {
            this.gridEX1.SetDataBinding(dataSet, "Contacts");
            this.gridEX1.RetrieveStructure();
            this.gridEX1.VisualStyle = VisualStyle.Office2003;

            //Create multiplevalues column

            //When using a many-to-manyn relation, the DataMember of the MultipleValues
            //column must be the name of the relation between the parent table and the 
            //relation table.

            GridEXColumn col = new GridEXColumn();
            col.Key = "Categories";
            col.MultipleValues = true;
            col.DataMember = "Contacts_ContactCategories";
            col.EditType = EditType.Combo;
            col.Caption = "Categories";
            col.Width = 200;
            //Since the column will be bound to a list containing DataRowView objects, we must specify which
            //field in the DataRowView will be used as value 
            col.MultipleValueDataMember = "CategoryId";

            //Fill the ValueList with the categories table
            col.HasValueList = true;
            col.ValueList.PopulateValueList(dataSet.Tables["Categories"].DefaultView, "CategoryId", "CategoryName");
            col.DefaultGroupInterval = GroupInterval.Text;
            col.CompareTarget = ColumnCompareTarget.Text;
            gridEX1.RootTable.Columns.Add(col);
        }



       
    }
}
