using System;

namespace AnimalShelter.Code
{
    public class GenerateAnimalResponse
    {
   
        public Animal AddAnimalResult(Animal animal)
        {
            ///
            /// if animal is supported return success messsage that contains animal properties and isAdded status
            /// if animal is not supported return error message
            /// 


        public Animal RemoveAnimalResult(Animal animal, AnimalShelter shelterList)
        {
            ///
            /// can attempt to remove any animal from animal enums
            /// if animal is found in shelterList
            ///     confirm if supported
            ///         if supported animal
            ///             confirm animal is in system
            ///                 if supported animal not in sytem return error message stating not in system
            ///                 if supported animal in system set isRemoved property to true, remove animal
            ///         if not supported
            ///             return message that animal is not supported type, set isRemoved property to false
            ///
            bool isRemoved = IsRemoved;

            if (animal.IsSupported && shelterList.Contains(animal) = true)
            {
                bool isRemoved = IsRemoved;
                return SuccessMessage();
            }
            else if (animal.IsSupported == false)
            {
                return "Animal is not supported";
            }
            else if (shelterList.Contains(animal) = false)
            {
                return "Animal not found.";
            }
        }
    }
}
        
}