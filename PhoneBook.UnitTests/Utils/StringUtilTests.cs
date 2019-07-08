using NUnit.Framework;
using PhoneBook.Utils;

namespace PhoneBook.UnitTests {
    [TestFixture]
    public class StringUtilTests {
        [Test]
        [TestCase(" A b C D e f g H i J              ", "AbCDefgHiJ")]
        [TestCase("abdj kloem op", "abdjkloemop")]
        [TestCase("abcdefghij", "abcdefghij")]
        public void RemoveAllSpaces_WhenCalled_ReturnsStringWithoutSpaces(string input, string expectedOutput) {
            Assert.That(StringUtil.RemoveAllSpaces(input), Is.EqualTo(expectedOutput));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("    ")]
        public void RemoveAllSpaces_GivenNullInput_ReturnsEmptyString(string input) {
            Assert.That(StringUtil.RemoveAllSpaces(input), Is.EqualTo(""));
        }

        [Test]
        [TestCase("124", true)]
        [TestCase("47653", true)]
        [TestCase(" 5875 ", true)]
        [TestCase(" 8 9 7 3", true)]
        [TestCase("abcd", false)]
        [TestCase("a5b8j4442", false)]
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("      ", false)]
        public void IsANumber_WhenCalled_ReturnsIfStringIsANumber(string inp, bool expectNumber) {
            Assert.That(StringUtil.IsANumber(inp), Is.EqualTo(expectNumber));
        }

        [Test]
        public void ClampStringAtLimits_WhenCalled_ReturnsClampedString() {
            Assert.That(StringUtil.ClampStringAtLimits("abcdef", 1, 4), Is.EqualTo("bcde"));
        }

        [Test]
        public void ClampStringAtLimits_WhenLowBiggerThanHigh_ReturnsEmptyString() {
            Assert.That(StringUtil.ClampStringAtLimits("abcdef", 4, 1), Is.EqualTo(""));
        }
    }
}