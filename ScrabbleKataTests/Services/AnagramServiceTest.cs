using NUnit.Framework;
using ScrabbleKata.Services;

namespace ScrabbleKataTests.Services
{
    [TestFixture]
    public class AnagramServiceTest
    {
        [Test]
        public void AnagramServiceReturnsTrueWithAnagram()
        {
            var anagramService = new AnagramService();

            var result = AnagramService.AreStringsAnagrams("one", "eno");

            Assert.That(result, Is.True);
        }

    }
}
