using System;

namespace GridEXTutorial16CSharp
{
	/// <summary>
	/// Summary description for Person.
	/// </summary>
	public class Person
	{
		public Person():this("","","","")
		{
		}
		public Person(string title,string name,string lastName,string suffix)
		{
			this.title = title;
			this.name = name;
			this.lastName = lastName;
			this.suffix = suffix;
		}
		private string name;
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
				if(value=="")
				{
					this.LastName = "";
				}
			}
		}
		private string lastName;
		public string LastName
		{
			get
			{
				return this.lastName;
			}
			set
			{
				this.lastName = value;
			}
		}
		private string title;
		public string Title
		{
			get
			{
				return this.title;
			}
			set
			{
				this.title = value;
			}
		}
		private string suffix;
		public string Suffix
		{
			get
			{
				return this.suffix;
			}
			set
			{
				this.suffix = value;
			}
		}
	}
}
