using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Code;
using System.IO;

namespace RPG.Tests
{
    [TestClass]
    public class SaveCharacterTests
    {
        [TestMethod]
        public void SerializeTest_HappyPath()
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

            string expected = "{\"CharacterName\":\"Billy\",\"Attributes\":{\"convertedHeight\":\"5'9\",\"HeadRoundness\":69,\"FitnessLevel\":\"NotFit\",\"HeightInInches\":69},\"Stats\":{\"Intelligence\":10,\"Wisdom\":10,\"Dexterity\":10,\"Strength\":10,\"Charisma\":10,\"Constitution\":10}}";

            ///Act

            CharacterAttributes attributes1 = new CharacterAttributes(headRoundness, fittnessLevel, heightInInches);
            CharacterStats stats1 = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);
            Character character = new Character(name, attributes1, stats1);
            string serializedCharacter = CharacterPersistence.SerializeCharacter(character);

            ///Assert

            Assert.AreEqual(expected, serializedCharacter);
        }
        [TestMethod]
        public void CharacterSaveTest_HappyPath()
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

            string expected = "{\"CharacterName\":\"Billy\",\"Attributes\":{\"convertedHeight\":\"5'9\",\"HeadRoundness\":69,\"FitnessLevel\":\"NotFit\",\"HeightInInches\":69},\"Stats\":{\"Intelligence\":10,\"Wisdom\":10,\"Dexterity\":10,\"Strength\":10,\"Charisma\":10,\"Constitution\":10}}";

            ///Act

            CharacterAttributes attributes1 = new CharacterAttributes(headRoundness, fittnessLevel, heightInInches);
            CharacterStats stats1 = new CharacterStats(intelligence, wisdom, dexterity, strength, charisma, constitution);
            Character character = new Character(name, attributes1, stats1);
            string serializedCharacter = CharacterPersistence.SerializeCharacter(character);
            CharacterPersistence.SaveCharacter(character, path);

            ///Assert

            Assert.AreEqual(expected, serializedCharacter);
            Assert.IsTrue(File.Exists(path));
        }
    }
}
