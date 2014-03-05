
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
	public partial class Form1
	{

		internal Form1()
		{
			InitializeComponent();
		}
		private DataSet gridDataSource;
		private void Form1_Load(object sender, System.EventArgs e)
		{

			CreateGridColumns();
			CreateDataSourceAndBindGrid();
		}

		private void CreateGridColumns()
		{

			GridEX1.ImageList = ImageList1;
			GridEX1.AllowAddNew = InheritableBoolean.True;
			GridEX1.AllowDelete = InheritableBoolean.True;
			GridEX1.EmptyRows = true;
			GridEX1.ColumnAutoResize = true;

			//Create a new GridEXTable
			GridEXTable table = new GridEXTable();
			//add columns to the table

			//adding an unbound icon column
			GridEXColumn iconColumn = table.Columns.Add("Icon", ColumnType.Image, EditType.NoEdit);
			//set other properties
			iconColumn.Width = 22;
			iconColumn.Caption = "";
			iconColumn.AllowSort = false;
			iconColumn.AllowGroup = false;
			iconColumn.AllowSize = false;
			iconColumn.Selectable = false;
			iconColumn.BoundMode = ColumnBoundMode.UnboundFetch;
			iconColumn.ImageKey = "TaskIcon"; //TaskIcon image is defined in ImageList1

			//adding a checkbox column that will be bound to "Complete" DataColumn in the datasource
			GridEXColumn completeColumn = table.Columns.Add("Complete", ColumnType.CheckBox, EditType.CheckBox);
			completeColumn.Width = 24;
			completeColumn.AllowSize = false;
			completeColumn.Caption = "";

			//adding a text column that will be bound to "Subject" DataColumn in the datasource
			GridEXColumn subjectColumn = table.Columns.Add("Subject", ColumnType.Text, EditType.TextBox);
			subjectColumn.Width = 250;

			//adding a CalendarCombo combo that will be bound to "DueDate" DataColumn in the datasource
			GridEXColumn dueDateColumn = table.Columns.Add("DueDate", ColumnType.Text, EditType.CalendarCombo);
			dueDateColumn.Width = 120;
			dueDateColumn.DefaultGroupInterval = GroupInterval.Date;
			dueDateColumn.FormatString = "d"; //use short date format

			//once all columns have been added to the GridEXTable, set the table as the RootTable of the grid
			GridEX1.RootTable = table;


		}
		private void CreateDataSourceAndBindGrid()
		{
			gridDataSource = new DataSet();
			DataTable dataTable = new DataTable("Tasks");
			DataColumn column = dataTable.Columns.Add("Id", typeof(int));
			column.AutoIncrement = true;
			dataTable.Columns.Add("Subject", typeof(string));
			dataTable.Columns.Add("Complete", typeof(bool));
			dataTable.Columns.Add("DueDate", typeof(DateTime));

			//add datatable to dataset
			gridDataSource.Tables.Add(dataTable);
			//adding some sample rows
			dataTable.Rows.Add(1, "Task 1", false, DateTime.Today.AddDays(2));
			dataTable.Rows.Add(2, "Task 2", true, DateTime.Today);

			//bind grid to the datasource
			GridEX1.SetDataBinding(gridDataSource, "Tasks");

		}
	}

} //end of root namespace