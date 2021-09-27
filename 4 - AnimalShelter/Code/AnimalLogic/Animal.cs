using AnimalShelter.Code.Interfaces;
using AnimalShelter.Code.Enums;
using System;



namespace AnimalShelter.Code
{
    public abstract class Animal : IAnimal
    {
        public string PotentialAnimal { get; protected set; }
        public Guid UniqueAnimalId { get; private set; } = Guid.NewGuid();
        public bool IsSupported { get; protected set; }
        public bool CanFly { get; protected set; }
        

        public bool DetermineIfSupported(bool isSupported)
        {
            IsSupported = isSupported;

            if (Enum.IsDefined(typeof(SupportedAnimals), PotentialAnimal))
            {
                isSupported = true;
            }

            return isSupported; // remove later, obvs
        }
                
        public abstract bool DetermineIfCanFly();

    }
}
