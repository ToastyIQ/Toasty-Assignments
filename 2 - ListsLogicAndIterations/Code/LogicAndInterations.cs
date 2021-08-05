using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsLogicAndIterations.Code
{
	public static class LogicAndInterations
	{
		public static int For_SumTwoListsAndAllValueThatAreNotFour(int[] numberArray, List<int> numberList)
		{
			int total = 0;
			for (int i = 0; i < numberArray.Length; i++)
			{
				if (numberArray[i] != 4)
				{
					total += numberArray[i];
				}
			}
			foreach (var number in numberList)
			{
				if (number != 4)
					total += number;
			}
			return total;
		}

		public static int ForEach_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
			int total = 0;
			foreach (var number in numberList)
			{
				if (number != 4)
					total += number;
			}
			return total;
		}

		public static int DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
			int total = 0;
			int number = 0;
			int indexPosition = 0;
			do
			{
				number = numberList[indexPosition];
				total += number;
				indexPosition++;
			} while (number != 4 && indexPosition < numberList.Count ); 
			return total;
		}

		public static int While_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
			int total = 0;
			int number = 0;
			int indexPosition = 0;
			while (number != 4 && indexPosition < numberList.Count)
			{
				number = numberList[indexPosition];
				total += number;
				indexPosition++;
			};
			return total;
		}
		/*
		 * If you have not learned about System.Linq and Lambda expressions, google `C# LINQ Tutorial`...trust me, you will thank me if you learn this early.
		 */
		public static int Linq_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
			int total = numberList.Where(number => number != 4).Sum();
			return total;
		}
	}
}