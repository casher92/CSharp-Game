using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame
{
    class NewEnemy : Enemy
   {
        Dictionary<string, int> Attacks = new Dictionary<string, int> { { "Fire-Punch", 5 }, { "Spear", 15 }, { "Satans-Wrath", 35 } };

        public NewEnemy()
        {
            this.PowerLevel = 40;
            this.EnemyName = "Diablo";

        }
        public override void BattleInsult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("I am {0} you {1}", this.EnemyName, insult[r]);
        }

        public void DiabloAttack(players player)
        {
            Attack(player, Attacks, this.EnemyName);
        }

       
    }
}
