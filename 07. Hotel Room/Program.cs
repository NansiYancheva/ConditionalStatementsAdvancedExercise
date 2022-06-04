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
                string month = Console.ReadLine();
                int numberNights = int.Parse(Console.ReadLine());
                double pricePerStudio = 0;
                double pricePerApartment = 0;
                //Actions
                switch (month)
                {
                    case "May":
                    case "October":
                        pricePerStudio = numberNights * 50;
                        pricePerApartment = numberNights * 65;

                        if (numberNights > 7 && numberNights <= 14)
                            pricePerStudio = pricePerStudio - pricePerStudio * 0.05;
                        else if (numberNights > 14)
                        {
                            pricePerApartment = pricePerApartment - pricePerApartment * 0.10;
                            pricePerStudio = pricePerStudio - pricePerStudio * 0.30;
                        }
                        break;

                    case "June":
                    case "September":
                        pricePerStudio = numberNights * 75.20;
                        pricePerApartment = numberNights * 68.70;

                        if (numberNights > 14)
                        {
                            pricePerStudio = pricePerStudio - pricePerStudio * 0.20;
                            pricePerApartment = pricePerApartment - pricePerApartment * 0.10;
                        }
                        break;

                    case "July":
                    case "August":
                        pricePerStudio = numberNights * 76;
                        pricePerApartment = numberNights * 77;
                        if (numberNights > 14)
                            pricePerApartment = pricePerApartment - pricePerApartment * 0.10;
                        break;
                }

                //Output
                Console.WriteLine($"Apartment: {pricePerApartment:f2} lv.");
                Console.WriteLine($"Studio: {pricePerStudio:f2} lv.");


            }
        }
    }
}