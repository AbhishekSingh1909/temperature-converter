using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter.src
{
    static class ConvertTemprature
    {
        public static string TempConvert(string temp)
        {
            string [] str = temp.Split(" ");
            var value = Convert.ToDouble (str[0]);
            var unit = str[1];
            var convertValue = "";

            switch (unit)
            {
                case "C":
                    convertValue = $"{Math.Round((value * 9) / 5 + 32,2)} F";
                    break;
                case "F":
                    convertValue = $"{Math.Round((value - 32) * 5 / 9,2)} C"; 
                    break;

                default:
                    Console.WriteLine("wrong input value");
                    break;
            }

            return convertValue;
        }
    }
}
