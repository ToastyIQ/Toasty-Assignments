using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Code.CharacterBuilder.CharacterStats
{
    public class Stats
    {
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Dexterity { get; set; }
        public int Strength { get; set; }
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public string statsValidationMessage = "";
        public bool areValid = false;

        public Stats(int intelligence, int wisdom, int dexterity, int strength, int charisma, int constitution)
        {
            Intelligence = intelligence;
            Wisdom = wisdom;
            Dexterity = dexterity;
            Strength = strength;
            Charisma = charisma;
            Constitution = constitution;
        }

        public Stats()
        {
        }

        public void IntelligenceValidation(int intelligence)
        {
            if (intelligence < 5 || intelligence > 20)
            {
                statsValidationMessage = "Valid intelligence values are 5 - 20";
            }
            else
            {
                Intelligence = intelligence;
                areValid = true;
            }
        }
        public void WisdomValidation(int wisdom)
        {
            if (wisdom < 5 || wisdom > 20)
            {
                statsValidationMessage = "Valid wisdom values are 5 - 20";
            }
            else
            {
                Wisdom = wisdom;
                areValid = true;
            }
        }
        public void DexterityValidation(int dexterity)
        {
            if (dexterity < 1 || dexterity > 20)
            {
                statsValidationMessage = "Valid dexterity values are 1 - 20";
            }
            else
            {
                Dexterity = dexterity;
                areValid = true;
            }
        }
        public void StrengthValidation(int strength)
        {
            if (strength < 1 || strength > 20)
            {
                statsValidationMessage = "Valid strength values are 1 - 20";
            }
            else
            {
                Strength = strength;
                areValid = true;
            }
        }
        public void CharismaValidation(int charisma)
        {
            if (charisma < 0 || charisma > 20)
            {
                statsValidationMessage = "Valid charisma values are 0 - 20";
            }
            else
            {
                Charisma = charisma;
                areValid = true;
            }
        }

        public void ConstitutionValidation(int constitution)
        {
            if (constitution < 10 || constitution > 20)
            {
                statsValidationMessage = "Valid constitution values are 10 - 20";
            }
            else
            {
                Constitution = constitution;
                areValid = true;
            }
        }
        public void StatBlockValidation(int intelligence, int wisdom, int dexterity, int strength, int charisma, int constitution)
        {
            if (intelligence + wisdom + dexterity + strength + charisma + constitution != 60)
            {
                statsValidationMessage = "The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60";
            }
            else
            {
                areValid = true;
            }
        }
    }
}
