using RPG.Code.CharacterBuilder.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Code
{
    public class CharacterAttributes
    {
        public int HeadRoundness { get; }
        public string FitnessLevel { get; }
        public int HeightInInches { get; }
        public string convertedHeight = "";


        public CharacterAttributes (int headRoundness, string fitnessLevel, int heightInInches)
        {
            var exceptions = new List<Exception>();

            if (headRoundness > 100 || headRoundness < 0)
            {
                exceptions.Add(new ArgumentException("Head Roundness must be a value of 0 - 100"));
            }
            else if (!Enum.IsDefined(typeof(FitnessLevels), fitnessLevel))
            {
                exceptions.Add(new ArgumentException("This is not a valid fitness level."));
            }
            else if (heightInInches < 0)
            {
                exceptions.Add(new ArgumentException("Height must be a postive number."));
            }

            if (exceptions.Any())
            {
                throw new AggregateException("One or more errors have been encountered", exceptions);
            }


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
