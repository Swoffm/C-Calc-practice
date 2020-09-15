using calc.Interface;
using calc.UserInterface;
using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInterfaceManager userInterface = new MainUI();

            while(userInterface != null)
            {
               userInterface = userInterface.Execute();
            }
        }
    }
}
