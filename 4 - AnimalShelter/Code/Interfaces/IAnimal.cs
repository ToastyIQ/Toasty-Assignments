using System;
using AnimalShelter.Code.Enums;


namespace AnimalShelter.Code.Interfaces
{
    interface IAnimal
    {
        public Guid UniqueAnimalId { get; }
        public string PotentialAnimal { get; }
        public bool CanFly { get; }
        public bool IsSupported { get; }

    }
}
