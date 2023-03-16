using System;

namespace _16._03._23
{
    class Program
    {
        static void Main(string[] args)
        {
            //дан курс рубля за каждый день в феврале месяца(случайным образом) зачсчитать средний курс рубля, максимальный курс рубля и день с максимальным курсом,минимальнй курс рубля и день с минимальным курсом.
            double[] array = new double[28];
            Random random = new Random();
              //  Random random=new Random();
            for(int i=0;i<array.Length;i++)
            {
                array[i] = 55 + 10 *random.NextDouble();
                Console.WriteLine($"array[{i}]={array[i]}");
            }
            Console.Read();
        }
    }
}