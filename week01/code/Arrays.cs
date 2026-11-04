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
        // 1. Create a new array of doubles with the specified length.
        // 2. Use a for loop to iterate from 0 to length - 1
        // 3. In each iteration, calculate the multiple of the number by multiplying it with (i + 1)
        // 4. Assign the calculated multiple to the corresponding index in the result array.
        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result; // replace this return statement with your own
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

        // 1. Create a new list to hold the rotated values.
        // 2. Use a for loop to iterate through the original list starting from the index
        //    (data.Count - amount) to the end of the list and add those elements to the new list.
        // 3. Use another for loop to iterate from the start of the original list to
        //    the index (data.Count - amount) and add those elements to the new list.
        // 4. Clear the original list and add all elements from the new list to it.
        List<int> rotated = new List<int>();
        for (int i = data.Count - amount; i < data.Count; i++)
        {
            rotated.Add(data[i]);
        }
        for (int i = 0; i < data.Count - amount; i++)
        {
            rotated.Add(data[i]);
        }
        data.Clear();
        data.AddRange(rotated);
    }
}
