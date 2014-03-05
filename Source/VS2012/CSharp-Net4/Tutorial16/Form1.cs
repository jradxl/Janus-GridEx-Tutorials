using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GridEXTutorial16CSharp
{
    public partial class Form1 : Form
    {
        private PersonCollection people;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Creating the collection
            people = new PersonCollection();
            people.Add(new Person("Mr.", "John", "Smith", "Sr."));
            people.Add(new Person("Mrs.", "Mary", "Jones", ""));
            people.Add(new Person("Miss", "Sally", "Porter", ""));
            people.Add(new Person("Mr.", "Joseph", "Gold", "Jr."));
            people.Add(new Person("Dr.", "Ian", "Goldsmith", ""));

            //Binding GridEX to the people collection
            GridEX1.SetDataBinding(people, "");
            //Forcing GridEX control to generate the columns needed
            //to display all the properties in the Person class.
            GridEX1.RetrieveStructure();
        }

        private void GridEX1_GetNewRow(object sender, Janus.Windows.GridEX.GetNewRowEventArgs e)
        {
            e.NewRow = new Person();
        }
    }
}