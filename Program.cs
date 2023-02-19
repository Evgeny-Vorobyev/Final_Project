using System;

namespace ShortStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] originalArray = new string[] { "London", "2023", "Moscow", "NY" };
            string[] shortArray = new string[originalArray.Length];
            int index = 0;

            for (int i = 0; i < originalArray.Length; i++)
            {
                if (originalArray[i].Length <= 3)
                {
                    shortArray[index] = originalArray[i];
                    index++;
                }
            }

            Array.Resize(ref shortArray, index);

            Console.WriteLine("Original array: " + string.Join(", ", originalArray));
            Console.WriteLine("Short array: " + string.Join(", ", shortArray));
        }
    }
}