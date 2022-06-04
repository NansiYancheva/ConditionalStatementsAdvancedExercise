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
                int hourOfExam = int.Parse(Console.ReadLine());
                int minuteOfExam = int.Parse(Console.ReadLine());
                int hourOfArrival = int.Parse(Console.ReadLine());
                int minuteOfArrival = int.Parse(Console.ReadLine());

                //Actions
                double examTimeInMinutes = (hourOfExam * 60) + minuteOfExam;
                double arrivalTimeInMinutes = (hourOfArrival * 60) + minuteOfArrival;
                double difference = Math.Abs(examTimeInMinutes - arrivalTimeInMinutes);
                double hoursDifference = 0;
                double minutesDifference = 0;
               

                //Actions 2
                ////////////////////////////////////////////////////////////////
                //Late
                if (examTimeInMinutes < arrivalTimeInMinutes)
                {
                    if (arrivalTimeInMinutes - examTimeInMinutes >= 60)
                    {
                        hoursDifference = Math.Truncate(difference / 60);
                        minutesDifference = Math.Abs(difference % 60);
                        Console.WriteLine("Late");
                        if (minutesDifference < 10)
                            Console.WriteLine($"{hoursDifference}:0{minutesDifference} hours after the start");
                        else
                            Console.WriteLine($"{hoursDifference}:{minutesDifference} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{difference} minutes after the start");
                    }
                }
                /////////////////////////////////////////////////////////////
                // On time & Early
                else if (examTimeInMinutes >= arrivalTimeInMinutes)
                {
                    if (examTimeInMinutes == arrivalTimeInMinutes)
                        Console.WriteLine("On time");
                    else if (examTimeInMinutes - arrivalTimeInMinutes <= 30)
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine($"{difference} minutes before the start");
                    }
                    else
                    {
                        if (examTimeInMinutes - arrivalTimeInMinutes >= 60)
                        {
                            hoursDifference = Math.Truncate(difference / 60);
                            minutesDifference = Math.Abs(difference % 60);
                            Console.WriteLine("Early");
                            if (minutesDifference < 10)
                                Console.WriteLine($"{hoursDifference}:0{minutesDifference} hours before the start");
                            else
                                Console.WriteLine($"{hoursDifference}:{minutesDifference} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine("Early");
                            Console.WriteLine($"{difference} minutes before the start");
                        }
                    }
                }
                //Output
            }
        }
    }
}