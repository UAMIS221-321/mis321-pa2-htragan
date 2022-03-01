namespace mis321_pa2_htragan.Interfaces
{
    public interface IAttack
    {
        public void Attack(Player playerOne, Player playerTwo, bool turnChecker, bool playerOneBoost, bool playerTwoBoost);
    }
}