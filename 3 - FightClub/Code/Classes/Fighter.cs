using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;

namespace FightClub.Code
{
    class Fighter : IFighter 
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public FighterState State { get; set; }

        public Fighter()
        {
            Health = 10;
            Damage = 1;
            State = FighterState.Healthy;
        }

        public void DrinkPotion(IPotion potion)
        {
            /*
            Health != 0 ? Health = 0 : Health += potion.Healing;
            
            Health >= 10 ? Health = 10 : Health += potion.Healing;
            */

            if (Health != 0)
            {
                Health += potion.Healing;
            }
            if (Health >= 10)
            {
                Health = 10;
            }


            if (Health >= 10)
            { 
                State = FighterState.Healthy; 
            }
            else if (Health >= 2)
            { 
                State = FighterState.Hurt; 
            }
            else if (Health == 1)
            { 
                State = FighterState.KnockedOut; 
            }
            else if (Health == 0)
            { 
                State = FighterState.Dead; 
            }
        }

        public void PowerUp(IPowerUp powerUp)
        {
            //Damage > 0 ? Damage += powerUp.DamageBuff : 0;
            
            Damage += powerUp.DamageBuff;
            
            if (Damage <= 0) 
            { 
                Damage = 1;
            }

        }

        public void TakeDamage(IFighter fighter)
        {
            if (Health > 0)
            {
                Health -= fighter.Damage;
                if (Health >= 10)
                {
                    State = FighterState.Healthy;
                }
                else if (Health >= 2)
                {
                    State = FighterState.Hurt;
                }
                else if (Health == 1)
                {
                    State = FighterState.KnockedOut;
                }
                else if (Health == 0)
                {
                    State = FighterState.Dead;
                }
            }
        }
    }
}