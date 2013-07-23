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
            for (int outter = 1; outter < seqInts.Count; outter++)
            {
                for (int inner = outter; inner >= 1; inner--)
                {
                    if (seqInts[inner] < seqInts[inner-1])
                    {
                        var temp = seqInts[inner - 1];
                        seqInts[inner - 1] = seqInts[inner];
                        seqInts[inner] = temp;
                    }
                }                
            }
            return seqInts;
        }
    }
}
