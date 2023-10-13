using System;
using System.Security.Policy;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Menu menu = new Menu(calculator);

            while (menu.DisplayMenu())
            {
                
            }
        }
    }
}