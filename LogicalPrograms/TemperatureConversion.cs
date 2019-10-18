using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
   public class TemperatureConversion
    {
        public static void TemperatureConversionFunction()
        {
            try
            {
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                int input = Convert.ToInt16(Console.ReadLine());
                Utility utility = new Utility();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter temperature in celsius");
                        double temperature = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(temperature + " Celsius = " + utility.CelsiusToFahrenheit(temperature) + " Fahrenheit");
                        break;

                    case 2:
                        Console.WriteLine("Enter temperature in fahrenheit");
                        double temperature1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(temperature1 + " Fahrenheit = " + utility.FahrenheitToCelsius(temperature1) + " Celsius");
                        break;

                    default:
                        Console.WriteLine("Enter valid input");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " Enter integer input");
            }
        }
    }
}
