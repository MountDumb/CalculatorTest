using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Logic;

namespace Calculator.ConsoleApp

    
{   
    public class Program
    {
        delegate decimal FuncDelegator(decimal num1, decimal num2);
        FuncDelegator fd;

        static void Main(string[] args)
        {

            Program p = new Program();
            p.Menu();
        }

        decimal Calculator(string choice, decimal num1, decimal num2)
        {
            Functions func = new Functions();

            switch (choice)
            {
                case "a":
                    fd = new FuncDelegator(func.Add);
                    break;

                case "s":
                    fd = new FuncDelegator(func.Subtract);
                    break;
                default:
                    Menu();
                    break;
            }
            return fd(num1, num2);
        }

        void Menu()
        {
            
            

            Console.WriteLine("(A)dd" +
                                Environment.NewLine +
                                "(S)ubtract" +
                                Environment.NewLine +
                                "(Q)uit"
                             );
            string choice = Console.ReadLine().ToLower();

            if (choice == "q")
            {
                Environment.Exit(0);
            }

            Console.WriteLine("First number, please");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Second number, please");
            decimal secondNum = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Calculator(choice, firstNum, secondNum));
            Console.ReadLine();
            Menu();

        }

    }
}
