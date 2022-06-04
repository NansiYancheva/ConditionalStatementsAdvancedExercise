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
                string typeOfProjection = Console.ReadLine();
                int numberRow = int.Parse(Console.ReadLine());
                int numberColumn = int.Parse(Console.ReadLine());
                double income = 0;
                //Actions
                switch (typeOfProjection)
                {
                    case "Premiere":
                        income = numberColumn * numberRow * 12;
                        break;
                    case "Normal":
                        income = numberColumn * numberRow * 7.50;
                        break;
                    case "Discount":
                        income = numberRow * numberColumn * 5.00;
                        break ;
                }
                Console.WriteLine($"{income:f2}");

                //Output



            }
        }
    }
}