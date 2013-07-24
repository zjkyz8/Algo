namespace BinarySearch
{
    public class BinarySearch
    {
        public int Search(int[] array, int value)
        {
            return Search(array, value, 0, array.Length - 1);
        }

        private int Search(int[] array, int value, int headIndex, int tailIndex)
        {
            if (headIndex > tailIndex)
                return -1;

            var middleIndex = (headIndex + tailIndex)/2;
            var middleValue = array[middleIndex];    
            if (value < middleValue)
                return Search(array, value, headIndex, middleIndex);
            return value>middleValue ? Search(array, value, middleIndex, tailIndex) : middleIndex;
        }
    }
}
