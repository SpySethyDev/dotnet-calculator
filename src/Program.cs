using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            double finishNum;
            string operation;
            string[] operations = 
            {
                "Addition",
                "Subtraction",
                "Multiplication",
                "Division"
            };

            Console.Title = "Calculator";

            Console.Write("Input a number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input another number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pick an operation:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("["+ i + "] " + operations[i]);
            }
            operation = Console.ReadLine();

            if (operation == "0"){
                finishNum = number1 + number2;
                Console.WriteLine("The finished number is: " + finishNum);
                Console.ReadKey();
            }
            else if (operation == "1"){
                finishNum = number1 - number2;
                Console.WriteLine("The finished number is: " + finishNum);
                Console.ReadKey();
            }
            else if (operation == "2"){
                finishNum = number1 * number2;
                Console.WriteLine("The finished number is: " + finishNum);
                Console.ReadKey();
            }
            else if (operation == "3"){
                finishNum = number1 / number2;
                Console.WriteLine("The finished number is: " + finishNum);
                Console.ReadKey();
            }
            else{
                Console.WriteLine("That is not one of the above");
                Console.ReadKey();
            }
        }
    }
}
