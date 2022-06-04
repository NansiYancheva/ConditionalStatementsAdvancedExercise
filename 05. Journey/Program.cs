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
                double budget = double.Parse(Console.ReadLine());
                string season = Console.ReadLine();
                double priceOfCampOrHotel = 0;
                string destination = "";
                string typeOfVacancy = "";
                //Actions
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    if (season == "summer")
                    {
                        typeOfVacancy = "Camp";
                        priceOfCampOrHotel = budget * 0.30;
                    }
                    else if (season == "winter")
                    {
                        typeOfVacancy = "Hotel";
                        priceOfCampOrHotel = budget * 0.70;
                    }
                }


                else if (budget <=1000)
                {
                    destination = "Balkans";
                    if (season == "summer")
                    {
                        typeOfVacancy = "Camp";
                        priceOfCampOrHotel = budget * 0.40;
                    }
                    else if (season == "winter")
                    {
                        typeOfVacancy = "Hotel";
                        priceOfCampOrHotel = budget * 0.80;
                    }
                }



                else if (budget > 1000)
                {
                    destination = "Europe";
                    typeOfVacancy = "Hotel";
                    priceOfCampOrHotel = budget * 0.90;
                }


                //Output
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{typeOfVacancy} - {priceOfCampOrHotel:f2}");


            }
        }
    }
}