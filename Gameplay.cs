using System;

namespace mis321_pa2_htragan
{
    public class Gameplay
    {
        double roundCounter = 0;
        public bool playerOneBoost;
        public bool playerTwoBoost;
        
        public void TurnSwitch(Player playerOne, Player playerTwo, ref bool turnChecker, ref double attackStrength, ref double defensePower)
        {
            while(playerOne.health >= 1 && playerTwo.health >= 1)
            {
                FirstTurn(playerOne, playerTwo, ref turnChecker);
                
                playerOne.GetAll(playerOne, playerTwo, ref attackStrength, ref defensePower);
                playerTwo.GetAll(playerOne, playerTwo, ref attackStrength, ref defensePower);

                PlayerOneDamage(playerOne, playerTwo, ref attackStrength, ref defensePower);
                PlayerTwoDamage(playerOne, playerTwo, attackStrength, defensePower);

                roundCounter++;
                Console.WriteLine("------ Round: " + (roundCounter) + " ------");
                
                playerOne.attackBehavior.Attack(playerOne, playerTwo, turnChecker, playerOneBoost, playerTwoBoost);
            }

            if(playerOne.health <= 0)
            {
                Console.WriteLine("Congratulations, " + (playerTwo.name) + " has won the Battle of Calypso's Maelstrom!");
            }
            if(playerTwo.health <= 0)
            {
                Console.WriteLine("Congratulations, " + (playerOne.name) + " has won the Battle of Calypso's Maelstrom!");
            }
        }
        public void FirstTurn(Player playerOne, Player playerTwo, ref bool turnChecker)
        {
            Random turnDecider = new Random();
            int whoGoesFirst = turnDecider.Next(2);

            if(whoGoesFirst == 0)
            {
                turnChecker = false;
            }
            if(whoGoesFirst == 1)
            {
                turnChecker = true;
            }
        }

        public void PlayerOneDamage(Player playerOne, Player playerTwo, ref double attackStrength, ref double defensePower)
        {
            if(playerOne.characterType == "Jack Sparrow" && playerTwo.characterType == "Will Turner")
            {
                playerOneBoost = true;
            }
            else if(playerOne.characterType == "Will Turner" && playerTwo.characterType == "Davy Jones")
            {
                playerOneBoost = true;
            }
            else if(playerOne.characterType == "Davy Jones" && playerTwo.characterType == "Jack Sparrow")
            {
                playerOneBoost = true;
            }
        }

        public void PlayerTwoDamage(Player playerOne, Player playerTwo, double attackStrength, double defensePower)
        {
            if(playerTwo.characterType == "Jack Sparrow" && playerOne.characterType == "Will Turner")
            {
                playerTwoBoost = true;
            }
            else if(playerTwo.characterType == "Will Turner" && playerOne.characterType == "Davy Jones")
            {
                playerTwoBoost = true;
            }
            else if(playerTwo.characterType == "Davy Jones" && playerOne.characterType == "Jack Sparrow")
            {
                playerTwoBoost = true;
            }
        }

        public void DamageBoost(Player playerOne, Player playerTwo, ref bool turnChecker, ref double attackStrength, ref double defensePower)
        {
            PlayerOneDamage(playerOne, playerTwo, ref attackStrength, ref defensePower);
            PlayerTwoDamage(playerOne, playerTwo, attackStrength, defensePower);

            if(playerOneBoost == true)
            {
                Console.WriteLine((playerOne.name) + "'s character type: '" + (playerOne.characterType) + "' has an advantage over '" + (playerTwo.characterType) + "', giving them a 20% damage boost on their dealt damage.");
                Console.WriteLine();
            }
            if(playerTwoBoost == true)
            {
                Console.WriteLine((playerTwo.name) + "'s character type: '" + (playerTwo.characterType) + "' has an advantage over '" + (playerOne.characterType) + "', giving them a 20% damage boost on their dealt damage.");
                Console.WriteLine();
            }
        }
    }
}