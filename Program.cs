using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekz_Gorodkov_ElemBolshe_SrAr
{
    class Program
    {
        /// <summary>
        /// Контрольная работа
        /// Задача: Вывести элементы массива, которые больше среднего арифметического
        /// Автор: Городков Артём
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Задание: Вывести элементы массива, которые больше среднего арифметического");
            Console.WriteLine();
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n]; //Основной массив 
            Double sum = 0; //Сумма всех элементов массива 
            int[] elem = new int[n]; //2й массив для значений больше ср.арифм. 
            int k = 0; //счетчик 
            Double sr; //хранит среднее арифметическое 
            Random rnd = new Random(); //Рандомные числа 
            int ch = rnd.Next(-100, 100); //Получение первого случ. числа 
            for (int i = 0; i < n; i++)//перебор массива 
            {
                mass[i] = ch; //присвоение рандомных чисел массиву 
                sum = sum + mass[i]; //сложение присвоенных чисел 
                ch = rnd.Next(-100, 100); //получение следующего случ. числа 
                Console.Write($"{mass[i]}  ");
            }
            sr = sum / n; //Среднее арифметическое 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Среднее арифметическое: {sr}");
            Console.WriteLine();
            Console.WriteLine("Массив, элементы которого больше среднего арифметического: ");
            for (int i = 0; i < n; i++) //перебор массива 
            {
                if (mass[i] > sr) //если значение больше чем среднее арифметическое 
                {
                    elem[k] = mass[i]; //то значение сохраняется в другой массив 
                    k++;
                }
            }
            for (int i = 0; i < k; i++) //перебор нового массива и вывод его в консоль 
            {
                Console.Write($"{elem[i]}  ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
