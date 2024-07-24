using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAddFeaturesOOP
{
	//Работа с индексаторами
	public class MyCollection
	{
		private string[] items = new string[5]; // Массив для хранения элементов

		// Индексатор
		public string this[int index]
		{
			get
			{
				if (index >= 0 && index < items.Length)
				{
					return items[index];
				}
				else
				{
					throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
				}
			}
			set
			{
				if (index >= 0 && index < items.Length)
				{
					items[index] = value;
				}
				else
				{
					throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
				}
			}
		}
	}
}
