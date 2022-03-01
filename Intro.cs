using System;

namespace mis321_pa2_htragan
{
    public class Intro
    {
        public void IntroFlow(Player playerOne, Player playerTwo, ref bool turnChecker)
        {
            PlayerOne(playerOne, playerTwo);
            PlayerTwo(playerTwo, playerOne);
            Start(playerOne, playerTwo);
        }
        
        public void Start(Player playerOne, Player playerTwo)
        {
            Console.WriteLine("The Battle of Calypso's Maelstrom is about to start.");
            Console.WriteLine();
            Console.WriteLine("Player 1's name is: " + (playerOne.name) + ". Their character type is: " + (playerOne.characterType));
            Console.WriteLine("Player 2's name is: " + (playerTwo.name) + ". Their character type is: " + (playerTwo.characterType));
            Console.WriteLine();
        }

        public void PlayerOne(Player playerOne, Player playerTwo)
        {
            Console.WriteLine("Player 1,");
            playerOne.GetName();
            Console.WriteLine();
            playerOne.GetCharacterType();
            Console.WriteLine();
        }

        public void PlayerTwo(Player playerTwo, Player playerOne)
        {
            Console.WriteLine("Player 2,");
            playerTwo.GetName();
            Console.WriteLine();
            playerTwo.GetCharacterType();
            Console.WriteLine();
        }
    }
}