class Program
{
    public static void Main(string[] args)
    {
        Iteration1();
    }

    public static void Iteration1()
    {
        int answer1, answer2, answer3;

        Console.WriteLine("How do you handle stress? Rate from 1 - 10");
        answer1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Do like playing outdoor? 1. yes  2. no");
        answer2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Do like nature? 1. yes  2. no");
        answer3 = Convert.ToInt32(Console.ReadLine());
    }
}