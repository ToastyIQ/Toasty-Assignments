using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Code
{
    public class Shelter
    {
        public List<Animal> shelterAnimals = new List<Animal>();
        public bool isAdded = false;

        public object Species { get; private set; }

        public Response AddAnimal(Animal animal)
        {
            bool status = false;
            string errorMessage = null;

            if (animal.IsSupported)
            {
                shelterAnimals.Add(animal);
                status = true;
            }

            else
            {
                errorMessage = "This animal is not supported";
            }

            var addAnimalResult = new Response(animal, status, errorMessage);

            return addAnimalResult;

        }

        public List<Animal> GetAnimals(string filter) ///filter animal 
        {
            List<Animal> filteredAnimalList = new List<Animal>();

            if (filter.Equals("Cat"))
            {
                filteredAnimalList = shelterAnimals.Where(animal => animal.Species.Equals(filter)).ToList();
            }
            else if (filter.Equals("Dog"))
            {
                filteredAnimalList = shelterAnimals.Where(animal => animal.Species.Equals(filter)).ToList();
            }
            else if (filter.Equals("Can Fly"))
            {
                filteredAnimalList = shelterAnimals.Where(animal => animal.CanFly).ToList();
            }
            else if (filter.Equals(null))
            {
                filteredAnimalList = shelterAnimals;
            }

            return filteredAnimalList;
        }

        public Response RemoveAnimal(Animal animal)
        {
            bool status = false;
            string errorMessage = null;

            if (animal.IsSupported == false)
            {
                errorMessage = "This animal is not supported";
            }
            else if (shelterAnimals.Contains(animal))
            {
                status = true;
                shelterAnimals.Remove(animal);
            }
            else
            {
                errorMessage = "Animal not found";
            }

            var removeAnimalResult = new Response(animal, status, errorMessage);
            return removeAnimalResult;

            throw new NotImplementedException();
        }

        public Response FindAnimalById(Guid idToFind)
        {
            bool status = false;
            string errorMessage = "";
            Animal animal = null;

            Animal animalResult = (Animal)shelterAnimals.Where(animal => animal.Species.Equals(idToFind));

            if (animalResult == null)
            {
                errorMessage = "Animal not found";
            }
            else
            {
                animal = animalResult;
                status = true;
            }

            
            var animalIdSearchResult = new Response(animal, status, errorMessage);
            return animalIdSearchResult;
        }
    }
}
