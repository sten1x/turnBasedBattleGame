namespace TurnBasedBattleGame.Models
{
    public class Warrior : Character
    {
        public Warrior()
        {
            Name = "Warrior";
            Health = 120;
            Defense = 5;
            AttackStrategy = new Strategies.MeleeAttack(13, 17);
            ImagePath = Path.Combine("Resources", "warrior.png");
        }
    }
}
