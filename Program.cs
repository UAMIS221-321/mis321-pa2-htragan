using System;

namespace mis321_pa2_htragan
{
    class Program
    {
        static void Main(string[] args)
        {
            double attackStrength = 0;
            double defensePower = 0;
            
            Console.WriteLine("Welcome to the 'Pirates of the Caribbean: At World's End' game!");
            Console.WriteLine();

            bool turnChecker = false;
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Intro intro = new Intro();

            intro.IntroFlow(playerOne, playerTwo, ref turnChecker);

            Gameplay newGame = new Gameplay();

            newGame.DamageBoost(playerOne, playerTwo, ref turnChecker, ref attackStrength, ref defensePower);
            newGame.TurnSwitch(playerOne, playerTwo, ref turnChecker, ref attackStrength, ref defensePower);
        }

    }
}
