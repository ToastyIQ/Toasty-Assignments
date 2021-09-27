using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;

namespace FightClub.Code
{
    class Potion : IPotion
    {
        public int Healing => (Type == PotionType.Greater) ? 5 : 2;
        public PotionType Type { get => _type; }

        private PotionType _type;
        public Potion()
        {
            _type = PotionType.Basic;
        }

        public Potion(PotionType potionType)
        {
            SetType(potionType);
        }

        public void SetType(PotionType potionType)
        {
            _type = potionType;
        }
    }
}
