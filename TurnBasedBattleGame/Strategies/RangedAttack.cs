namespace TurnBasedBattleGame.Strategies
{
    public class RangedAttack : IAttackStrategy
    {
        private readonly int _minDamage;
        private readonly int _maxDamage;
        public int Range => 3;

        private static readonly Random random = new Random();

        public RangedAttack(int minDamage, int maxDamage)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }

        public bool Attack(Models.Character attacker, Models.Character target)
        {
            if (attacker.DistanceTo(target) <= Range)
            {
                int damage = random.Next(_minDamage, _maxDamage + 1);
                int finalDamage = damage - target.GetDefenseReduction();
                target.Health -= Math.Max(finalDamage, 0);
                return true;
            }
            return false;
        }
    }
}
