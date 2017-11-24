using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;

            var studioNights = nightsCount;

            if ((month == "September" || month == "October") && nightsCount > 7)
            {
                studioNights -= 1;
            }
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50 * studioNights;
                    doublePrice = 65 * nightsCount;
                    suitePrice = 75 * nightsCount;

                    if (nightsCount > 7)
                    {
                        studioPrice = (50 * 0.95) * studioNights;
                    }

                    break;

                case "June":
                case "September":
                    studioPrice = 60 * studioNights;
                    doublePrice = 72 * nightsCount;
                    suitePrice = 82 * nightsCount;

                    if (nightsCount > 14)
                    {
                        doublePrice = (72 * 0.90) * nightsCount;
                    }

                    break;

                case "July":
                case "August":
                case "December":
                    studioPrice = 68 * nightsCount;
                    doublePrice = 77 * nightsCount;
                    suitePrice = 89 * nightsCount;

                    if (nightsCount > 14)
                    {
                        suitePrice = (89 * 0.85) * nightsCount;
                    }

                    break;
            }

            Console.WriteLine($"Studio: {studioPrice:F2} USD.");
            Console.WriteLine($"Double: {doublePrice:F2} USD.");
            Console.WriteLine($"Suite: {suitePrice:F2} USD.");
        }
    }
}
