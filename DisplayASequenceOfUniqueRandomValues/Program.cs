using System;

namespace DisplayASequenceOfUniqueRandomValues
{
    class Program
    {
        private static void DisplayASequenceOfUniqueRandomValues(int lowerBound, int upperBound, int sequenceLength)
        {
            Random rand = new Random();

            //Determine the size of the array based off of the range provided for the random numbers.
            int[] sequence = new int[upperBound - lowerBound + 1];

            //Populate the array with the numbers within range lowerBound-upperBound inclusive.
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = lowerBound + i;
            }

            //This generates a random index within the array working as a random number within the range.
            //Display the number based on the index then set the value of the index to the current "last" value in the array (this achived through restricting possible indices in random).
            //Then we increment x which in turn reduces the number of accessible indices within the array "shortening" it.
            for (int x = 0; x < sequenceLength; x++)
            {
                int index = rand.Next(upperBound - x);
                Console.Write(sequence[index] + " ");
                sequence[index] = sequence[upperBound - x - 1];

                //This is debug line to check array status.
                // sequence[upperBound - x - 1] = 0;
                // Console.WriteLine(string.Join(' ', sequence));
            }
        }

        public static void Main(String[] args)
        {
            DisplayASequenceOfUniqueRandomValues(1, 50, 40);
        }
    }
}
