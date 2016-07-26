using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ScrabbleKata.Services;

namespace ScrabbleKataTests.Services
{
    [TestFixture]
    public class ScrabbleServiceTest
    {
        [Test]
        public void GetLongestWordReturnsLongestWordIfWordExists()
        {
            char[] inputChars = {'r', 'e', 's', 'c', 'o', 'u', 's'};
            var scrabbleService = new ScrabbleService();
            const string expectedResult = "scouser";

            var actualResult = scrabbleService.GetLongestWord(inputChars);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void GetLongestWordReturnsNullIfWordDoesntExist()
        {
            char[] inputChars = { 'z', 'z', 'z', 'z', 'z', 'z', 'z' };
            var scrabbleService = new ScrabbleService();

            var actualResult = scrabbleService.GetLongestWord(inputChars);

            Assert.That(actualResult, Is.Null);
        }



    }
}
