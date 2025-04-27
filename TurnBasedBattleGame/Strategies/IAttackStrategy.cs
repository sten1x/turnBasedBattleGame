namespace TurnBasedBattleGame.Strategies
{
    public interface IAttackStrategy
    {
        bool Attack(Models.Character attacker, Models.Character target);
        int Range { get; }
    }
}
