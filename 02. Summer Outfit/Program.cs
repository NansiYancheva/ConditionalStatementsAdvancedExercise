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
                int gradus = int.Parse(Console.ReadLine());
                string timeOfTheDay = Console.ReadLine();
                string outfit = "";
                string shoes = "";
                //Actions
                //
                if (gradus >=10 && gradus <=18)
                {
                //
                  if (timeOfTheDay == "Morning")
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                  else if (timeOfTheDay == "Afternoon")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (timeOfTheDay == "Evening")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                }
                //
                else if (gradus >18 && gradus <=24)
                {
                    //  
                    if (timeOfTheDay == "Morning")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (timeOfTheDay == "Afternoon")
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (timeOfTheDay == "Evening")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                }
                //

                else if (gradus >=25)
                {
                    if (timeOfTheDay == "Morning")
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (timeOfTheDay == "Afternoon")
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    else if (timeOfTheDay == "Evening")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                }


                //Output
                Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");


            }
        }
    }
}
