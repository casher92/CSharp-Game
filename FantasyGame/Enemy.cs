using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame
{
   abstract class Enemy
    {   //array list
        protected ArrayList insult = new ArrayList { "buck-o", "wimp", "window licker", "noob", "nerd cake", "buster" };
        protected Random rnd = new Random();// how to set up a random pick 
        public string EnemyName { get; set; }
        public int PowerLevel { get; set; }
        

        public virtual void BattleInsult()
        { 
            int r = rnd.Next(0, insult.Count); 


            Console.WriteLine("You're on the wrong side of the forest {0}", insult[r]);

        }

        public void Attack(players p, Dictionary<string, int> dict, Object enemyName)
        {
           
            
             var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("Enemy is attacking with {0} and deals {1}", attackName, attackVal);
             p.CurrentPower -= attackVal;
            Console.WriteLine("{0} power is at {1}%", p.PlayerName, p.CurrentPower);
           
        }
    }

}
