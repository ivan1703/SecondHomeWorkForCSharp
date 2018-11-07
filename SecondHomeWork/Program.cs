using System;

namespace SecondHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа отправляет все отрицательные элементы массива в конец массива");
            Console.Write("Сколько элементов в массиве вы хотите - ");
            int n = 0;
            try
            {
                n = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Возникла ошибка. Нажмите любую клавишу");
                Console.ReadKey();
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            int[] arr = new int[n];
            Random rnd = new Random();
            Console.WriteLine("исходный массив");
            foreach (int i in arr){
                arr[i] = rnd.Next(-100, 101);
                Console.Write(" {0} ", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Итоговый массив");
	    Math.Sort(arr[]);
            foreach (int i in arr){
                Console.Write(" {0} ", arr[i]);
            }
            Console.ReadKey();
        }
    }
}
