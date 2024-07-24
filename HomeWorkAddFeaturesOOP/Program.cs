namespace HomeWorkAddFeaturesOOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Работа с операторами
			Console.WriteLine("--------------Работа с операторами-----------");
			Console.WriteLine();
			Counter counter1 = new Counter { Value = 23 };
			Counter counter2 = new Counter { Value = 45 };
			bool result = counter1 > counter2;
			Console.WriteLine(result); // false

			Counter counter3 = counter1 + counter2;
			Console.WriteLine(counter3.Value);
			Console.WriteLine();
			Console.WriteLine("--------Операторы инкремента и декремента------------");
			Console.WriteLine();
			counter1.Value = 10;
			counter2 = counter1++;
			Console.WriteLine(counter1.Value);      // 20
			Console.WriteLine(counter2.Value);      // 10

			counter3 = ++counter1;
			Console.WriteLine(counter1.Value);      // 30
			Console.WriteLine(counter3.Value);      // 30
			Console.WriteLine();

			Console.WriteLine("-----------Операторы инкремента и декремента-------------");
			Console.WriteLine();
			Counter counter4 = new Counter { Seconds = 23 };

			int x = (int)counter4;//операция приведения типов
			Console.WriteLine(x);   // 23

			Counter counter5 = x;
			Console.WriteLine(counter5.Seconds);  // 23
			Console.WriteLine();
			Console.WriteLine("------------Индексаторы--------------");
			Console.WriteLine();
			MyCollection collection = new MyCollection();

			// Заполнение коллекции
			collection[0] = "Первый элемент";
			collection[2] = "Третий элемент";

			// Доступ к элементам
			Console.WriteLine(collection[0]); // Выведет: "Первый элемент"
			Console.WriteLine(collection[2]); // Выведет: "Третий элемент"

			// Обработка исключения при выходе за пределы массива
			try
			{
				Console.WriteLine(collection[6]); // Выведет исключение
			}
			catch (IndexOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine();
			Console.WriteLine("------------Переменные-ссылки и возвращение ссылки(ref)--------------");
			Console.WriteLine();

			int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
			ref int numberRef = ref Find(4, numbers); // ищем число 4 в массиве
			numberRef = 9; // заменяем 4 на 9
			Console.WriteLine(numbers[3]); // 9

			ref int Find(int number, int[] numbers)
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					if (numbers[i] == number)
					{
						return ref numbers[i]; // возвращаем ссылку на адрес, а не само значение
					}
				}
				throw new IndexOutOfRangeException("число не найдено");
			}

			Console.WriteLine();
			Console.WriteLine("------------Методы расширения(Extetsion)--------------");
			Console.WriteLine();

			//TestEven
			int num1 = 10;
			int num2 = 5;
			Console.WriteLine(num1 + " - " + num1.TestEven());
			Console.WriteLine(num2 + " - " + num2.TestEven());
			Console.WriteLine();

			//CharCount
			string s = "Привет мир";
			char c = 'и';
			int i = s.CharCount(c);
			Console.WriteLine(i);

			Console.WriteLine();
			Console.WriteLine("------------Partial--------------");
			Console.WriteLine();

			Human human = new Human("Name", 29);
			Console.Write($"My name is {human.Name} and ");
			human.Eat();
		}
	}
}