using FluentAssertions;
using NUnit.Framework;

namespace QuickSortTest
{
    public class QuickSortTest
    {
        [Test]
        public void should_return_array_with_correct_order_when_given_array_with_two_ordered_items()
        {
            var array = new[] {1, 2};
            new QuickSort.QuickSort().Sort(array).Should().BeInAscendingOrder();
        }

        [Test]
        public void should_return_array_with_correct_order_when_given_array_with_one_item()
        {
            var array = new[] { 2 };
            new QuickSort.QuickSort().Sort(array).Should().BeInAscendingOrder();
        }

        [Test]
        public void should_return_array_with_correct_order_when_given_array_with_two_non_ordered_items()
        {
            var array = new[] { 2, 1 };
            new QuickSort.QuickSort().Sort(array).Should().BeInAscendingOrder();
        }

        [Test]
        public void should_return_array_with_correct_order_when_given_array_with_five_non_ordered_items()
        {
            var array = new[] { 2, 0, 8, 5, 1 };
            new QuickSort.QuickSort().Sort(array).Should().BeInAscendingOrder();
        }
    }
}
