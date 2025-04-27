using TurnBasedBattleGame.Strategies;

namespace TurnBasedBattleGame.Models
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string ImagePath { get; protected set; }
        public IAttackStrategy AttackStrategy { get; set; }
        public HealingSpell HealingAbility { get; set; }

        public bool Attack(Character target)
        {
            return AttackStrategy.Attack(this, target);
        }

        public bool Heal(Character ally)
        {
            return HealingAbility != null && HealingAbility.Attack(this, ally);
        }

        public int DistanceTo(Character target)
        {
            return Math.Abs(X - target.X) + Math.Abs(Y - target.Y);
        }

        public int GetDefenseReduction()
        {
            return Defense;
        }
    }
}
