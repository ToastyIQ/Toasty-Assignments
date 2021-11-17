using RPG.Code.CharacterBuilder;
using RPG.Code.CharacterBuilder.CharacterAttributes;
using RPG.Code.CharacterBuilder.CharacterStats;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Code
{
    class Builder
    {
        
        public Character CreateCharacter()
        {
            Stats newStats = new Stats();
            Attributes newAttributes = new Attributes();
            Character newCharacter = new Character(newAttributes, newStats);
            return newCharacter;
        }
    }
}
