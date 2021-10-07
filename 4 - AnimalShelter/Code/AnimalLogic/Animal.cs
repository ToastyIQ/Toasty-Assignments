using AnimalShelter.Code.Enums;
using AnimalShelter.Code.Interfaces;
using System;



namespace AnimalShelter.Code
{
    public class Animal : IAnimal
    {
        public string Species { get; }
        public Guid UniqueAnimalId { get;  } = Guid.NewGuid();
        public bool IsSupported { get { return DetermineIfSupported(); } }
        public bool CanFly { get { return DetermineIfCanFly(); } }

        public Animal(string species)
        {
            Species = species;
        }

        public bool DetermineIfSupported()
        {
            if (Enum.IsDefined(typeof(SupportedAnimals), Species))
                {
                    return true;
                }
            return false;
        }

        public bool DetermineIfCanFly()
        {
            KnownAnimals potentialAnimals = (KnownAnimals)Enum.Parse(typeof(KnownAnimals), Species);

            if (potentialAnimals.Equals(KnownAnimals.Bird))
            {
                return true;
            }
            return false;
        }
    }
}
