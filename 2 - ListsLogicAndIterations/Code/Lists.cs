using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Lists
	{
		public static List<decimal> BuildList(decimal first, decimal second)
		{
			List<decimal> ToastyListy = new List<decimal>();
            ToastyListy.Add(first);
			ToastyListy.Add(second);
			return ToastyListy;
        }

		public static decimal GetValue(List<decimal> ToastyListy, int position)
		{
			if (position < 0 || position > ToastyListy.Count - 1) return 0;
			else return ToastyListy[position];
        }

		public static void AddValue(List<decimal> ToastyListy, decimal value)
		{
			ToastyListy.Add(value);
		}

		public static void AddValue(List<decimal> ToastyListy, List<decimal> ToastyListyB)
		{
			ToastyListy.AddRange(ToastyListyB);
		}

		public static void RemoveValue(List<decimal> ToastyListy, decimal value)
		{
			if (ToastyListy.Contains(value)) ToastyListy.Remove(value);
		}
	}
}