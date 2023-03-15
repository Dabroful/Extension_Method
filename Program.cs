using System;
using System.Collections.Generic;

namespace Extension_Method
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                //var isEven = IsEven(result);
                var isEven = result.IsEven();
                if (isEven)
                {
                    Console.WriteLine($"{result} - четное");
                }
                else
                {
                    Console.WriteLine($"{result} - не четное");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }
            Console.ReadLine();

            int h = 77;                                                        //проверяем четное ли число
            h.IsEven();

            int g = 178;                                                       //проверяем делится ли одно число на другое
            g.IsDevide(7);

            var roads = new List<Road>();
            for (var i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);                            //вызываем метод расширения
                roads.Add(road);                                               //добаляем в лист получившиеся дороги
            }

            var roadsName = roads.ConvertToString();
            Console.WriteLine(roadsName);
            Console.ReadLine();
        }
        
    }
}