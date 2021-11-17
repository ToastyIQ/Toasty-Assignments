using RPG.Code.CharacterBuilder.CharacterAttributes;
using RPG.Code.CharacterBuilder.CharacterStats;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Code.CharacterBuilder
{
    public class Character
    {
        public Attributes Attributes { get; set; }
        public Stats Stats { get; set; }
        public bool CharacterIsValid { get { return DetermineIfValid(); } }

        public string attributeValidationMessage { get; private set; }
        public string statsValidationMessage { get; private set; }

        public string validationMessage = "";
        public Character(Attributes attributes, Stats stats)
        {
            Attributes = attributes;
            Stats = stats;
        }

        public Character()
        {
            Attributes = new Attributes();
            Stats = new Stats();
        }
        public bool DetermineIfValid()
        {
            if (Attributes.areValid == false)
            {
                validationMessage = attributeValidationMessage;
                return false;
            }
            else if (Stats.areValid == false)
            {
                validationMessage = statsValidationMessage;
                return false;
            }
            else
            {
                validationMessage = "Character Created";
                return true;
            }
        }
    }   
}
