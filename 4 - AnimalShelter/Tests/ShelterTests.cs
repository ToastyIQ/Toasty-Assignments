using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter.Code;
using AnimalShelter.Code.Enums;
using System.Collections.Generic;
using System;

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
            shelter.AddAnimal(animalToAdd);

            ///Arrange
            
            var actual = shelter.shelterAnimals.Contains(animalToAdd);

            ///Act 
            
            Assert.AreEqual(1, shelter.shelterAnimals.Count);
            Assert.IsTrue(actual);

            ///Assert

        }

        [TestMethod]
        public void ShelterTest_AnimalFilter_Cat()
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

            ///Arrange

            var filteredList = shelter.GetAnimals("Cat");
            var actual = filteredList.Contains(animalToAdd);

            ///Act

            Assert.AreEqual(2, filteredList.Count);
            Assert.IsTrue(actual);

            ///Assert
        }
        [TestMethod]
        public void ShelterTest_AnimalFilter_CanFly()
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

            ///Arrange

            var filteredList = shelter.GetAnimals("Can Fly");
            var actual = filteredList.Contains(animalToAdd3);

            ///Act

            Assert.AreEqual(1, filteredList.Count);
            Assert.IsTrue(actual);

            ///Assert

        }

        [TestMethod]
        public void ShelterTest_FindAnimalById_WhereIdExists()
        {
            Shelter shelter = new Shelter();
            var animalToAdd = new Animal("Cat");
            shelter.AddAnimal(animalToAdd);
            Guid id = animalToAdd.UniqueAnimalId;

            ///Arrange

            var result = shelter.FindAnimalById(id);

            ///Act

            Assert.AreEqual(animalToAdd, result.Animal);

            ///Assert
        }

        [TestMethod]
        public void ShelterTest_FindAnimalById_WhereIdDoesNotExist()
        {
            Shelter shelter = new Shelter();
            var animalToAdd = new Animal("Cat");
            shelter.AddAnimal(animalToAdd);
            Guid idToSeach = Guid.NewGuid();

            ///Arrange

            var result = shelter.FindAnimalById(idToSeach);

            ///Act

            Assert.AreEqual(false, result.Status);
            Assert.AreEqual("Animal not found", result.ErrorMessage);

            ///Assert
        }

        [TestMethod]
        public void ShelterTest_RemoveAnimal_WhereAnimalExists()
        {
            Shelter shelter = new Shelter();
            var animalToAdd = new Animal("Cat");
            var animalToAdd1 = new Animal("Cat");
            var animalToAdd2 = new Animal("Dog");
            shelter.AddAnimal(animalToAdd);
            shelter.AddAnimal(animalToAdd1);
            shelter.AddAnimal(animalToAdd2);
            var animalToRemove = animalToAdd;

            ///Arrange

            var result = shelter.RemoveAnimal(animalToRemove);

            /// Act

            Assert.AreEqual(true, result.Status);
            Assert.AreEqual(animalToRemove, result.Animal);
            Assert.AreEqual(2, shelter.shelterAnimals.Count);

            /// Assert
        }

        [TestMethod]
        public void ShelterTest_RemoveAnimal_WhereAnimalDoesNotExist()
        {
            Shelter shelter = new Shelter();
            var animalToAdd = new Animal("Cat");
            var animalToAdd1 = new Animal("Cat");
            var animalToAdd2 = new Animal("Dog");
            shelter.AddAnimal(animalToAdd);
            shelter.AddAnimal(animalToAdd1);
            shelter.AddAnimal(animalToAdd2);
            var animalToRemove = new Animal("Bird");

            ///Arrange

            var result = shelter.RemoveAnimal(animalToRemove);

            /// Act

            Assert.AreEqual(false, result.Status);
            Assert.AreEqual("Animal not found", result.ErrorMessage);
            Assert.AreEqual(3, shelter.shelterAnimals.Count);

            /// Assert
        }

        [TestMethod]
        public void ShelterTest_RemoveAnimal_WhereAnimalNotSupported()
        {
            Shelter shelter = new Shelter();
            var animalToAdd = new Animal("Cat");
            var animalToAdd1 = new Animal("Cat");
            var animalToAdd2 = new Animal("Dog");
            shelter.AddAnimal(animalToAdd);
            shelter.AddAnimal(animalToAdd1);
            shelter.AddAnimal(animalToAdd2);
            var animalToRemove = new Animal("Bear");

            ///Arrange

            var result = shelter.RemoveAnimal(animalToRemove);

            /// Act

            Assert.AreEqual(false, result.Status);
            Assert.AreEqual("This animal is not supported", result.ErrorMessage);
            Assert.AreEqual(3, shelter.shelterAnimals.Count);

            /// Assert
        }
    }
}

