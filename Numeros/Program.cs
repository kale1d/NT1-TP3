using System;
using System.Collections.Generic;
using System.Linq;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            List<int> arrSum10Numbers = new List<int>();

            arrNumbers = addNumbers(arrNumbers);

            foreach (var item in arrNumbers) 
            {
                if (isEven(item)) {
                    evenNumbers.Add(item);
                } else
                {
                    oddNumbers.Add(item);
                }
            }

            printArr(evenNumbers);
            Console.WriteLine("-----------------");
            printArr(oddNumbers);

            Console.WriteLine("Suma de todos los números:");

            arrSum(arrNumbers);

            Console.WriteLine("Suma 10 primeros numeros");

            arrSum10Numbers = arrNumbers.Where(item => item <= 10).ToList();


            arrSum(arrSum10Numbers);


        }

        //Métodos
        static List<int> addNumbers(List<int> arr)
        {
            for (int i = 1; i <= 100; i++)
            {
                arr.Add(i);
            }
            return arr;
        }

        static bool isEven(int n)
        {
            return n % 2 == 0;
        }

        static void printArr(List<int> arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void arrSum(List<int> arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
