using AnimalShelter.Code.ResponseLogic;
using System;
using System.Collections.Generic;

namespace AnimalShelter.Code
{
    public class AnimalShelter
    {
        public List<Animal> shelterList = new List<Animal>();
        public bool isAdded = false;
        string responseMessage;

        public Animal AddAnimal (Animal animal)
        {

            //*This function will return a result object with the following properties:
            //*Property: If the animal was added to the shelter(true / false)
            //*Property: The animal object that was added to the shelter(NULL if not added)
            //*Property: String error message for reasons the animal was not added
            //    * Example error messages
            //       * Animal was not a supported animal
            //       * Anything else you can think of that you think the system should validate against

            ///string responseMessage;
            ///

            var addAnimalResult = new GenerateAnimalResponse();

            if (animal.IsSupported)
            {
                isAdded = true;
                shelterList.Add(animal);
                return addAnimalResult;
            }
            else
            {
                responseMessage = "${animal} is not a supported animal and has not been added to the shelter";
            }

        }

        public void GetAnimal()
        {
            // 
            throw new NotImplementedException();
        }

        public void FindAnimal()
        {
            throw new NotImplementedException();
        }

        public void FindAnimalById()
        {
            throw new NotImplementedException();
        }
        public GenerateAnimalResponse AnimalResponse()
        {
            throw new NotImplementedException();
        }
    }
}
