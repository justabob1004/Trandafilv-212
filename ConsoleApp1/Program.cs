using System;

namespace _16._03._23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, -1, 4, 16, -5, 3 }; //Нахождение максимального элемента и его индекса.
            int max = array[0]; 
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            Console.WriteLine($"max={max}");
        }
    }
}