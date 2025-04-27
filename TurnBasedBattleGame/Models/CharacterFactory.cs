namespace TurnBasedBattleGame.Models
{
    public static class CharacterFactory
    {
        public static Character CreateCharacter(CharacterType type, int x, int y)
        {
            Character character = type switch
            {
                CharacterType.Warrior => new Warrior(),
                CharacterType.Archer => new Archer(),
                CharacterType.Mage => new Mage(),
                _ => throw new ArgumentException("Unknown character type")
            };

            character.X = x;
            character.Y = y;
            return character;
        }
    }
}
