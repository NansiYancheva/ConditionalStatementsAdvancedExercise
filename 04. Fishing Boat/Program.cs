using System;
namespace Practice2102
{
    namespace Practice2102
    {
        class Program
        {
            static void Main()
            {
                //Input
                int budget = int.Parse(Console.ReadLine());
                string season = Console.ReadLine(); // "Spring", "Summer", "Autumn", "Winter"
                int numberFishermen = int.Parse(Console.ReadLine());
                double priceOfTheShip = 0;
                //Actions
                if (season == "Spring")
                {
                    if (numberFishermen <= 6)
                        priceOfTheShip = 3000 - (3000 * 0.10);
                    else if (numberFishermen >= 7 && numberFishermen <=11)
                        priceOfTheShip = 3000  - (3000 * 0.15);
                    else if (numberFishermen >= 12)
                        priceOfTheShip = 3000 - (3000 * 0.25);
                }


                else if (season == "Summer" || season == "Autumn")
                {
                    if (numberFishermen <= 6)
                        priceOfTheShip = 4200 - (4200 * 0.10);
                    else if (numberFishermen >= 7 && numberFishermen <= 11)
                        priceOfTheShip = 4200 - (4200 * 0.15);
                    else if (numberFishermen >= 12)
                        priceOfTheShip = 4200 - (4200 * 0.25);
                }

                else if (season == "Winter")
                {
                    if (numberFishermen <= 6)
                        priceOfTheShip = 2600 - (2600 * 0.10);
                    else if (numberFishermen >= 7 && numberFishermen <= 11)
                        priceOfTheShip = 2600 - (2600 * 0.15);
                    else if (numberFishermen >= 12)
                        priceOfTheShip = 2600 - (2600 * 0.25);
                }


                //Output
                if (numberFishermen % 2 == 0 && season != "Autumn")
                {
                    double additionalDiscount = priceOfTheShip * 0.05;
                    priceOfTheShip = priceOfTheShip - additionalDiscount;
                }
                else
                    priceOfTheShip = priceOfTheShip;
                
                if (budget >= priceOfTheShip)
                {
                    double leftMoney = budget - priceOfTheShip;
                    Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
                }
                else
                {
                    double leftMoney = priceOfTheShip - budget;
                    Console.WriteLine($"Not enough money! You need {leftMoney:f2} leva.");
                }
            }
        }
    }
}