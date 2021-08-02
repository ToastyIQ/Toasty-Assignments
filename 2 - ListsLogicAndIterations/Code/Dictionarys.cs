using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Dictionarys
    {
		public static Dictionary<Guid, decimal> Build(Guid key, decimal value)
        {
			Dictionary<Guid, decimal> dict = new Dictionary<Guid, decimal>();
            return dict;
        }

		public static decimal GetValue(Dictionary<Guid, decimal> dict, Guid key)
        {
			if (dict.ContainsKey(key)) return 1;
            else return 0;
        }

		public static void AddValue(Dictionary<Guid, decimal> dict, Guid key, decimal value)
		{
            if (dict.ContainsKey(key)) return;
            else dict.Add(key, value);
		}
	}
}