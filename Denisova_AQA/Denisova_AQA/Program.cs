using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denisova_AQA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Составить алгоритм: если введенное число больше 7, то вывести 'Привет'");
            Task1();
            Console.WriteLine("\nСоставить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести 'Нет такого имени'");
            Task2();
            Console.WriteLine("\nСоставить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3");
            Task3();
            Console.ReadKey();
        }

        static protected internal void Task1 (){
            try
            {
                Console.WriteLine("Введите число");
                int n = int.Parse(Console.ReadLine());
                if (n > 7) Console.WriteLine("Привет");
            }
            catch (FormatException) { Console.WriteLine("Введенные данные не соответствуют условию"); }
        }
        static protected internal void Task2()
        {
            try
            {
                Console.WriteLine("Введите имя");
                string name = Console.ReadLine();
                if (name == "Вячеслав") Console.WriteLine("Привет, Вячеслав");
                else Console.WriteLine("Нет такого имени");
            }
            catch (FormatException) { Console.WriteLine("Введенные данные не соответствуют условию"); }
        }
        static protected internal void Task3()
        {
            try
            {
                Random rand = new Random();
                Console.WriteLine("Введите количество элементов массива");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                int[] b = new int[n];
                Console.WriteLine("Введите массив А");
                for (int i = 0; i < a.Length; i++)
                    a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Полученный массив A:");
                for (int i = 0; i < a.Length; i++)
                    Console.Write(a[i]+" ");
                for (int i = 0; i < b.Length; i++)
                    b[i] = rand.Next(-15,15);
                Console.WriteLine("\nПолученный массив B:");
                for (int i = 0; i < b.Length; i++)
                    Console.Write(b[i] + " ");
                Console.WriteLine("\nЭлементы массива А (ввод с клавиатуры) кратные 3");
                for (int i=0; i< a.Length;i++)
                    if (a[i]%3 == 0) Console.Write(a[i]+" ");
                Console.WriteLine("\nЭлементы массива B (рандомное заполнение) кратные 3");
                for (int i = 0; i < b.Length; i++)
                    if (b[i] % 3 == 0) Console.Write(b[i] + " ");
            }
            catch (FormatException) { Console.WriteLine("Введенные данные не соответствуют условию"); }
            catch (Exception) { Console.WriteLine("Error!"); }
        }
    }
}
