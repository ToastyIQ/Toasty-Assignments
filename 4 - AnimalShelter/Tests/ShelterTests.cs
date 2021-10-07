using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter.Code;
using AnimalShelter.Code.Enums;
using System.Collections.Generic;

namespace AnimalShelter.Tests
{
    [TestClass]

    public class ShelterTests
    {
        [TestMethod]
        public void ShelterTest_AddAnimalToNewShelter()
        {
            Shelter shelter = new Shelter();
            var animalToAdd = new Animal("Dog");
            var actual = shelter.shelterAnimals.Contains(animalToAdd);

            shelter.AddAnimal(animalToAdd);
            
            Assert.AreEqual(1, shelter.shelterAnimals.Count);
            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void ShelterTest_AnimalFilterCat()
        {
            Shelter shelter = new Shelter();
            var animalToAdd = new Animal("Cat");
            var animalToAdd1 = new Animal("Cat");
            var animalToAdd2 = new Animal("Dog");
            var animalToAdd3 = new Animal("Bird");

            shelter.AddAnimal(animalToAdd);
            shelter.AddAnimal(animalToAdd1);
            shelter.AddAnimal(animalToAdd2);
            shelter.AddAnimal(animalToAdd3);

            var filteredList = shelter.GetAnimals("Cat");
            var actual = filteredList.Contains(animalToAdd);

            Assert.AreEqual(2, filteredList.Count);
            Assert.IsTrue(actual);

        }
        [TestMethod]
        public void ShelterTest_AnimalFilterCanFly()
        {
            Shelter shelter = new Shelter();
            var animalToAdd = new Animal("Cat");
            var animalToAdd1 = new Animal("Cat");
            var animalToAdd2 = new Animal("Dog");
            var animalToAdd3 = new Animal("Bird");

            shelter.AddAnimal(animalToAdd);
            shelter.AddAnimal(animalToAdd1);
            shelter.AddAnimal(animalToAdd2);
            shelter.AddAnimal(animalToAdd3);

            var filteredList = shelter.GetAnimals("Can Fly");
            var actual = filteredList.Contains(animalToAdd3);

            Assert.AreEqual(1, filteredList.Count);
            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void ShelterTest_AnimalFilter()
        {
            Shelter shelter = new Shelter();
            var animalToAdd = new Animal("Cat");
            var animalToAdd1 = new Animal("Cat");
            var animalToAdd2 = new Animal("Dog");
            var animalToAdd3 = new Animal("Bird");

            shelter.AddAnimal(animalToAdd);
            shelter.AddAnimal(animalToAdd1);
            shelter.AddAnimal(animalToAdd2);
            shelter.AddAnimal(animalToAdd3);

            var filteredList = shelter.GetAnimals("Can Fly");
            var actual = filteredList.Contains(animalToAdd3);

            Assert.AreEqual(1, filteredList.Count);
            Assert.IsTrue(actual);

        }
    }
}

