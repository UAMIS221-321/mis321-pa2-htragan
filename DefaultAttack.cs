using System;
using mis321_pa2_htragan.Interfaces;

namespace mis321_pa2_htragan
{
    public class DefaultAttack : IAttack
    {
        public void Attack(Player playerOne, Player playerTwo, bool turnChecker, bool playerOneBoost, bool playerTwoBoost)
        {
            if(turnChecker == false)
            {    
                playerOne.damageDealt = playerOne.attackStrength - playerTwo.defensePower;
    
                if(playerOne.damageDealt <= 0)
                {
                    playerOne.damageDealt = 1;
                }

                if(playerOneBoost == true)
                {
                    playerOne.damageDealt = playerOne.damageDealt * 1.2;
                    playerOne.damageDealt = Math.Round(playerOne.damageDealt, 0, MidpointRounding.AwayFromZero);
                }


                Console.WriteLine((playerOne.name) + " attacked with " + (playerOne.attackStrength) + " power.");
                Console.WriteLine((playerTwo.name) + " used " + (playerTwo.defensePower) + " defensive power. This means " + (playerOne.name) + " did " + (playerOne.damageDealt) + " damage.");
                playerTwo.health = playerTwo.health - playerOne.damageDealt;
                Console.WriteLine((playerTwo.name) + " now has " + (playerTwo.health) + " health.");
                Console.WriteLine();

                playerTwo.damageDealt = playerTwo.attackStrength - playerOne.defensePower;

                if(playerTwo.damageDealt <= 0)
                {
                    playerTwo.damageDealt = 1;
                }

                if(playerTwoBoost == true)
                {
                    playerTwo.damageDealt = playerTwo.damageDealt * 1.2;
                    playerTwo.damageDealt = Math.Round(playerTwo.damageDealt, 0, MidpointRounding.AwayFromZero);
                }

                Console.WriteLine((playerTwo.name) + " attacked with " + (playerTwo.attackStrength) + " power.");
                Console.WriteLine((playerOne.name) + " used " + (playerOne.defensePower) + " defensive power. This means " + (playerTwo.name) + " did " + (playerTwo.damageDealt) + " damage.");
                playerOne.health = playerOne.health - playerTwo.damageDealt;
                Console.WriteLine((playerOne.name) + " now has " + (playerOne.health) + " health.");
                Console.WriteLine();
            }
            if(turnChecker == true)
            {
                playerTwo.damageDealt = playerTwo.attackStrength - playerOne.defensePower;

                if(playerTwo.damageDealt <= 0)
                {
                    playerTwo.damageDealt = 1;
                }

                if(playerTwoBoost == true)
                {
                    playerTwo.damageDealt = playerTwo.damageDealt * 1.2;
                    playerTwo.damageDealt = Math.Round(playerTwo.damageDealt, 0, MidpointRounding.AwayFromZero);
                }

                Console.WriteLine((playerTwo.name) + " attacked with " + (playerTwo.attackStrength) + " power.");
                Console.WriteLine((playerOne.name) + " used " + (playerOne.defensePower) + " defensive power. This means " + (playerTwo.name) + " did " + (playerTwo.damageDealt) + " damage.");
                playerOne.health = playerOne.health - playerTwo.damageDealt;
                Console.WriteLine((playerOne.name) + " now has " + (playerOne.health) + " health.");
                Console.WriteLine();

                playerOne.damageDealt = playerOne.attackStrength - playerTwo.defensePower;

                if(playerOne.damageDealt <= 0)
                {
                    playerOne.damageDealt = 1;
                }

                if(playerOneBoost == true)
                {
                    playerOne.damageDealt = playerOne.damageDealt * 1.2;
                    playerOne.damageDealt = Math.Round(playerOne.damageDealt, 0, MidpointRounding.AwayFromZero);
                }

                Console.WriteLine((playerOne.name) + " attacked with " + (playerOne.attackStrength) + " power.");
                Console.WriteLine((playerTwo.name) + " used " + (playerTwo.defensePower) + " defensive power. This means " + (playerOne.name) + " did " + (playerOne.damageDealt) + " damage.");
                playerTwo.health = playerTwo.health - playerOne.damageDealt;
                Console.WriteLine((playerTwo.name) + " now has " + (playerTwo.health) + " health.");
                Console.WriteLine();
            }

        }
    }
}