
namespace RPG.Code
{
    public class Character
    {
        public CharacterAttributes Attributes { get; }
        public CharacterStats Stats { get; private set; }

        public Character(CharacterAttributes attributes, CharacterStats stats)
        {
            Attributes = attributes;
            Stats = stats;
        }

        public void RespecCharacter(CharacterStats stats)
        {
            Stats = stats;
        }

    }   
}
