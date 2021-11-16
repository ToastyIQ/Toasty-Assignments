using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Code.Character.Enums
{
    interface ICharacter
    {
        public int HeadRoundness { get; }
        public string FitnessLevel { get; }
        public int Height { get; }
        public int Intelligence { get; }
        public int Wisdom { get; }
        public int Dexterity { get; }
        public int Strength { get; }
        public int Charisma { get; }
        public int Constitution { get; }

    }
}



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