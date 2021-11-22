using RPG.Code.CharacterBuilder.Enums;
using System;

namespace RPG.Code
{
    public class Builder
    {
        public int HeadRoundness { get; set; }
        public string FitnessLevel { get; set; }
        public int HeightInInches { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Dexterity { get; set; }
        public int Strength { get; set; }
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public bool IsCreated { get; set; }

        public CharacterAttributes CreateAttributes(int headRoundness, string fitnessLevel, int heightInInches)
        {
            if (headRoundness > 100 || headRoundness < 0)
            {
                throw new ArgumentException("Head Roundness must be a value of 0 - 100");
            }
            else if (!Enum.IsDefined(typeof(FitnessLevels), fitnessLevel))
            {
                throw new ArgumentException("This is not a valid fitness level.");
            }
            else if (heightInInches < 0)
            {
                throw new ArgumentException("Height must be a postive number");
            }
            CharacterAttributes newAttributes = new CharacterAttributes(headRoundness, fitnessLevel, heightInInches);
            return newAttributes;
        }

        public CharacterStats CreateStats(int intelligence, int wisdom, int dexterity, int strength, int charisma, int constitution)
        {
            if (intelligence < 5 || intelligence > 20)
            {
                throw new ArgumentException("Intelligence must be 5 - 20");
            }
            if (wisdom < 5 || wisdom > 20)
            {
                throw new ArgumentException("Wisdom must be 5 - 20");
            }
            if (dexterity < 1 || dexterity > 20)
            {
                throw new ArgumentException("Dexterity must be 1 - 20");
            }
            if (strength < 1 || strength > 20)
            {
                throw new ArgumentException("Strength must be 1 - 20");
            }
            if (charisma < 0 || charisma > 20)
            {
                throw new ArgumentException("Charisma must be 0 - 20");
            }
            if (constitution < 10 || constitution > 20)
            {
                throw new ArgumentException("Constitution must be 10 - 20");
            }
            if (intelligence + wisdom + dexterity + strength + charisma + constitution != 60)
            {
                throw new ArgumentException("The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60");
            }
            CharacterStats newStats = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);
            return newStats;
        }

        public Character CreateCharacter(CharacterAttributes newAttributes, CharacterStats newStats)
        {
            Character newCharacter = new Character(newAttributes, newStats);
            return newCharacter;
        }

    }
}
 
    // Just keeping this in to show how this changed, because it changed a lot 
    //
    //    public CharacterAttributes CreateCharacterAttributes(int headRoundness, string fitnessLevel, int heightInInches, bool isValid)
    //    {
    //        if (CharacterAttributeValidation(headRoundness, fitnessLevel, heightInInches, isValid: true)
    //        {
    //            CharacterAttributes newAttributes = new CharacterAttributes(headRoundness, fitnessLevel, heightInInches, isValid);                
    //            return newAttributes;
    //        }
    //        else
    //        {
    //            return attributeValidationMessage;
    //        }
    //    }

    //    public CharacterStats CreateCharacterStats(int intelligence, int wisdom, int dexterity, int strength, int charisma, int constitution)
    //    {
    //        if (CharacterStatValidation(intelligence, wisdom, dexterity, strength, charisma, constitution).isValid)
    //        {
    //            CharacterStats newStats = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);                
    //            return newStats;
    //        }
    //        else
    //        {
    //            return statValidationMessage;
    //        }
    //    }

    //    public CharacterValidation CharacterAttributeValidation(int headRoundness, string fitnessLevel, int heightInInches, bool isValid)
    //    {
    //        var validator = new CharacterValidation();
    //        validator.HeadRoundnessValidation(headRoundness);
    //        validator.FitnessLevelValidation(fitnessLevel);
    //        validator.HeightValidation(heightInInches);
    //    }

    //    public CharacterValidation CharacterStatValidation(int intelligence, int wisdom, int dexterity, int strength, int charisma, int constitution)
    //    {
    //        var validator = new CharacterValidation();
    //        validator.IntelligenceValidation(intelligence);
    //        validator.WisdomValidation(wisdom);
    //        validator.DexterityValidation(dexterity);
    //        validator.StrengthValidation(strength);
    //        validator.CharismaValidation(charisma);
    //        validator.ConstitutionValidation(constitution);
    //        validator.ConstitutionValidation(intelligence + wisdom + dexterity + strength + charisma + constitution);
    //    }
    //}

//	* The character builder requires the following character body attributes set before moving to the next step
//***Character Builder Step 1 - Attributes**
//			* Head Roundness
//				* Support values are very round (100%) to not round at all (0%)
//			*Fitness Level
//			   * Supported values are "extremely fit", "very fit", "somewhat fit", "not fit", "far from fit"
//			* Height
//				* Needs to be in inches and feet and needs to be supported like "5'11" or "5"
//		* The character builder should not create a character that does not have the required attributes set
//	* After the required character body attributes are set, the character builder now requires the characters ability points to be set
//		* **Character Builder Step 2 - Ability Points**
//			* Intelligence
//				* Supported values 5 to 20
//			* Wisdom
//				* Supported values are 5 to 20
//			* Dexterity
//				* Supported values are 1 to 20
//			* Strength
//				* Supported values are 1 to 20
//			* Charisma
//				* Supported values are 0 to 20
//			* Constitution
//					* Supported values are 10 to 20
//		* The sum of all points must be 60, no more and no less
//			* So for example if each was set to 10, this is valid however if each was set to 11 or 9 this is not valid
//		* The character builder should not create a character that does not have the required ability points set
//	* After the required character ability points are set, if the character is valid the character builder will now build the character 