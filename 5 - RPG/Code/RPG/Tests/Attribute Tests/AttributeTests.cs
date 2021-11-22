using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Code;
using System;

namespace RPG.Tests
{
    [TestClass]
    public class AttributeTests
    {

        [TestMethod]
        public void AttributeTest_HappyPath()
        {
            ///Arrange

            int headRoundness = 69;
            string fitnessLevel = "NotFit";
            int heightInInches = 69;

            ///Act
            var builder = new Builder();
            CharacterAttributes attributes1 = builder.CreateAttributes(headRoundness, fitnessLevel, heightInInches);

            ///Assert

            Assert.AreEqual(69, attributes1.HeadRoundness);
            Assert.AreEqual("NotFit", attributes1.FitnessLevel);
            Assert.AreEqual(69, attributes1.HeightInInches);
            Assert.AreEqual("5'9", attributes1.convertedHeight);

        }

       
        [TestMethod]
        public void AttributeTest_InvalidHeadRoundess()
        {
            int headRoundness = 420;
            string fitnessLevel = "NotFit";
            int heightInInches = 69;

            var builder = new Builder();

            var exception = Assert.ThrowsException<ArgumentException>(() => builder.CreateAttributes(headRoundness, fitnessLevel, heightInInches));

            Assert.AreEqual("Head Roundness must be a value of 0 - 100", exception.Message);
        }

        [TestMethod]
        public void AttributeTest_InvalidFitnessRoundess()
        {
            int headRoundness = 69;
            string fitnessLevel = "NotVeryFit";
            int heightInInches = 69;

            var builder = new Builder();

            var exception = Assert.ThrowsException<ArgumentException>(() => builder.CreateAttributes(headRoundness, fitnessLevel, heightInInches));

            Assert.AreEqual("This is not a valid fitness level.", exception.Message);
        }

        [TestMethod]
        public void AttributeTest_InvalidHeightRoundess()
        {
            int headRoundness = 69;
            string fitnessLevel = "NotFit";
            int heightInInches = -69;

            var builder = new Builder();

            var exception = Assert.ThrowsException<ArgumentException>(() => builder.CreateAttributes(headRoundness, fitnessLevel, heightInInches));

            Assert.AreEqual("Height must be a postive number", exception.Message);
        }
    }
}