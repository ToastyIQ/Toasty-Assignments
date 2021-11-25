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
   
            CharacterAttributes attributes1 = new CharacterAttributes(headRoundness, fitnessLevel, heightInInches);

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

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterAttributes(headRoundness, fitnessLevel, heightInInches));

            Assert.AreEqual("One or more errors have been encountered (Head Roundness must be a value of 0 - 100)", exception.Message);
        }

        [TestMethod]
        public void AttributeTest_InvalidFitness()
        {
            int headRoundness = 69;
            string fitnessLevel = "NotVeryFit";
            int heightInInches = 69;            

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterAttributes(headRoundness, fitnessLevel, heightInInches));

            Assert.AreEqual("One or more errors have been encountered (This is not a valid fitness level.)", exception.Message);
        }

        [TestMethod]
        public void AttributeTest_InvalidHeightRoundess()
        {
            int headRoundness = 69;
            string fitnessLevel = "NotFit";
            int heightInInches = -69;

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterAttributes(headRoundness, fitnessLevel, heightInInches));

            Assert.AreEqual("One or more errors have been encountered (Height must be a postive number.)", exception.Message);
        }
    }
}