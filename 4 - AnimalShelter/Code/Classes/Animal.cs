using System;
using System.Collections.Generic;
using System.Text;
using AnimalShelter.Code.Interfaces;

namespace AnimalShelter.Code
{
    class Animal : IAnimals
    {
        public string PotentialAnimal { get; set; }
        public bool IsSupported { get; set; }
        
        public Animal()
        {
            //
            //received animal information
            //verify animal is supported
            //generate uniqueAnimalId (guid)
            //store guid and animal type ... somewhere. Maybe dictionary
            //        public Potion()
            //{
            //    Healing = 2;
            //    Type = PotionType.Basic;
            //}

            //public void SetType(PotionType potionType)
            //{
            //    Type = potionType;
            //    Healing = (Type == PotionType.Greater) ? 5 : 2;
            //}

            throw new NotImplementedException();
        }
    }
}
