using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Code;
using System;

namespace RPG.Tests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void CharacterTest_HappyPath()
        {
            ///Arrange

            string name = "Billy";
            
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
            Character character = new Character(name, attributes1, stats1);

            ///Assert

            Assert.AreEqual("Billy", character.CharacterName);
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

        [TestMethod]
        public void ReSpecCharacterTest_HappyPath()
        {
            ///Arrange
            
            string name = "Billy";

            int headRoundness = 69;
            string fittnessLevel = "NotFit";
            int heightInInches = 69;

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            int intelligenceRespec = 5;
            int wisdomRespec = 10;
            int dexterityRespec = 10;
            int strengthRespec = 10;
            int charismaRespec = 10;
            int constitutionRespec = 15;

            ///Act
            CharacterAttributes attributes1 = new CharacterAttributes(headRoundness, fittnessLevel, heightInInches);
            CharacterStats stats1 = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);
            CharacterStats stats2 = new CharacterStats(intelligenceRespec, wisdomRespec, dexterityRespec, strengthRespec, charismaRespec, constitutionRespec);
            Character playerCharacter = new Character(name, attributes1, stats1);
            playerCharacter.RespecCharacter(stats2);



            ///Assert

            Assert.AreEqual("Billy", playerCharacter.CharacterName);
            Assert.AreEqual(69, playerCharacter.Attributes.HeadRoundness);
            Assert.AreEqual("NotFit", playerCharacter.Attributes.FitnessLevel);
            Assert.AreEqual(69, playerCharacter.Attributes.HeightInInches);
            Assert.AreEqual("5'9", playerCharacter.Attributes.convertedHeight);
            Assert.AreEqual(5, playerCharacter.Stats.Intelligence);
            Assert.AreEqual(10, playerCharacter.Stats.Wisdom);
            Assert.AreEqual(10, playerCharacter.Stats.Dexterity);
            Assert.AreEqual(10, playerCharacter.Stats.Strength);
            Assert.AreEqual(10, playerCharacter.Stats.Charisma);
            Assert.AreEqual(15, playerCharacter.Stats.Constitution);

        }
    }
}