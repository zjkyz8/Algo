using System.Collections.Generic;

namespace InsertionSort
{
    public class InsertionSort
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<int> Sort(List<int> seqInts)
        {
            for (int i = 0; i < seqInts.Count; i++)
            {
                var min=seqInts[i]; 
                for (int j = i; j < seqInts.Count; j++)
                {
                    if (seqInts[j] < min)
                        min = seqInts[j];
                }
                seqInts.Remove(min);
                seqInts.Insert(i, min);
            }
            return seqInts;
        }
    }
}
