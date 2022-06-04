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
                string typeOfFlowers = Console.ReadLine();
                int numberFlowers = int.Parse(Console.ReadLine());
                int budget = int.Parse(Console.ReadLine());
                double totalPriceWithoutDiscount = 0;
                double totalPrice = 0;
                //Actions
                if (typeOfFlowers == "Roses")
                {
                    if (numberFlowers <= 80)
                        totalPrice = numberFlowers * 5;
                    else
                    {
                        totalPriceWithoutDiscount = numberFlowers * 5;
                        totalPrice = totalPriceWithoutDiscount - totalPriceWithoutDiscount * 0.10;
                    }
                }



                else if (typeOfFlowers == "Dahlias")
                {
                    if (numberFlowers <= 90)
                        totalPrice = numberFlowers * 3.80;
                    else
                    {
                        totalPriceWithoutDiscount = numberFlowers * 3.80;
                        totalPrice = totalPriceWithoutDiscount - totalPriceWithoutDiscount * 0.15;
                    }
                }


                else if (typeOfFlowers == "Tulips")
                {
                    if (numberFlowers <= 80)
                        totalPrice = numberFlowers * 2.80;
                    else
                    {
                        totalPriceWithoutDiscount = numberFlowers * 2.80;
                        totalPrice = totalPriceWithoutDiscount - totalPriceWithoutDiscount * 0.15;
                    }
                }


                else if (typeOfFlowers == "Narcissus")
                {
                    if (numberFlowers >= 120)
                        totalPrice = numberFlowers * 3;
                    else
                    {
                        totalPriceWithoutDiscount = numberFlowers * 3;
                        totalPrice = totalPriceWithoutDiscount + (totalPriceWithoutDiscount * 0.15);
                    }

                }




                else if (typeOfFlowers == "Gladiolus")
                {
                    if (numberFlowers >= 80)
                        totalPrice = numberFlowers * 2.50;

                    else
                    {
                        totalPriceWithoutDiscount = numberFlowers * 2.50;
                        totalPrice = totalPriceWithoutDiscount + (totalPriceWithoutDiscount * 0.20);
                    }
                }

                //Output
                if (totalPrice <= budget)
                {
                    double difference = budget - totalPrice;
                    Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                }
                else
                {
                    double difference = totalPrice - budget;
                    Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                }

            }
        }
    }
}