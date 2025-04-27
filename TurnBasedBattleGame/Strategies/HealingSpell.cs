namespace TurnBasedBattleGame.Strategies
{
    public class HealingSpell : IAttackStrategy
    {
        private readonly int _minHeal;
        private readonly int _maxHeal;
        public int Range => 2;

        private static readonly Random random = new Random();

        public HealingSpell(int minHeal, int maxHeal)
        {
            _minHeal = minHeal;
            _maxHeal = maxHeal;
        }

        public bool Attack(Models.Character healer, Models.Character ally)
        {
            if (healer.DistanceTo(ally) <= Range)
            {
                int healAmount = random.Next(_minHeal, _maxHeal + 1);
                ally.Health += healAmount;
                return true;
            }
            return false;
        }
    }
}
