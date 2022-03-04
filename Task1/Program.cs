using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            Console.WriteLine("Введите длинну массива");
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

            Console.WriteLine("Введите m ");
            int m = Convert.ToInt32(Console.ReadLine()) - 1; // невключает в себя начальный элемент поэтому -1

            Console.WriteLine("Введите n(диапозон значений массива )");
            int n = Convert.ToInt32(Console.ReadLine());

            int current_position = 0;
            string path = "";
            string show_arr = "";

            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = rd.Next(1, n + 1);  // заполнение массива рандомами
                show_arr += arr[j];
            }

            Console.WriteLine("массив :" + show_arr + "\n");

            for (; ; )
            {
                if (current_position > arr.Length - 1)
                {
                    current_position = current_position - arr.Length;
                    if (current_position % arr.Length == 0)
                    {
                        path += arr[current_position % arr.Length];
                        Console.WriteLine("Результат :" + path);
                        break;
                    }
                    path += arr[current_position];
                    current_position += m;
                    //Console.WriteLine(path); // проверка итераций 
                }
                else
                {
                    path += arr[current_position];
                    current_position += m;
                    //Console.WriteLine(path ); // проверка итераций
                }
            }
            Console.ReadKey();
        }
    }
}
