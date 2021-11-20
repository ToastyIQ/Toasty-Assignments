using System;

namespace RPG.Code
{
    public class CharacterStats
    {
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Dexterity { get; set; }
        public int Strength { get; set; }
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        
        public CharacterStats(int intelligence, int wisdom, int dexterity, int strength, int charisma, int constitution)
        {
            Intelligence = intelligence;
            Wisdom = wisdom;
            Dexterity = dexterity;
            Strength = strength;
            Charisma = charisma;
            Constitution = constitution;
        }
    }
}
