using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;

namespace FightClub.Code
{
    class PowerUp : IPowerUp
    {
        public int DamageBuff { get; set; }
        public PowerUp()
        {
            DamageBuff = 1;
        }
    }
}
