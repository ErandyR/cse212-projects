public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // TODO problem 2
        // 1. Create a new list to hold the selected values.
        // 2. Use a for loop to iterate through the select array.
        // 3. In each iteration, check the value of the current index in the select array.
        // 4. If the value is 1, add the corresponding value from list1 to the new list.
        // 5. If the value is 2, add the corresponding value from list2 to the new list.
        var result = new int[select.Length];
        var l1Idx = 0;
        var l2Idx = 0;
        for (var i = 0; i < select.Length; i++)
        {
            result[i] = select[i] == 1 ? list1[l1Idx++] : list2[l2Idx++];
        }

        return result;
    }
}