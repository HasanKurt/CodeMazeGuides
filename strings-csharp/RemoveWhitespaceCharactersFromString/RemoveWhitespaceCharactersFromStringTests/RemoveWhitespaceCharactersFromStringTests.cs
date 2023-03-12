using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveWhitespaceCharactersFromString;

namespace RemoveWhitespaceCharactersFromStringTests
{
    [TestClass]
    public class RemoveWhitespaceCharactersFromStringTests
    {
        [TestMethod]
        public void GivenStringWithWhitespaces_WhenUsingRegex_ThenResultStringDoesntContainWhitespace()
        {
            string source = " \t hello worl d \r\n ";

            string result = RemoveWhitespaceMethods.RemoveWhitespacesUsingRegex(source);

            Assert.AreEqual("helloworld", result);
        }

        [TestMethod]
        public void GivenStringWithWhitespaces_WhenUsingLinq_ThenResultStringDoesntContainWhitespace()
        {
            var source = " \t hello worl d";

            var result = RemoveWhitespaceMethods.RemoveWhitespacesUsingLinq(source);

            Assert.AreEqual("helloworld", result);
        }
        
        [TestMethod]
        public void GivenStringWithWhitespaces_WhenUsingStringReplace_ThenResultStringDoesntContainWhitespace()
        {
            var source = " hello worl d";

            var result = RemoveWhitespaceMethods.RemoveSpacesUsingReplace(source);

            Assert.AreEqual("helloworld", result);
        }
        
        [TestMethod]
        public void GivenStringWithTab_WhenUsingStringReplace_ThenResultStringContainsTab()
        {
            var source = "\t hello";

            var result = RemoveWhitespaceMethods.RemoveSpacesUsingReplace(source);

            Assert.AreEqual("\thello", result);
        }
        
        [TestMethod]
        public void GivenStringWithWhitespaces_WhenUsingStringTrim_ThenResultStringDoesntContainLeadingOrTrailingWhitespace()
        {
            var source = "  \t John Doe ";

            var result = RemoveWhitespaceMethods.RemoveLeadingAndTrailingWhitespacesUsingTrim(source);

            Assert.AreEqual("John Doe", result);
        }

        [TestMethod]
        public void GivenStringWithWhitespaces_WhenUsingStringBuilder_ThenResultStringDoesntContainWhitespace()
        {
            var source = "  \t John Doe \r\n ";

            var result = RemoveWhitespaceMethods.RemoveWhitespacesUsingStringBuilder(source);

            Assert.AreEqual("JohnDoe", result);
        }
    }
}