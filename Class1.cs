using CalculatorApp;
using System;

class Menu
{
    private Calculator calculator;

    public Menu(Calculator calculator)
    {
        this.calculator = calculator;
    }

    public bool DisplayMenu()
    {
        Console.WriteLine("Calculator Menu:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("5. Exit");
        Console.WriteLine("6 Hypotenuse");
        Console.WriteLine("Enter your choice (1-6): ");
        string choice = Console.ReadLine();

        if (choice == "5")
        {
            Console.WriteLine("Exit");
            return false;
        }

        if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "6")
        {
            DisplayError("Invalid choice. Please enter a number from 1 to 6.");
            return true;
        }

        double num1 = GetNumber("Enter the first number: ");
        double num2 = GetNumber("Enter the second number: ");
        double result = 0;

        if (choice == "1")
        {
            result = calculator.Add(num1, num2);
        }
        else if (choice == "2")
        {
            result = calculator.Subtract(num1, num2);
        }
        else if (choice == "3")
        {
            result = calculator.Multiply(num1, num2);
        }
        else if (choice == "4")
        {
            try
            {
                result = calculator.Divide(num1, num2);
            }
            catch (DivideByZeroException)
            {
                DisplayError("Cannot divide by zero.");
                return true;
            }
        }
        else if (choice == "6")
        {
            result = calculator.Hypotenuse(num1, num2); 
        }


        DisplayResult(result);
        return true;
    }

    public double GetNumber(string prompt)
    {
        Console.WriteLine(prompt);
        return double.Parse(Console.ReadLine());
    }

    public void DisplayResult(double result)
    {
        Console.WriteLine($"Result: {result}");
    }

    public void DisplayError(string message)
    {

        Console.WriteLine(message);
    }
 
}