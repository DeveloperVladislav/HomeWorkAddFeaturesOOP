using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAddFeaturesOOP
{
	public record class Person
	{
		public string Name { get; init; }
		public Person(string name) => Name = name;
		
	}
}
