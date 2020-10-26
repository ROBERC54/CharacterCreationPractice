using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CharacterCreationPractice.Initialization
{
    //Called from AreYouSure.cs
    class CharacterStatGenerator
    {
        List<string> readback;
        string characterName;
        string statSheet;
        public void Run() 
        {
            Console.Clear();
            Console.WriteLine("What is your name?");
            characterName = Console.ReadLine();
            runStatSheet();
            runTempSheet();

            readItBack();
        }
        public void runStatSheet() 
        {
            statSheet = $"{characterName} Stat Sheet.txt";
            List<string> info = new List<string>();
            info.Add("18");//Age
            info.Add(characterName);
            info.Add("328");//HP
            info.Add("20");//MP
            info.Add("100");//Stamina
            info.Add("31");//ATK
            info.Add("45");//UDF
            info.Add("49");//LDF
            info.Add("49");//SPD
            info.Add("25");//INT
            info.Add("73");//AGL
            info.Add("");//
            File.WriteAllLines(statSheet, info);
        }
        public void runTempSheet() 
        {
            string tempSheet = $"{characterName} Temp Sheet.txt";
            List<string> tempStatInfo = new List<string>();
            tempStatInfo.Add("328");//MaxHP
            tempStatInfo.Add("328");//CurrentHP
            tempStatInfo.Add("20");//MP
            tempStatInfo.Add("20");//CurrentMP
            tempStatInfo.Add("100");//Stamina
            tempStatInfo.Add("100");//CurrentStamina
            tempStatInfo.Add("");//
            File.WriteAllLines(tempSheet, tempStatInfo);
        }
        public void readItBack() 
        {
            //want to read it back?
            readback = File.ReadAllLines(statSheet).ToList();
            Console.WriteLine("Read it back");
            foreach (string line in readback)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("PAKTC");
            Console.ReadKey();

        }
    }
}
//For reference,    Vera1->102  20 30  44  48  48  24  72  EXP90   G31  ElAffin Fir Win LigSTR Thu Wat Ear DarWEA Bloodsucker ABsRate 60%
//                  Vera2->279  40 72  98  120 68  52  85  EXP248  G80  Same BluABsRate 60% Heal
//                  Vera3->1486 90 155 270 400 235 271 118 EXP2808 G975 Same BluABsRate 70% Heal