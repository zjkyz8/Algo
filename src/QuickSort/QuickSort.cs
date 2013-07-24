namespace QuickSort
{
    public class QuickSort
    {
        public int[] Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
            return array;
        }

        void Sort(int[] array, int headIndex, int tailIndex)
        {
            if(headIndex>=tailIndex)
                return;
            var middleIndex = (tailIndex + headIndex)/2;
            var middleValue = array[middleIndex];
            var leftIndex = headIndex - 1;
            var rightIndex = tailIndex + 1;

            while (true)
            {
                do
                {
                    leftIndex++;
                } while (array[leftIndex] < middleValue);

                do
                {
                    rightIndex--;
                } while (array[rightIndex] > middleValue);
                
                if(leftIndex>=rightIndex)
                    break;
                var temp = array[leftIndex];
                array[leftIndex] = array[rightIndex];
                array[rightIndex] = temp;
            }
            Sort(array, headIndex, leftIndex - 1);
            Sort(array, rightIndex+1, tailIndex);

        }
    }
}
