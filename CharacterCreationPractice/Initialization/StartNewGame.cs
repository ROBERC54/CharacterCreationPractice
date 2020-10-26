﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreationPractice.Initialization
{
    //Called from Main_Menu.cs
    public class StartNewGame
    {//From the MainMenu screen, functionality results from whether the User selects "Play Game", "Resume", "How to", or "Quit."
     //This class will handle the case of "Play Game" when called from within Main_Menu.cs
     //The class functions to start the game off and introduce the character.  It should save progress by the end of the sequence and pass to "Resume.cs"
        public void Run() 
        {
            Console.WriteLine("Yo from SNG().Run();");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            new AreYouSure().Run();
            Console.WriteLine("Yo from SNG().Run();");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
