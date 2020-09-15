using calc.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace calc.UserInterface
{
    class MainUI : IUserInterfaceManager
    {

        public IUserInterfaceManager Execute()
        {
            Console.WriteLine("Welcome to Calculatron 3000!");
            Console.WriteLine("1) Add two numbers");
            Console.WriteLine("2) Subtract two numbers");
            Console.WriteLine("3) Multiply two numbers");
            Console.WriteLine("4) Divide two numbers");
            Console.WriteLine("0) Exit");

            Console.Write("> ");

            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1":
                    return new AddManager(this);
                case "2":

                    return this;
                case "3":

                    return this;
                case "4":

                    return this;
                case "0":
                    Console.WriteLine("Have a nice day!");
                    return null;


                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }
    }
}
