using calc.Interface;
using calc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace calc.UserInterface
{
    class AddManager : IUserInterfaceManager
    {
        private IUserInterfaceManager _parentUi;
        public AddManager(IUserInterfaceManager parentUi)
        {
            _parentUi = parentUi;
        }
        public IUserInterfaceManager Execute()
        {

            
            Console.Write("Please Enter The First Number: ");
            string userFirstNumber = Console.ReadLine();
            double firstNumber = 0;
            try
            {
                firstNumber = double.Parse(userFirstNumber);
            }
            catch
            {
                Console.WriteLine("Invalid number");
                return this;
            }
            Console.WriteLine();
            Console.Write("Please Enter The Second Number: ");
            string userSecondNumber = Console.ReadLine();
            double secondNumber = 0;
            try
            {
                 secondNumber = double.Parse(userSecondNumber);
            }
            catch
            {
                Console.WriteLine("Invalid number");
                return this;
            }
            Console.WriteLine();

            Add userNum = new Add
            {
                numberOne = firstNumber,
                numberTwo = secondNumber
            };

            Console.WriteLine($"The result of adding {userNum.numberOne} and {userNum.numberTwo} is {userNum.AddNumbers()}");
            Console.WriteLine();

            return _parentUi;







        }
    }
}
