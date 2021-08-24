using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;

namespace FightClub.Code
{
    class Potion : IPotion
    {
        public int Healing { get; set; }
        public PotionType Type { get; set; }
        public Potion()
        {
            Healing = 2;
            Type = PotionType.Basic;
        }

        public void SetType(PotionType potionType)
        {
            Type = potionType;
            Healing = (Type == PotionType.Greater) ? 5 : 2;
        }
    }
}
