﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreationPractice
{
    //Called from Program.cs
    class APP
    {
        public void Run()
        {
            Console.WriteLine("Yo from the APP");
            new Main_Menu().Run();
            Console.Clear();
            Console.WriteLine("Yo from the APP");
        }
    }
}
