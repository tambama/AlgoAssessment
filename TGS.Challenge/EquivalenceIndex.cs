namespace TGS.Challenge
{
    /*
         Given a zero-based integer numbers of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
         are equal to the sum of all the items to the right of the index.

         Constraints: 0 <= N <= 100 000

         Example: Given the following numbers [1, 2, 3, 4, 5, 7, 8, 10, 12]
         Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

         If no index exists then output -1

         There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */

    public class EquivalenceIndex
    {
        // The equivalence index is found by finding the index
        // where the prefix sum of two arrays is the same. These two
        // arrays are created by generating a forwards prefix sum array
        // and a reverse prefix sum array.
        public int Find(int[] numbers)
        {
            var length = numbers.Length;

            if (length == 0) return -1;

            // initialize arrays of sums for the forward and backward iterations
            var leftSumArray = new int[length];
            var rightSumArray = new int[length];

            // iterate forwards getting the prefix sum
            for (var i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    leftSumArray[i] = numbers[i];
                }
                else
                {
                    leftSumArray[i] = numbers[i] + leftSumArray[i - 1];
                }
            }

            // iterate backwards getting the prefix sum
            for (var i = length - 1; i >= 0; i--)
            {
                if (i == length - 1)
                {
                    rightSumArray[i] = numbers[i];
                }
                else
                {
                    rightSumArray[i] = numbers[i] + rightSumArray[i + 1];
                }
            }

            // the index where the left sum and the right sum are the same is the equilibrium index
            for (var i = 0; i < length; i++)
            {
                if (leftSumArray[i] == rightSumArray[i])
                {
                    return i;
                }
            }

            // if no equilibrium point is found return zero
            return -1;
        }
    }
}
