using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;
            
                if (original == null)
                {
                    throw new ArgumentNullException("original");
                }
                if (current == null)
                {
                    throw new ArgumentNullException("current");
                }
                if ((original.Length > current.Length) || (original.Length < current.Length))
                    throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");

                original = original.ToUpper();
                current = current.ToUpper();
                if (original.Length == current.Length)
                {
                    for (int i = 0; i < original.Length; i++)
                    {
                        if (original[i] != current[i])
                        {
                            hammingDistance += 1;
                        }
                    }
                }
            return hammingDistance;

        }
    }
}
