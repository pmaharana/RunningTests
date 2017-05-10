using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunningTests;

namespace UnitTestProject1
{
    [TestClass]
    public class AngramTests
    {
        [TestMethod]
        public void SimpleSentence()
        {
            //Arrange
            var hacker = new Hacker();
            //Act
            var testing = hacker.Pangram("The bulletin board on the wall explains: A sentence that uses ever");
            //Assert
            Assert.AreEqual("not pangram", testing);
        }

        [TestMethod]
        public void ComplicatedSentence()
        {
            var hacker = new Hacker();
            var testing = hacker.Pangram("We promptly judged antique ivory buckles for the next prize");
            Assert.AreEqual("pangram", testing);
        }

        [TestMethod]
        public void SentenceLongerThanAlphabetLength()
        {
            var hacker = new Hacker();
            var testing = hacker.Pangram("Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit");
            Assert.AreEqual("not pangram", testing);
        }

        [TestMethod]
        public void BlankSentence()
        {
            var hacker = new Hacker();
            var testing = hacker.Pangram("    ");
            Assert.AreEqual("not pangram", testing);
        }

        [TestMethod]
        public void NumbersAndSpecialCharacters()
        {
            var hacker = new Hacker();
            var testing = hacker.Pangram("52752352##  ???99900");
            Assert.AreEqual("not pangram", testing);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void StringIsNull()
        {
            var hacker = new Hacker();
            hacker.Pangram(null);
        }

    }
}
