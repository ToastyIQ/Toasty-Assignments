using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Code
{
    public class CharacterStats
    {
        public int Intelligence { get; }
        public int Wisdom { get; }
        public int Dexterity { get; }
        public int Strength { get; }
        public int Charisma { get; }
        public int Constitution { get; }

        public CharacterStats(int intelligence, int wisdom, int dexterity, int strength, int charisma, int constitution)
        {
            var exceptions = new List<Exception>();

            if (intelligence < 5 || intelligence > 20)
            {
                exceptions.Add(new ArgumentException("Intelligence must be 5 - 20"));
            }
            else if (wisdom < 5 || wisdom > 20)
            {
                exceptions.Add(new ArgumentException("Wisdom must be 5 - 20"));
            }
            else if (dexterity < 1 || dexterity > 20)
            {
                exceptions.Add(new ArgumentException("Dexterity must be 1 - 20"));
            }
            else if (strength < 1 || strength > 20)
            {
                exceptions.Add(new ArgumentException("Strength must be 1 - 20"));
            }
            else if (charisma < 0 || charisma > 20)
            {
                exceptions.Add(new ArgumentException("Charisma must be 0 - 20"));
            }
            else if (constitution < 10 || constitution > 20)
            {
                exceptions.Add(new ArgumentException("Constitution must be 10 - 20"));
            }
            if (intelligence + wisdom + dexterity + strength + charisma + constitution != 60)
            {
                exceptions.Add(new ArgumentException("The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60"));
            }

            if (exceptions.Any())
            {
                throw new AggregateException("One or more errors have been encountered", exceptions);
            }


            Intelligence = intelligence;
            Wisdom = wisdom;
            Dexterity = dexterity;
            Strength = strength;
            Charisma = charisma;
            Constitution = constitution;
        }
    }
}
