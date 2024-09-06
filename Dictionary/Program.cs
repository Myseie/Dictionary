internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Skriv in en mening här :");

        string input = Console.ReadLine();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            char lowerChar = char.ToLower(c);

            if (charCount.ContainsKey(lowerChar))
            {
                charCount[lowerChar]++;
            }
            else
            {
                charCount[lowerChar] = 1;
            }
        }
        Console.WriteLine("Teckenräkning : ");
        foreach (var item in charCount)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}