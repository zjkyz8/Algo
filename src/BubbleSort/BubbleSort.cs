namespace BubbleSort
{
    public class BubbleSort
    {
        public int[] Sort(int[] array)
        {
            for (var outter = 1; outter < array.Length; outter++ )
            {
                for (int innter = array.Length-1; innter >= outter; innter--)
                {
                    if (array[innter] < array[innter - 1])
                    {
                        var temp = array[innter - 1];
                        array[innter - 1] = array[innter];
                        array[innter] = temp;
                    }
                }
            }
            return array;
        }
    }
}
