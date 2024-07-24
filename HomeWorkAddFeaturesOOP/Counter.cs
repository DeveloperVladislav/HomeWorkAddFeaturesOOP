using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAddFeaturesOOP
{
	//Работа с операторами
	public class Counter
	{
		public int Value { get; set; }
		public int Seconds { get; set; }

		public static Counter operator +(Counter counter1, Counter counter2)//оператор сложения
		{
			return new Counter { Value = counter1.Value + counter2.Value };
		}
		//операторы сравнения
		public static bool operator >(Counter counter1, Counter counter2)
		{
			return counter1.Value > counter2.Value;
		}
		public static bool operator <(Counter counter1, Counter counter2)
		{
			return counter1.Value < counter2.Value;
		}

		public static Counter operator ++(Counter counter1)
		{
			return new Counter { Value = counter1.Value + 10 };
		}


		//Перегрузка операций преобразования типов

		public static implicit operator Counter(int x)
		{
			return new Counter { Seconds = x };
		}
		public static explicit operator int(Counter counter)
		{
			return counter.Seconds;
		}
	}
}
