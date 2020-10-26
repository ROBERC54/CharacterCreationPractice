using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreationPractice.Initialization
{
    //Called from StartNewGame.cs
    class AreYouSure
    {
        public void Run() 
        {
            bool quit;
            do
            {
                Console.Clear();
                Console.WriteLine("Starting a new game will lose all your progress...\n");
                Console.WriteLine("Are you sure you wish to continue?");
                Console.WriteLine("\n                       - (Y)ES -                \n");
                Console.WriteLine("\n                        - (N)O -                \n");
                var key = continueSelect();
                quit = UserChoice(key);
            } while (!quit);
        }
        private ConsoleKey continueSelect() 
        {
            return Console.ReadKey().Key;
        }
        public bool UserChoice(ConsoleKey key)
        {
            switch(key)
            {
                case ConsoleKey.Y:  //continue
                    Console.WriteLine("Yes?");//currently returns to main menu
                    return true;
                    break;

                case ConsoleKey.N:
                    Console.WriteLine("No?  Returning to main menu...");
                    return true;
                    break;
            }
            return false;//handles keys other than valid options
        }
        public void Continue() { }
    }
}
