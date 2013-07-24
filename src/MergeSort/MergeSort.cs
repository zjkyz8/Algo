using System;

namespace MergeSort
{
    public class MergeSort
    {
        public static int[] Sort(int[] seqInt, long headIndex, long tailIndex)
        {
            long arrayLength = tailIndex - headIndex + 1;
            var result = new int[arrayLength];
            if (tailIndex - headIndex <= 0)
            {
                Array.Copy(seqInt, headIndex, result, 0, tailIndex - headIndex + 1);
                return result;
            }
            int[] firstPart = Sort(seqInt, headIndex, (headIndex + tailIndex)/2);
            int[] secondPart = Sort(seqInt, (headIndex + tailIndex)/2 + 1, tailIndex);

            long firstIndex = 0, secondIndex = 0;
            for (long i = 0; i < arrayLength; i++)
            {
                if (secondIndex >= secondPart.Length)
                {
                    result[i] = firstPart[firstIndex];
                    firstIndex++;
                }
                else if (firstIndex >= firstPart.Length)
                {
                    result[i] = secondPart[secondIndex];
                    secondIndex++;
                }
                else if (firstPart[firstIndex] < secondPart[secondIndex])
                {
                    result[i] = firstPart[firstIndex];
                    firstIndex++;
                }
                else
                {
                    result[i] = secondPart[secondIndex];
                    secondIndex++;
                }
            }
            return result;
        }
    }
}