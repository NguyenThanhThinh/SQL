using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());

            var isPassed = (grade >= 3) ? "Passed!" : string.Empty;

            Console.WriteLine(isPassed);


            /*var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var currentTime = new TimeSpan(hours, minutes, 0);
            var thirtyMinutes = new TimeSpan(0, 30, 0);

            var timeAfterThirtyMinutes = currentTime + thirtyMinutes;

            Console.WriteLine("{0:h\\:mm}", timeAfterThirtyMinutes);
            */

            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var waterPrice = 0.70;
            var coffeePrice = 1.00;
            var beerPrice = 1.70;
            var teaPrice = 1.20;

            var totalPrice = 0.0;

            switch (profession)
            {
                case "water":
                    totalPrice = waterPrice * quantity;
                    break;

                case "coffee":
                case "coffeetea":
                    totalPrice = coffeePrice * quantity;
                    break;

                case "beer":
                    totalPrice = beerPrice * quantity;
                    break;

                default:
                    totalPrice = teaPrice * quantity;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            Console.ReadKey();
        }
    }
}
