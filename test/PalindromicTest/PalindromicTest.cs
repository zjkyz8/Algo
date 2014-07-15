using NUnit.Framework;

namespace PalindromicTest
{
    public class PalindromicTest
    {
        [Test]
        public void should_return_true_when_one_digit()
        {
//            Palindromic.Palindromic.Test(7).Should().BeTrue();
            Assert.IsTrue(Palindromic.Palindromic.Test(7));
        }

        [Test]
        public void should_return_false_when_two_different_digit()
        {
            //            Palindromic.Palindromic.Test(7).Should().BeTrue();
            Assert.IsFalse(Palindromic.Palindromic.Test(72));
        }

        [Test]
        public void should_return_false_when_three_different_digit()
        {
            //            Palindromic.Palindromic.Test(7).Should().BeTrue();
            Assert.IsFalse(Palindromic.Palindromic.Test(728));
        }

        [Test]
        public void should_return_false_when_three_same_digit()
        {
            //            Palindromic.Palindromic.Test(7).Should().BeTrue();
            Assert.IsTrue(Palindromic.Palindromic.Test(727));
        }

    }
}
