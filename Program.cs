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
            int arrayShoftstep = Int32.Parse(Console.ReadLine());

            if (arrayShoftstep > array.Length)
            {
                int tempVariable = arrayShoftstep / array.Length;
                arrayShoftstep -= (tempVariable * array.Length);
            }

            int temporaryVariable = 0;

            for(int i=0;i<arrayShoftstep;i++)
            {
                temporaryVariable  = array[0];

                for(int ii=0;ii<array.Length-1;ii++)
                {
                    array[ii] = array[ii + 1];

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
