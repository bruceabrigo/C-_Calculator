using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Calcuator!");

            // Prompt user to inter first number
            Console.WriteLine("Enter the first nunmber.");
            // get first number input
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Prompt user to enter operand
            Console.WriteLine("Please enter operand: +, -, *, /");
            // get operand
            char operand = Convert.ToChar(Console.ReadLine());

            // Prompt user to enter second number
            Console.WriteLine("Enter the second number.");
            // get second number input
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Create default result to 0
            double result = 0;

            // create switch case

            switch (operand) {
                case '+':
                    // call function and pass in num1 and num2 params
                    result = Add(num1, num2);
                    break;
                case '-':
                    result = Subtract(num1, num2);
                    break;
                case '*':
                    result = Multiply(num1, num2);
                    break;
                case '/':
                    result = Divide(num1, num2);
                    break;
                // default will return false operand
                default:
                    Console.WriteLine("Operand incorrect");
                    break;

            }

            Console.WriteLine("Result: " + result);
            
            // get user input to close app
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }
        // define methods for each operand
        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
