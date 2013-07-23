using FluentAssertions;
using NUnit.Framework;

namespace BubbleSortTest
{
    public class BubbleSortTest
    {
        [Test]
        public void should_return_array_with_correct_order_when_given_array_contain_two_ordered_items()
        {
            var array = new[] {1, 2};

            var orderedArray = new BubbleSort.BubbleSort().Sort(array);
            orderedArray.Should().BeInAscendingOrder();
        }

        [Test]
        public void should_return_array_with_correct_order_when_given_array_contain_two_non_ordered_items()
        {
            var array = new[] { 2, 1 };

            var orderedArray = new BubbleSort.BubbleSort().Sort(array);
            orderedArray.Should().BeInAscendingOrder();
        }

        [Test]
        public void should_return_array_with_correct_order_when_given_array_contain_three_non_ordered_items()
        {
            var array = new[] {3, 2, 1 };

            var orderedArray = new BubbleSort.BubbleSort().Sort(array);
            orderedArray.Should().BeInAscendingOrder();
        }

        [Test]
        public void should_return_array_with_correct_order_when_given_array_contain_five_non_ordered_items()
        {
            var array = new[] { 3, 2, 1, 5, 4 };

            var orderedArray = new BubbleSort.BubbleSort().Sort(array);
            orderedArray.Should().BeInAscendingOrder();
        }
    }
}
