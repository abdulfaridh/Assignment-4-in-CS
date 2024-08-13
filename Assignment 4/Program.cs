// See https://aka.ms/new-console-template for more information
class Assignment4
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int wordCount =input.Length;
        Console.WriteLine($"Number of words in the string: {wordCount}");
    }
}