using RPG.Code.CharacterBuilder.Enums;
using System;

namespace RPG.Code
{
    public class CharacterAttributes
    {
        public int HeadRoundness { get; set; }
        public string FitnessLevel { get; set; }
        public int HeightInInches { get; set; }
        public string convertedHeight = "";


        public CharacterAttributes (int headRoundness, string fitnessLevel, int heightInInches)
        {
            HeadRoundness = headRoundness;
            FitnessLevel = fitnessLevel;
            HeightInInches = heightInInches;
            convertedHeight = ConvertHeight(heightInInches);
        }

        public string ConvertHeight(int heightInInches)
        {
            //convertedHeight = $"{heightInInches / 12}'{heightInInches % 12}";
            int feet = 0;
            while (heightInInches > 12)
            {
                heightInInches -= 12;
                feet++;
            }
            convertedHeight = $"{feet}'{heightInInches}";
            return convertedHeight;
        }
    }
}
