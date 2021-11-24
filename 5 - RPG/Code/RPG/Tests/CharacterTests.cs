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
            Character character = new Character(attributes1, stats1);

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

        [TestMethod]
        public void ReSpecCharacterTest_HappyPath()
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

            int intelligenceRespec = 5;
            int wisdomRespec = 10;
            int dexterityRespec = 10;
            int strengthRespec = 10;
            int charismaRespec = 10;
            int constitutionRespec = 15;

            ///Act
            CharacterAttributes attributes1 = new CharacterAttributes(headRoundness, fittnessLevel, heightInInches);
            CharacterStats stats1 = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);
            Character playerCharacter = new Character(attributes1, stats1);
            Character respecPlayerCharacter = playerCharacter.RespecCharacter(playerCharacter, intelligenceRespec, wisdomRespec, dexterityRespec, strengthRespec, charismaRespec, constitutionRespec);



            ///Assert

            Assert.AreEqual(69, respecPlayerCharacter.Attributes.HeadRoundness);
            Assert.AreEqual("NotFit", respecPlayerCharacter.Attributes.FitnessLevel);
            Assert.AreEqual(69, respecPlayerCharacter.Attributes.HeightInInches);
            Assert.AreEqual("5'9", respecPlayerCharacter.Attributes.convertedHeight);
            Assert.AreEqual(5, respecPlayerCharacter.Stats.Intelligence);
            Assert.AreEqual(10, respecPlayerCharacter.Stats.Wisdom);
            Assert.AreEqual(10, respecPlayerCharacter.Stats.Dexterity);
            Assert.AreEqual(10, respecPlayerCharacter.Stats.Strength);
            Assert.AreEqual(10, respecPlayerCharacter.Stats.Charisma);
            Assert.AreEqual(15, respecPlayerCharacter.Stats.Constitution);

        }

        [TestMethod]
        public void ReSpecCharacterTest_InvalidStatValues()
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

            int intelligenceRespec = 21;
            int wisdomRespec = 10;
            int dexterityRespec = 10;
            int strengthRespec = 10;
            int charismaRespec = 10;
            int constitutionRespec = 10;

            ///Act
            CharacterAttributes attributes1 = new CharacterAttributes(headRoundness, fittnessLevel, heightInInches);
            CharacterStats stats1 = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);
            Character playerCharacter = new Character(attributes1, stats1);

            ///Act            

            AggregateException exception = Assert.ThrowsException<AggregateException>(() => playerCharacter.RespecCharacter(playerCharacter, intelligenceRespec, wisdomRespec, dexterityRespec, strengthRespec, charismaRespec, constitutionRespec));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Intelligence must be 5 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);

        }


    }
}