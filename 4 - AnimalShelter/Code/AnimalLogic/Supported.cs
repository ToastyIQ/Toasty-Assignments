using AnimalShelter.Code.Enums;
using AnimalShelter.Code.Interfaces;
using System;


namespace AnimalShelter.Code
{
    public class Supported : Animal, IAnimal
    {
        private bool canFly;

        public override bool DetermineIfCanFly()
        {
            CanFly = canFly; 
            if (PotentialAnimal.Equals(SupportedAnimals.Bird))
            {
                canFly = true;
            }
            return CanFly;
        }

    }
}
