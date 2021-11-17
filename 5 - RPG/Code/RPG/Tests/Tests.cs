using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Code.CharacterBuilder;
using RPG.Code.CharacterBuilder.CharacterAttributes;
using RPG.Code.CharacterBuilder.CharacterStats;


namespace RPG.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CharacterTest_HappyPath()
        {
            ///Arrange
            Attributes attributes1 = new Attributes(69, "NotFit", 69);
            Stats stats1 = new Stats(10,10,10,10,10,10);
            Character character = new Character(attributes1, stats1);

            ///Act

            var actual = character.CharacterIsValid;

            ///Assert

            Assert.IsTrue(actual);

        }
    }
}
