using System;

namespace ListsLogicAndIterations.Code
{
    public static class Arrays
    {
        public static int[] BuildIntArray(int first, int second)
        {
            int[] array = { first, second };
            return array;
        }

        public static int GetArrayValue(int[] array, int position)
        {
            try
            {
                return array[position];
            }
            catch
            {
                return 0;
            }
        }
    }
}