using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 14, 8, 2, 21, 34, 8 };
            array = FirstSortingFunctionFIXED(array);

            PrintResult(array);
        }

        static private void PrintResult(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }

            // keep the app window open
            Console.Read();
        }

        static private int[] FirstSortingFunction(int[] arreglo)
        {
            int i = 0;
            int minimo;
            int newminimo;
            minimo = arreglo[0];
            while (i < arreglo.Length - 1)
            {
                minimo = arreglo[0];
                if (arreglo[i] < minimo)
                {
                    newminimo = arreglo[i];
                    arreglo[i] = arreglo[i - 1];
                    arreglo[i - 1] = newminimo;
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            return arreglo;
        }

        static private int[] FirstSortingFunctionFIXED(int[] arreglo)
        {
            int i = 1;
            int newminimo;
            while (i < arreglo.Length)
            {
                if (arreglo[i] < arreglo[i-1])
                {
                    newminimo = arreglo[i];
                    arreglo[i] = arreglo[i - 1];
                    arreglo[i - 1] = newminimo;
                    i = 1;
                }
                else
                {
                    i++;
                }
            }

            return arreglo;
        }

    }
}
