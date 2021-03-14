using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that value grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            // any value with less than 4 digits will not have commas 
            if ((string.Empty + value).Length < 4) return string.Empty + value;

            // initialize formatted string
            var formattedNumber = string.Empty;

            // convert the value string to an array of digits 
            var valueArray = (string.Empty + value).ToCharArray();

            var arrayLength = valueArray.Length;

            // a comma is added to the right of a digit if the modulus of the
            // array length minus the index of the digit is 1
            // and if the value of digits to the right of the digit is greater than 3
            for (var i = 0; i < arrayLength; i++)
            {
                if ((arrayLength - i) % 3 == 1 && arrayLength - i > 3)
                {
                    formattedNumber += valueArray[i] + ",";
                }
                else
                {
                    formattedNumber += valueArray[i];
                }
            }

            return formattedNumber;
        }
    }
}
