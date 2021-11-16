using RPG.Code.Character.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Code.Character
{
    class CharacterBuilder : ICharacter
    {
        public int HeadRoundness { get; private set; }
        public string FitnessLevel { get; private set; }
        public int Height { get; private set; }
        public int Intelligence { get; private set; }
        public int Wisdom { get; private set; }
        public int Dexterity { get; private set; }
        public int Strength { get; private set; }
        public int Charisma { get; private set; }
        public int Constitution { get; private set; }
    }
}
