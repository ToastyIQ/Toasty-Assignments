using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Code.Character
{
    class Attributes
    {

    }
}


//* The character builder requires the following character body attributes set before moving to the next step
//***Character Builder Step 1 - Attributes**
//			* Head Roundness
//				* Support values are very round (100%) to not round at all (0%)
//			*Fitness Level
//			   * Supported values are "extremely fit", "very fit", "somewhat fit", "not fit", "far from fit"
//			* Height
//				* Needs to be in inches and feet and needs to be supported like "5'11" or "5"
//		* The character builder should not create a character that does not have the required attributes set