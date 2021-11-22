using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Code;

namespace RPG.Tests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void CharacterTest_HappyPath()
        {
            ///Arrange

            int headRoundness = 69;
            string fittnessLevel = "NotFit";
            int heightInInches = 69;

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            ///Act

            CharacterAttributes attributes1 = new CharacterAttributes(headRoundness, fittnessLevel, heightInInches);
            CharacterStats stats1 = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);
            var builder = new Builder();
            Character character = builder.CreateCharacter(attributes1, stats1);

            ///Assert

            Assert.AreEqual(69, character.Attributes.HeadRoundness);
            Assert.AreEqual("NotFit", character.Attributes.FitnessLevel);
            Assert.AreEqual(69, character.Attributes.HeightInInches);
            Assert.AreEqual("5'9", character.Attributes.convertedHeight);
            Assert.AreEqual(10, character.Stats.Intelligence);
            Assert.AreEqual(10, character.Stats.Wisdom);
            Assert.AreEqual(10, character.Stats.Dexterity);
            Assert.AreEqual(10, character.Stats.Strength);
            Assert.AreEqual(10, character.Stats.Charisma);
            Assert.AreEqual(10, character.Stats.Constitution);

        }
    }
}