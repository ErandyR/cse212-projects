public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run() {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number) {
        List<int> results = new();
        // TODO problem 1
        // 1. Create a new list to hold the divisors.
        // 2. Use a for loop to iterate from 1 to number - 1.
        // 3. In each iteration, check if the number is divisible by the current index using modulo.
        // 4. If it is divisible, add the current index to the list of divisors.
        for (int i = 1; i < number; i++) {
            if (number % i == 0) {
                results.Add(i);
            }
        }   
        
        return results;
    }
}