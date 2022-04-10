using System;

namespace Massiv8
{
    class Program
    {
        static void Main(string[] args)
        {

            int maximumArrayLength = 10;

            int[] array = new int[maximumArrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
            }

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.Write("\nВведите шаг сдвига ");
            int arrayShiftstep = int.Parse(Console.ReadLine());

            if (arrayShiftstep > array.Length)
            {
                arrayShiftstep %= array.Length;
            }

            int temporaryVariable = 0;

            for(int i=0;i<arrayShiftstep;i++)
            {
                temporaryVariable  = array[0];

                for(int j=0;j<array.Length-1;j++)
                {
                    array[j] = array[j + 1];

                }
                array[array.Length-1] = temporaryVariable ;
            }

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        }
    }
}
