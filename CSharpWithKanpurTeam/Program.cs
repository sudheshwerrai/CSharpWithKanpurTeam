using System;
using System.Runtime.InteropServices;

namespace Calculation
{
    enum UserInput
    {
        Add = 1, Substract, Multiplication, Division
    }
    class Program
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            int result = 0;
            try
            {
                result = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public static void Main(string[] args)
        {
            UserInput userChoice = 0;
            int firstNumber = 0, secondNumber = 0, counter = 0, userInput = 0;
            bool IsFirstValid = false, IsSecondValid = false, IsUserInputValid = false;
        FreshStart:
            Console.WriteLine("what do you want to perform");
            Console.WriteLine("Enter 1 for add ,2 for sub, 3 for multiply and 4 for div");

            IsUserInputValid = int.TryParse(Console.ReadLine(),out userInput);
            userChoice = (UserInput)userInput;
        GetNumberAgain:
            if (IsUserInputValid == false)
            {
                if (counter < 3)
                {
                    counter++;
                    Console.WriteLine("You have entered wrong choice.Please try again");
                    goto FreshStart;
                }
                else
                {
                    Console.WriteLine("You have exceed limit. Try after some time");
                    return;
                    
                }                                       
            }
            else 
            {
                Console.WriteLine("please enter the first number");
                IsFirstValid = int.TryParse(Console.ReadLine(), out firstNumber);
                Console.WriteLine("please enter the second number");
                IsSecondValid = int.TryParse(Console.ReadLine(), out secondNumber);
            }
           
            if (IsFirstValid && IsSecondValid && IsUserInputValid)
            {
                switch (userChoice)
                {
                    case UserInput.Add:
                        Console.WriteLine("The Add result is:" + Addition(firstNumber, secondNumber));
                        break;

                    case UserInput.Substract:
                        Console.WriteLine("The Substract result is:" + Subtraction(firstNumber, secondNumber));
                        break;

                    case UserInput.Multiplication:
                        Console.WriteLine("The Multiplication result is:" + Multiplication(firstNumber, secondNumber));
                        break;

                    case UserInput.Division:
                        Console.WriteLine("The Division result is:" + Division(firstNumber, secondNumber));
                        break;

                    default:
                        Console.WriteLine("Wrong selection");
                       
                        break;
                }
            }
            else
            {
                if (counter < 3)
                {
                    if(!IsFirstValid)
                        Console.WriteLine("You have not entered the correct value in first number");
                    else if(!IsSecondValid)
                        Console.WriteLine("You have not entered the correct value in second number");
                    goto GetNumberAgain;
                }
                Console.WriteLine("You have not entered the correct value in first numbe ror second number");
            }


            Console.ReadKey();
        }
    }

}