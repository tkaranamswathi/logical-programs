namespace UC4REVERSEPROGRAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to reverse number");
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int reminder, reverse = 0;
            while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;
            }
            Console.WriteLine($"The Reverse order is : {reverse}");
            Console.ReadKey();
        }
    }
}