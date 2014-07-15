using System;

namespace Palindromic
{
    public class Palindromic
    {
        public static Boolean Test(int i)
        {
            char[] charArray = i.ToString().ToCharArray();
            int frontIndex;
            int endIndex;
            if (charArray.Length%2 == 0)
            {
                endIndex = charArray.Length/2;
                frontIndex = endIndex - 1;

            }
            else
            {
                endIndex = charArray.Length / 2 + 1;
                frontIndex = charArray.Length / 2 - 1;
            }

            
            while (frontIndex >= 0 && endIndex <= charArray.Length)
            {
                if (charArray[frontIndex] != charArray[endIndex])
                {
                    return false;
                }
                frontIndex--;
                endIndex++;
            }
            return true;
        }
    }
}