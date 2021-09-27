using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Code.Interfaces
{
    public interface IAnimals
    {
        string PotentialAnimal { get; }
        bool IsSupported { get; }
    }
}
