﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAddFeaturesOOP
{
	public static class TestExtension
	{
		public static bool TestEven(this int number)
		{
			return number % 2 == 0;
		}

		public static int CharCount(this string str, char c)
		{
			int counter = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == c)
					counter++;
			}
			return counter;
		}
	}
}
