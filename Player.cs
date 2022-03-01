using System;
using mis321_pa2_htragan.Interfaces;

namespace mis321_pa2_htragan
{
    public class Player
    {
        public string name;
        public int maxPower;
        public double health = 100;
        public double attackStrength;
        public double defensePower;
        public string characterType;
        public double damageDealt;
        public bool playerOneBoost;
        public bool playerTwoBoost;

        public IAttack attackBehavior {get; set;}
        
        public Player()
        {
            attackBehavior = new DefaultAttack();
        }

        public void SetAttackBehavior()
        {
            this.attackBehavior = attackBehavior;
        }
        
        public void GetAll(Player playerOne, Player playerTwo, ref double attackStrength, ref double defensePower)
        {
            GetMaxPower();
            GetAttackStrength(maxPower);
            GetDefenseStrength(maxPower);
        }
        
        public void GetName()
        {
            Console.WriteLine("What would you like your player's name to be?");
            this.name = Console.ReadLine();
        }
        
        public void GetMaxPower()
        {
            Random getMaxPower = new Random();
            this.maxPower = getMaxPower.Next(1,100);
        }

        public void GetAttackStrength(int maxPower)
        {
            Random getAttackStrength = new Random();
            double attackStrength = getAttackStrength.Next(1,maxPower);
            this.attackStrength = attackStrength;
        }

        public void GetDefenseStrength(int maxPower)
        {
            Random getDefenseStrength = new Random();
            double defensePower = getDefenseStrength.Next(1,maxPower);
            this.defensePower = defensePower;
        }

        public string GetCharacterType()
        {
            Console.WriteLine("Next, please choose a character type to use: \n1. Jack Sparrow \n      Primary Attack: Distract Opponent \n2. Will Turner \n      Primary Attack: Sword \n3. Davy Jones \n      Primary Attack: Cannon Fire");
            int characterSelection = int.Parse(Console.ReadLine());

            switch(characterSelection)
            {
                case 1: characterType = "Jack Sparrow";
                    break;
                case 2: characterType = "Will Turner";
                    break;
                case 3: characterType = "Davy Jones";
                    break;
                default: GetCharacterType();
                    break;
            }

            return characterType;
        }
    }
}