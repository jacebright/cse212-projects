using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // create a for loop to iterate through the closest mulitples and append
        // them to a list called 'mulitples'

        // In this case we can use a defined length of list because we will always
        // know the length
        double[] multiples = new double[length];

        for(int i = 1; i <= length; i++){
            multiples[i-1] = number * i;
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // slice the list into two parts - the first part containing the numbers
        // needing to be brought to the front of the array, the second part to 
        // include those that are being shifted to the end. Then remove all other
        // data and add the slices in.

        List<int> firstSlice = data.GetRange(data.Count - amount, amount);
        List<int> secondSlice = data.GetRange(0, data.Count - amount);
        data.RemoveRange(0, data.Count);
        data.InsertRange(0, firstSlice);
        data.AddRange(secondSlice);
    }
}
