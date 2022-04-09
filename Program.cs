﻿using System;

namespace Massiv8
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int minimumValue = 0;
            int maximumValue = 10;
            int maximumArrayLength = 10;

            int[] array = new int[maximumArrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minimumValue, maximumValue);
            }

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.Write("\nВведите шаг сдвига ");
            int arrayShoftstep = Int32.Parse(Console.ReadLine());

            if(arrayShoftstep>array.Length)
            {
                int tempVariable = arrayShoftstep / array.Length;
                arrayShoftstep -= tempVariable * array.Length;
            }

            int temporaryVariable = 0;

            for(int i=0;i<arrayShoftstep;i++)
            {
                temporaryVariable  = array[i];

                for(int ii=i;ii<array.Length-1;ii++)
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