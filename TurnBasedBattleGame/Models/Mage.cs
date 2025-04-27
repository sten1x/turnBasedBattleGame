namespace TurnBasedBattleGame.Models
{
    public class Mage : Character
    {
        public Mage()
        {
            Name = "Mage";
            Health = 70;
            Defense = 1;
            AttackStrategy = new Strategies.MagicAttack(18, 22);
            HealingAbility = new Strategies.HealingSpell(18, 22);
            ImagePath = Path.Combine("Resources", "mage.png");
        }
    }
}
