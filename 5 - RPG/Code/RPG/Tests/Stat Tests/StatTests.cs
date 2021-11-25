using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Code;
using System;

namespace RPG.Tests
{
    [TestClass]
    public class StatTests
    {
        [TestMethod]
        public void StatTest_HappyPath()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            ///Act
            CharacterStats stats1 = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);

            ///Assert

            Assert.AreEqual(10, stats1.Intelligence);
            Assert.AreEqual(10, stats1.Wisdom);
            Assert.AreEqual(10, stats1.Dexterity);
            Assert.AreEqual(10, stats1.Strength);
            Assert.AreEqual(10, stats1.Charisma);
            Assert.AreEqual(10, stats1.Constitution);

        }

        [TestMethod]
        public void StatTest_IntelligenceTooHigh()
        {
            ///Arrange

            int intelligence = 21;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            ///Act            

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Intelligence must be 5 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);

        }

        [TestMethod]
        public void StatTest_IntelligenceTooLow()
        {
            ///Arrange

            int intelligence = -1;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            ///Act            

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Intelligence must be 5 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);

        }

        [TestMethod]
        public void StatTest_WisdomTooHigh()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 21;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            ///Act            

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Wisdom must be 5 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_WisdomTooLow()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 4;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;
            ///Act            

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Wisdom must be 5 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_DexterityTooHigh()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 69;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            ///Act
            
            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Dexterity must be 1 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_DexterityTooLow()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 0;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            ///Act

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Dexterity must be 1 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_StrengthTooHigh()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 420;
            int charisma = 10;
            int constitution = 10;

            ///Act

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Strength must be 1 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_StrengthTooLow()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = -41;
            int charisma = 10;
            int constitution = 10;

            ///Act

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Strength must be 1 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_CharismaTooHigh()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 100;
            int constitution = 10;

            ///Act

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Charisma must be 0 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_CharismaTooLow()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = -1;
            int constitution = 10;

            ///Act

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Charisma must be 0 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_ConstitutionTooHigh()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 69;

            ///Act

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Constitution must be 10 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_ConstitutionTooLow()
        {
            ///Arrange

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 9;

            ///Act

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (Constitution must be 10 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_StatBlockTotalIsMoreThan60()
        {
            ///Arrange

            int intelligence = 12;
            int wisdom = 11;
            int dexterity = 11;
            int strength = 12;
            int charisma = 11;
            int constitution = 12;
            ///Act

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }

        [TestMethod]
        public void StatTest_StatBlockTotalIsLessThan60()
        {
            ///Arrange

            int intelligence = 9;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            ///Act

            var exception = Assert.ThrowsException<AggregateException>(() => new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution));

            ///Assert

            Assert.AreEqual("One or more errors have been encountered (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);
        }
    }
}