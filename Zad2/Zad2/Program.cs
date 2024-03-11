// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");
    }
    
    public static int CountAverage(int[] tab)
    {
        int sum = 0;
        int length = tab.Length;
        foreach (int num in tab)
        {
            sum += num;
        }

        return sum / length;
    }

}