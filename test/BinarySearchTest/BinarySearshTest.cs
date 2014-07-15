using FluentAssertions;
using NUnit.Framework;

namespace BinarySearchTest
{
    public class BinarySearshTest
    {
        [Test]
        public void should_return_0_first_one_is_the_value_()
        {
            var array = new[] {1, 6, 9, 73, 90};
            new BinarySearch.BinarySearch().Search(array, 1).Should().Be(0);
        }

        [Test]
        public void should_return_3_third_one_is_the_value_()
        {
            var array = new[] { 1, 6, 9, 73, 90 };
            new BinarySearch.BinarySearch().Search(array, 73).Should().Be(3);
        }
    }
}
