using System;

namespace MergeSort
{
    public class MergeSort
    {
        public static int[] Sort(int[] seqInt, long head, long tail)
        {
            long arrayLength = tail - head + 1;
            var result = new int[arrayLength];
            if (tail - head <= 0)
            {
                Array.Copy(seqInt, head, result, 0, tail - head + 1);
                return result;
            }
            int[] firstPart = Sort(seqInt, head, (head + tail)/2);
            int[] secondPart = Sort(seqInt, (head + tail)/2 + 1, tail);

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