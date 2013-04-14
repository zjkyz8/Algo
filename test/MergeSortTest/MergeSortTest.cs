using FluentAssertions;
using NUnit.Framework;

namespace MergeSortTest
{
    public class MergeSortTest
    {
        [Test]
        public void should_reuturn_iteself_when_array_contain_one_item()
        {
            var intSeq = new[] {2};

            MergeSort.MergeSort.Sort(intSeq, 0, intSeq.Length-1).Should().Equal(intSeq);
        }

        [Test]
        public void should_return_array_with_asc_order_when_contain_two_items_with_des_order()
        {
            var intSeq = new[] {2, 1};

            int[] result = MergeSort.MergeSort.Sort(intSeq, 0, intSeq.Length-1);

            result.Should().Contain(intSeq);
            result.Should().BeInAscendingOrder();
        }

        [Test]
        public void should_return_array_with_asc_order_when_contain_5_items_with_asc_order()
        {
            var intSeq = new[] { 2, 5, 10, 11, 19 };

            int[] result = MergeSort.MergeSort.Sort(intSeq, 0, intSeq.Length - 1);

            result.Should().Contain(intSeq);
            result.Should().BeInAscendingOrder();
        }

        [Test]
        public void should_return_array_with_asc_order_when_contain_11_items_without_order()
        {
            var intSeq = new[] { 11, 5, 10, 2, 7, 19, 18, 3, 1, 8, 4 };

            int[] result = MergeSort.MergeSort.Sort(intSeq, 0, intSeq.Length - 1);

            result.Should().Contain(intSeq);
            result.Should().BeInAscendingOrder();
        }

    }
}