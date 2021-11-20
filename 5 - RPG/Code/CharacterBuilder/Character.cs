using RPG.Code.CharacterBuilder;

namespace RPG.Code
{
    public class Character
    {
        public CharacterAttributes Attributes { get; set; }
        public CharacterStats Stats { get; set; }

        public Character(CharacterAttributes attributes, CharacterStats stats)
        {
            Attributes = attributes;
            Stats = stats;
        }

    }   
}
