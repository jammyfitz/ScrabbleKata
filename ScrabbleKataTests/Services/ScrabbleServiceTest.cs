using NUnit.Framework;
using ScrabbleKata.Services;

namespace ScrabbleKataTests.Services
{
    [TestFixture]
    public class ScrabbleServiceTest
    {
        [Test]
        public void GetLongestWordReturnsLongestWord()
        {
            char[] inputChars = {'r', 'e', 's', 'c', 'o', 'u', 's'};
            var scrabbleService = new ScrabbleService();
            const string expectedResult = "scouser";

            var actualResult = scrabbleService.GetLongestWord(inputChars);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

    }
}
