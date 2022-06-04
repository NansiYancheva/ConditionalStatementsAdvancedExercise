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
                int daysStay = int.Parse(Console.ReadLine());
                string typeOfRoom = Console.ReadLine();
                string review = Console.ReadLine();
                //Actions
                double priceForRoomForOnePerson = (daysStay - 1) * 18;
                double priceForApartment = (daysStay - 1) * 25;
                double priceForPresidentApartment = (daysStay - 1) * 35;
                // Action 1 - discount
                if (daysStay < 10)
                {
                    priceForApartment = priceForApartment - priceForApartment * 0.30;
                    priceForPresidentApartment = priceForPresidentApartment - priceForPresidentApartment * 0.10;
                }
                else if (daysStay >= 10 && daysStay <= 15)
                {
                    priceForApartment = priceForApartment - priceForApartment * 0.35;
                    priceForPresidentApartment = priceForPresidentApartment - priceForPresidentApartment * 0.15;
                }
                else
                {
                    priceForApartment = priceForApartment - priceForApartment * 0.50;
                    priceForPresidentApartment = priceForPresidentApartment - priceForPresidentApartment * 0.20;
                }
                //Actions 2 review
                switch (review)
                {
                    case "positive":
                        priceForRoomForOnePerson = priceForRoomForOnePerson + priceForRoomForOnePerson * 0.25;
                            priceForApartment = priceForApartment + (priceForApartment * 0.25);
                            priceForPresidentApartment = priceForPresidentApartment + (priceForPresidentApartment * 0.25);
                        break;

                    case "negative":
                        priceForRoomForOnePerson = priceForRoomForOnePerson - priceForRoomForOnePerson * 0.10;
                            priceForApartment = priceForApartment  - priceForApartment * 0.10;
                            priceForPresidentApartment = priceForPresidentApartment - priceForPresidentApartment * 0.10;
                        break;
                }
                //Output
                if (typeOfRoom == "room for one person")
                        Console.WriteLine($"{priceForRoomForOnePerson:f2}");
                else if (typeOfRoom == "apartment")
                    Console.WriteLine($"{priceForApartment:f2}");
                else if (typeOfRoom == "president apartment")
                    Console.WriteLine($"{priceForPresidentApartment:f2}");
            }
        }
    }
}
