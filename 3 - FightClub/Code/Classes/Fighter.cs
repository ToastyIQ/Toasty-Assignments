using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;

namespace FightClub.Code
{
    class Fighter : IFighter 
    {
        public int Health { get => _health; }
        public int Damage { get; private set; }
        public FighterState State { get; private set; }

        public Fighter()
        {
            _health = 10;
            Damage = 1;
            State = FighterState.Healthy;
        }

        public Fighter(int health, int damage, FighterState state) 
        {
            _health = health;
            State = state;
            Damage = damage; 
        }

        private int _health;
        public void DrinkPotion(IPotion potion)
        {
            /*
            Health != 0 ? Health = 0 : Health += potion.Healing;
            
            Health >= 10 ? Health = 10 : Health += potion.Healing;
            */

            if (_health != 0)
            {
                _health += potion.Healing;
            }
            if (_health >= 10)
            {
                _health = 10;
            }

            SetState();
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
            if (_health > 0)
            {
                _health -= fighter.Damage;
                SetState();
            }
        }

        private void SetState()
        {
            if (_health >= 10)
            {
                State = FighterState.Healthy;
            }
            else if (_health >= 2)
            {
                State = FighterState.Hurt;
            }
            else if (_health == 1)
            {
                State = FighterState.KnockedOut;
            }
            else if (_health == 0)
            {
                State = FighterState.Dead;
            }
        }
    }
}