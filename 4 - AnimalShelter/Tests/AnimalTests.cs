using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter.Code;
using AnimalShelter.Code.Enums;

namespace AnimalShelter.Tests
{
    [TestClass]
      
    public class AnimalTests
    {
        [TestMethod]
        public void AnimalTest_ConfirmAnimalValuesCat()
        {
            var animalToAdd = new Animal("Cat");

            Assert.AreEqual("Cat", animalToAdd.Species);
            Assert.AreEqual(true, animalToAdd.IsSupported);
            Assert.AreEqual(false, animalToAdd.CanFly);
        }
        
        [TestMethod]
        public void AnimalTest_ConfirmAnimalValuesBird()
        {
            var animalToAdd = new Animal("Bird");

            Assert.AreEqual("Bird", animalToAdd.Species);
            Assert.AreEqual(true, animalToAdd.IsSupported);
            Assert.AreEqual(true, animalToAdd.CanFly);
        }

        [TestMethod]
        public void AnimalTest_ConfirmAnimalValuesBear()
        {
            var animalToAdd = new Animal("Bear");

            Assert.AreEqual("Bear", animalToAdd.Species);
            Assert.AreEqual(false, animalToAdd.IsSupported);
            Assert.AreEqual(false, animalToAdd.CanFly);


        }

    }
}
