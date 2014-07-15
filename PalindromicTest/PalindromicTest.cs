using FluentAssertions;
using NUnit.Framework;

namespace PalindromicTest
{
    public class PalindromicTest
    {
        [Test]
        public void should_return_ture_when_it_is_a_palindromic()
        {
            Palindromic.Palindromic.Test(7).Should().BeTrue();
        }
    }
}
