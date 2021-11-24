
namespace RPG.Code
{
    public class Character
    {
        public CharacterAttributes Attributes { get; }
        public CharacterStats Stats { get; set; }

        public Character(CharacterAttributes attributes, CharacterStats stats)
        {
            Attributes = attributes;
            Stats = stats;
        }

        public Character RespecCharacter(Character character, int intelligence, int wisdom, int dexterity, int strength, int charisma, int constitution)
        {
            character.Stats = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);
            return character;
        }

    }   
}
