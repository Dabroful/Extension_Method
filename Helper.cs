using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Extension_Method
{
    public static class Helper
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static bool IsDevide(this int i, int j)
        {
            return i % j == 0;
        }

        public static string ConvertToString<T>(this IEnumerable<T> collection)
        {
            var result = "";
            foreach (var item in collection)
            {
                result += item.ToString() + ", \r\n";
            }
            return result;
        }

        public static Road CreateRandomRoad(this Road road, int min, int max)                                //это метод расширения, который инициализирует нашу дорогу
        {
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));                         //правильная работа рандомайзера
            road.Number = "Е" + rnd.Next(1, 100);
            road.Length = rnd.Next(min, max);
            return road;
        }
    }
    
}