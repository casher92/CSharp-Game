using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame
{
    public enum CharacterType
    {
        Assassin = 0,
        BlitzenBlopper = 1,
        Professor = 2,
        HorseMange = 3,
        TaxMan = 4, 
        Human = 5

    }
     class players
    {
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        public int CurrentPower { get; set; }
        public CharacterType Type { get; set; }

        public players(string name, string clanName, CharacterType type = CharacterType.HorseMange)
        {
            this.PlayerName = name;
            this.Clan = clanName;
            this.CurrentPower = 100;
            this.Type = type;
        }

        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 0:
                    return this.Type = CharacterType.Assassin;
                case 1:
                    return this.Type = CharacterType.BlitzenBlopper;
                case 2:
                    return this.Type = CharacterType.Professor;
                case 3:
                    return this.Type = CharacterType.HorseMange;
                case 4:
                    return this.Type = CharacterType.TaxMan;
                case 5:
                    return this.Type = CharacterType.Human;

                default:
                    return this.Type = CharacterType.HorseMange;
            }

    }
            public void PowerLevelCheck()
                {
                    Console.WriteLine("{0}'s power level is at {1}", this.PlayerName, this.CurrentPower);
                }

            public void BattleCry()
                {
                    Console.WriteLine("YEYEYEYEYEYEYEYEYE!!!");
                }

            public override string ToString()
        {
            return $"Player Name:{this.PlayerName}\nGamer Name: {this.Clan}\nPlayer Type: {this.Type}";
        }

                
        

        

        
    }
}
