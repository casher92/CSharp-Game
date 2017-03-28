using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // SpeechSynthesizer talkingConsole = new SpeechSynthesizer(); //Speech within visual studio
            // talkingConsole.Speak("What is your name");
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("What is your clan name");
            string clan = Console.ReadLine();
            Console.WriteLine("What is your player type?\n" +
                "0: Assassin\n " +
                "1: Blitzen Blopper\n" +
                "2: Professor\n" +
                "3: Horse Mange\n" +
                "4: Tax Man\n" +
                "5: Human");
            int playerType = int.Parse(Console.ReadLine());

            players player = new players(name, clan);
            player.ChooseType(playerType);

             Console.WriteLine(player.ToString());

           
            NewEnemy diablo = new NewEnemy();

            
            
           
            while (true)
            {
                diablo.BattleInsult();
                Console.WriteLine("Do you want to fight?");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "y")
                {
                    diablo.DiabloAttack(player);
                    if (player.CurrentPower <= 0)
                    {
                        Console.WriteLine("Oh you ded");
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(player.CurrentPower);
            
            Console.WriteLine(player.CurrentPower);
            Console.WriteLine("This is a new attack");

            diablo.DiabloAttack(player);
            Console.WriteLine(player.CurrentPower);

            

           

            Console.ReadLine();


            
           
        }    
       
    }
}
