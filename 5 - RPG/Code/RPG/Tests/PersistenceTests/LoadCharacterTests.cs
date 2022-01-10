using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RPG.Code;
using System;
using System.IO;

namespace RPG.Tests
{
    [TestClass]
    public class LoadCharacterTests
    {
        [TestMethod]
        public void DeserializeCharacterTest_HappyPath()
        {
            ///Arrange

            string name = "Billy";
            string path = $@"C:\Users\atamp\source\repos\Toasty-Assignments\5 - RPG\Characters\{name}.json";

            int headRoundness = 69;
            string fittnessLevel = "NotFit";
            int heightInInches = 69;

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            string expectedSerialization = "{\"CharacterName\":\"Billy\",\"Attributes\":{\"convertedHeight\":\"5'9\",\"HeadRoundness\":69,\"FitnessLevel\":\"NotFit\",\"HeightInInches\":69},\"Stats\":{\"Intelligence\":10,\"Wisdom\":10,\"Dexterity\":10,\"Strength\":10,\"Charisma\":10,\"Constitution\":10}}";

            string expectedDeserialization = "{\"CharacterName\":\"Billy\",\"Attributes\":{\"convertedHeight\":\"5'9\",\"HeadRoundness\":69,\"FitnessLevel\":\"NotFit\",\"HeightInInches\":69},\"Stats\":{\"Intelligence\":10,\"Wisdom\":10,\"Dexterity\":10,\"Strength\":10,\"Charisma\":10,\"Constitution\":10}}";


            ///Act

            CharacterAttributes attributes1 = new CharacterAttributes(headRoundness, fittnessLevel, heightInInches);
            CharacterStats stats1 = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);
            Character character = new Character(name, attributes1, stats1);
            string serializedCharacter = CharacterPersistence.SerializeCharacter(character);
            CharacterPersistence.SaveCharacter(character, path);
            string deserializedCharacter = CharacterPersistence.GetCharacterJSONFile(path);

            ///Assert

            Assert.AreEqual(expectedSerialization, serializedCharacter);
            Assert.AreEqual(expectedDeserialization, deserializedCharacter);
            Assert.IsTrue(File.Exists($@"C:\Users\atamp\source\repos\Toasty-Assignments\5 - RPG\Characters\{name}.json"));
        }

        [TestMethod]
        public void LoadCharacterTest_HappyPath()
        {
            ///Arrange

            string name = "Billy";
            string path = $@"C:\Users\atamp\source\repos\Toasty-Assignments\5 - RPG\Characters\{name}.json";

            int headRoundness = 69;
            string fittnessLevel = "NotFit";
            int heightInInches = 69;

            int intelligence = 10;
            int wisdom = 10;
            int dexterity = 10;
            int strength = 10;
            int charisma = 10;
            int constitution = 10;

            string expectedSerialization = "{\"CharacterName\":\"Billy\",\"Attributes\":{\"convertedHeight\":\"5'9\",\"HeadRoundness\":69,\"FitnessLevel\":\"NotFit\",\"HeightInInches\":69},\"Stats\":{\"Intelligence\":10,\"Wisdom\":10,\"Dexterity\":10,\"Strength\":10,\"Charisma\":10,\"Constitution\":10}}";

            string expectedDeserialization = "{\"CharacterName\":\"Billy\",\"Attributes\":{\"convertedHeight\":\"5'9\",\"HeadRoundness\":69,\"FitnessLevel\":\"NotFit\",\"HeightInInches\":69},\"Stats\":{\"Intelligence\":10,\"Wisdom\":10,\"Dexterity\":10,\"Strength\":10,\"Charisma\":10,\"Constitution\":10}}";


            ///Act

            CharacterAttributes attributes1 = new CharacterAttributes(headRoundness, fittnessLevel, heightInInches);
            CharacterStats stats1 = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);
            Character character = new Character(name, attributes1, stats1);
            string serializedCharacter = CharacterPersistence.SerializeCharacter(character);
            CharacterPersistence.SaveCharacter(character, path);
            string deserializedCharacter = CharacterPersistence.GetCharacterJSONFile(path);
            Character loadCharacter = CharacterPersistence.LoadCharacter(deserializedCharacter);

            ///Assert

            Assert.AreEqual(expectedSerialization, serializedCharacter);
            Assert.AreEqual(expectedDeserialization, deserializedCharacter);
            Assert.IsTrue(File.Exists($@"C:\Users\atamp\source\repos\Toasty-Assignments\5 - RPG\Characters\{name}.json"));
            Assert.AreEqual("Billy", loadCharacter.CharacterName);
            Assert.AreEqual(69, loadCharacter.Attributes.HeadRoundness);
            Assert.AreEqual("NotFit", loadCharacter.Attributes.FitnessLevel);
            Assert.AreEqual(69, loadCharacter.Attributes.HeightInInches);
            Assert.AreEqual("5'9", loadCharacter.Attributes.convertedHeight);
            Assert.AreEqual(10, loadCharacter.Stats.Intelligence);
            Assert.AreEqual(10, loadCharacter.Stats.Wisdom);
            Assert.AreEqual(10, loadCharacter.Stats.Dexterity);
            Assert.AreEqual(10, loadCharacter.Stats.Strength);
            Assert.AreEqual(10, loadCharacter.Stats.Charisma);
            Assert.AreEqual(10, loadCharacter.Stats.Constitution);
        }

        [TestMethod]
        public void LoadCharacterTest_InvalidStats()
        {
            ///Arrange
                        
            string path = @"c:\Users\atamp\source\repos\Toasty-Assignments\5 - RPG\Characters\InvalidStats.json";

            ///Act

            string deserializedCharacter = CharacterPersistence.GetCharacterJSONFile(path);            
            var exception = Assert.ThrowsException<AggregateException>(() => CharacterPersistence.LoadCharacter(deserializedCharacter));

            ///Assert

            StringAssert.Contains("One or more errors have been encountered (Wisdom must be 5 - 20) (The sum of intelligence, wisdom, dexterity, strength, charisma, and constitution must be equal to 60)", exception.Message);

        }

        [TestMethod]
        public void LoadCharacterTest_InvalidAttributes()
        {
            ///Arrange

            string path = @"c:\Users\atamp\source\repos\Toasty-Assignments\5 - RPG\Characters\InvalidAttributes.json";

            ///Act

            string deserializedCharacter = CharacterPersistence.GetCharacterJSONFile(path);
            var exception = Assert.ThrowsException<AggregateException>(() => CharacterPersistence.LoadCharacter(deserializedCharacter));

            ///Assert

            StringAssert.Contains("One or more errors have been encountered (Head Roundness must be a value of 0 - 100)", exception.Message);

        }


        [TestMethod]
        public void LoadCharacterTest_InvalidCharacterJSON()
        {
            ///Arrange

            string path = @"c:\Users\atamp\source\repos\Toasty-Assignments\5 - RPG\Characters\InvalidCharacterJSON.json";

            ///Act

            string deserializedCharacter = CharacterPersistence.GetCharacterJSONFile(path);
            var exception = Assert.ThrowsException<JsonReaderException>(() => CharacterPersistence.LoadCharacter(deserializedCharacter));

            ///Assert

            StringAssert.Contains("This is not a valid character file.", exception.Message);

        }

    }
}
