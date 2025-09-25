using System;

namespace DisplayASequenceOfUniqueRandomValues
{
    class Program
    {
        private static void DisplayASequenceOfUniqueRandomValues(int lowerBound, int upperBound, int sequenceLength)
        {
            int[] sequence = new int[upperBound - lowerBound];
            Random rand = new Random();

            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = lowerBound + i;
            }

            for (int x = sequenceLength; x >= 1; x--)
            {
                int index = rand.Next(x);
                Console.Write(sequence[index] + " ");
                sequence[index] = sequence[x];
            }
        }

        public static void Main(String[] args)
        {
            DisplayASequenceOfUniqueRandomValues(1, 100, 100);
        }
    }
}
