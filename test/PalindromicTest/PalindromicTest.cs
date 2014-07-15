using System;
using FluentAssertions;
using NUnit.Framework;

namespace PalindromicTest
{
    public class PalindromicTest
    {
        [Test]
        public void should_return_true_when_one_digit()
        {
            Palindromic.Palindromic.Test(new Random().Next(0, 9)).Should().BeTrue();
        }

        [Test]
        public void should_return_true_when_three_digit_palindromic()
        {
            Palindromic.Palindromic.Test(787).Should().BeTrue();
        }

        [Test]
        public void should_return_false_when_three_digit_non_palindromic()
        {
            Palindromic.Palindromic.Test(733).Should().BeFalse();
        }

        [Test]
        public void should_return_false_when_two_digit_non_palindromic()
        {
            Palindromic.Palindromic.Test(72).Should().BeFalse();
        }

        [Test]
        public void should_return_true_when_two_digit_palindromic()
        {
            Palindromic.Palindromic.Test(77).Should().BeTrue();
        }
    }
}