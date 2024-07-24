using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAddFeaturesOOP
{
	public partial class Human
	{
		public string Name { get; set; }
		public Human(string name,int age)
		{
			Name = name;
			Age = age;
		}
		public void Eat()
		{
			Console.WriteLine("I am eating");
		}
	}
}
