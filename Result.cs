class Result
{
    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */
    public static int simpleArraySum(List<int> ar)
    {
        int sum = 0;
        foreach (int i in ar)
        {
            sum += i;
        }
        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string? outputPath = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
        if (outputPath == null)
        {
            throw new ArgumentNullException(nameof(outputPath), "Output path cannot be null");
        }

        TextWriter textWriter = new StreamWriter(outputPath, true);

        string? input = Console.ReadLine();
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input), "Input cannot be null");
        }
        int arCount = Convert.ToInt32(input.Trim());

        input = Console.ReadLine();
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input), "Input cannot be null");
        }
        List<int> ar = input.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
