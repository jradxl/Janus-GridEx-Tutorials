using System;
using System.Collections;
using System.ComponentModel;

namespace GridEXTutorial16CSharp
{
	/// <summary>
	/// Summary description for PersonCollection.
	/// </summary>
	public class PersonCollection:CollectionBase
	{
		public PersonCollection()
		{

		}
		public void Add(Person person)
		{
			this.List.Add(person);
		}
		public void Remove(Person person)
		{
			this.List.Remove(person);
		}
		public Person this[int index]
		{
			get
			{
				return (Person)base.List[index];
			}
		}

	}
}
