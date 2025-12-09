using System;
using System.Globalization;

namespace task4
{
    struct Weather
    {
        public string City { get; set; }
        public double? Temperature { get; set; }

        public override string ToString()
        {
            var t = Temperature?.ToString(CultureInfo.InvariantCulture) ?? "Нет данных";
            return Temperature.HasValue ? $"{City}: {t}°C" : $"{City}: {t}";
        }
    }

    class Program
    {
        static void Main()
        {
            var w1 = new Weather { City = "Москва", Temperature = 22.5 };
            var w2 = new Weather { City = "Сочи", Temperature = null };
            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w2.Temperature ?? -999);
        }
    }
}
