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
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                char operaton = char.Parse(Console.ReadLine());
                double result = 0;
                //Actions
                switch (operaton)
                {
                    case '+':
                        result = number1 + number2;
                        break;
                    case '-':
                        result = number1 - number2;
                        break;
                    case '*':
                        result = number1 * number2;
                        break;
                    case '/':
                        result = (double) number1 / number2;
                        break;
                    case '%':
                        result = (double) number1 % number2;
                        break;
                }



                //Output
                if (operaton == '/')
                {
                    if (number2 == 0)
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    else
                    Console.WriteLine($"{number1} / {number2} = {result:f2}");
                }  
                

                else if (operaton == '+' || operaton == '-' || operaton == '*')
                {
                    if (result % 2 == 0)
                        Console.WriteLine($"{number1} {operaton} {number2} = {result} - even");
                    else
                        Console.WriteLine($"{number1} {operaton} {number2} = {result} - odd");
                }


                else if (operaton == '%')
                {
                    if (number2 == 0)
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    else
                        Console.WriteLine($"{number1} % {number2} = {result}");
                }

            }
        }
    }
}