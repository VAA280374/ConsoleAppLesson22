using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson22
{
    internal class Program
    {
        static int Sum(int[] arr)
        {
            int sum = 0;
            foreach (int a in arr)
            {
                sum += a;
            }
            return sum;
        }
        static int Max(int[] arr)
        { return arr.Max(); }


        
        static void Main(string[] args)
        {
            int nI; // Размеры массива.
            Console.Write("Введите размер массива :");
            nI = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[nI];
            Random random = new Random();
            for (int i = 0; i < nI; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            
            for (int i = 0; i < nI; i++)
            {
                Console.Write(array[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
            Console.WriteLine("Сумма");
            Console.WriteLine(Sum(array));
            Console.WriteLine("Максимум"); 
            Console.WriteLine(Max(array));




            Console.ReadKey();
        }
    }
}
