
namespace RPG.Code
{
    public class Character
    {
        public string CharacterName { get; }
        public CharacterAttributes Attributes { get; }
        public CharacterStats Stats { get; private set; }
        

        public Character(string characterName, CharacterAttributes attributes, CharacterStats stats)
        {
            CharacterName = characterName;
            Attributes = attributes;
            Stats = stats;
        }

        public void RespecCharacter(CharacterStats stats)
        {
            Stats = stats;
        }

    }   
}
