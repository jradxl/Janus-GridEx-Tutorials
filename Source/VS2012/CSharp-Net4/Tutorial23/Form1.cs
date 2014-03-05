using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
namespace GridEXTutorial23CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            contactCategoriesTableAdapter1.Fill(
                gridEXTutorialsDataDataSet1.ContactCategories);
            contacts_ContactCategoriesTableAdapter1.Fill(
                gridEXTutorialsDataDataSet1.Contacts_ContactCategories);
            contactsTableAdapter1.Fill(
                gridEXTutorialsDataDataSet1.Contacts);
            
            this.FillContactCategoriesValueList();
            this.gridEX1.Refetch();
            
        }
        private void FillContactCategoriesValueList()
        {
            GridEXColumn column = this.gridEX1.RootTable.Columns["ContactsContacts_ContactCategories"];
            column.HasValueList = true;
            //Set EditType to Combo or DropDownList.
            //In a MultipleValues Column, the dropdown will appear with a checkbox 
            //at the left of each item to let the user select multiple items
            column.EditType = EditType.DropDownList;
            column.ValueList.PopulateValueList(
                gridEXTutorialsDataDataSet1.ContactCategories.DefaultView, 
                "ContactCategoryID", "CategoryName");
            column.CompareTarget = ColumnCompareTarget.Text;
            column.DefaultGroupInterval = GroupInterval.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.contactsTableAdapter1.Update(this.gridEXTutorialsDataDataSet1);
            //Update Contacts_ContactCategories table because this table may have been changed
            //by the user in the MultipleValues column bound to this table
            this.contacts_ContactCategoriesTableAdapter1.Update(this.gridEXTutorialsDataDataSet1);
            this.gridEXTutorialsDataDataSet1.AcceptChanges();
        }

    }
}