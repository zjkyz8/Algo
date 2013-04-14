using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace InsertionSortTest
{
    public class InsertionSortTests
    {
        [Test]
        public void should_return_array_when_only_contain_one_item()
        {
            var seq = new List<int> {1};

            InsertionSort.InsertionSort.Sort(seq).Should().Equal(seq);
        }

        [Test]
        public void should_return_array_with_asc_order_when_contaion_two_items_with_des_order()
        {
            var seq = new List<int> { 2, 1 };

            List<int> result = InsertionSort.InsertionSort.Sort(seq);
            result.Should().Contain(seq);
            result.Should().BeInAscendingOrder();
        }

        [Test]
        public void should_return_array_with_asc_order_when_contain_three_items_with_ins_order()
        {
            var seq = new List<int> { 2, 5, 9 };

            List<int> result = InsertionSort.InsertionSort.Sort(seq);
            result.Should().Contain(seq);
            result.Should().BeInAscendingOrder();
        }

        [Test]
        public void should_return_array_with_asc_order_when_contain_five_items_without_order()
        {
            var seq = new List<int> { 2, 10, 1, 8, 4 };

            List<int> result = InsertionSort.InsertionSort.Sort(seq);
            result.Should().Contain(seq);
            result.Should().BeInAscendingOrder();
        }
    }
}