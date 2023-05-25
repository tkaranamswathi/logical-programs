namespace UC1_FIBONACCI
{
    internal class Program
    {
       public static void Main(string[] args)
       { 
            Console.WriteLine("welcome to fibonacci");
            Console.WriteLine("please enter any number");
            int n=Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, sum = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < n; i++)
            {
                sum = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = sum;
            }
             
       }
    }
}
