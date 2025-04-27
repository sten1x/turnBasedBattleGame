namespace TurnBasedBattleGame.Models
{
    public class Archer : Character
    {
        public Archer()
        {
            Name = "Archer";
            Health = 80;
            Defense = 2;
            AttackStrategy = new Strategies.RangedAttack(8, 12);
            ImagePath = Path.Combine("Resources", "archer.png");
        }
    }
}
