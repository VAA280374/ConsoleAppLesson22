using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson22
{
    internal class Program
    {
        static void Sum(int[] arr)
        {
            int sum = 0;
            foreach (int a in arr)
            {
                sum += a;
            }
            Console.WriteLine("Сумма = {0}", sum);
        }
        static void Max(Task t, object obj)
        {
            int[] arr = (int[])obj; // Уууу! Блин! Работает...
            Console.WriteLine("Максимум = {0}", arr.Max()); 
        }


        
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

            Task task = new Task(() => Sum(array));

            Action<Task, object> action2 = new Action<Task, object>(Max); 
            Task task2 = task.ContinueWith(action2, array);

            task.Start();

            Console.ReadKey();
        }
    }
}
