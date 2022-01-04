using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCount.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void LineCounter_GivenText_StringWithCountOfLines()
        {
            //Arrange
            string text = "bla blabla bla b l a \n" +
                          "bla blabla bla b l a \n" +
                          "bla blabla bla b l a";

            //Act
            string result = Program.LineCounter(text);

            //Assert
            Assert.AreEqual(result, "Lines = 3");
        }

        [TestMethod]
        public void WordsCounter_GivenText_StringWithCountOfWords()
        {
            //Arrange
            string text = "bla blabla bla b l a " +
                          "bla blabla bla b l a " +
                          "bla blabla bla b l a";

            //Act
            string result = Program.WordsCounter(text);

            //Assert
            Assert.AreEqual(result, "Words = 18");
        }

        [TestMethod]
        public void CharsCounter_GivenText_StringWithCountOfChars()
        {
            //Arrange
            string text = "bla blabla bla b l a " +
                          "bla blabla bla b l a " +
                          "bla blabla bla b l a";

            //Act
            string result = Program.CharsCounter(text);

            //Assert
            Assert.AreEqual(result, "Chars = 62");
        }
    }
}
