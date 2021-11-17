using RPG.Code.CharacterBuilder.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Code.CharacterBuilder.CharacterAttributes
{
    public class Attributes
    {
        public int HeadRoundness { get; set; }
        public string FitnessLevel { get; set; }
        public int HeightInInches { get; set; }
        public string convertedHeight = "";
        public string attributeValidationMessage = "";
        public bool areValid = false;


        public Attributes(int headRoundness, string fitnessLevel, int heightInInches)
        {
            HeadRoundness = headRoundness;
            FitnessLevel = fitnessLevel;
            HeightInInches = heightInInches;
            convertedHeight = ConvertHeight(HeightInInches);
        }

        public Attributes()
        {
        }

        public string ConvertHeight(int heightInInches)
        {
            for (int feet = 0; heightInInches < 12; feet++)
            {
                int inches = heightInInches;
                string height = $"{feet}'{inches}";
                convertedHeight = height;
            }
            return convertedHeight;
        }

        //public void HeadRoundnessValidation(int headRoundness)
        //{
        //    if (headRoundness > 100 || headRoundness < 0)
        //    {
        //        attributeValidationMessage = "Head Roundness must be a value of 0 - 100%";
        //    }
        //    else
        //    {
        //        HeadRoundness = headRoundness;
        //        areValid = true;
        //    }
        //}

        //public void HeightValidation(int heightInInches)
        //{
        //    if (heightInInches <= 0)
        //    {
        //        attributeValidationMessage = "Height in inches must be greater than 0";
        //    }
        //    else
        //    {
        //        HeightInInches = heightInInches;
        //        areValid = true;
        //    }
        //}

        //public void FitnessLevelValidation(string fitnessLevel)
        //{
        //    if (Enum.IsDefined(typeof(FitnessLevels), FitnessLevel))
        //    {
        //        FitnessLevel = fitnessLevel;
        //        areValid = true;
        //    }
        //    else
        //    {
        //        attributeValidationMessage = "This fitness level is not supported";
        //    }
        //}
    }
}
