using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

namespace UC5COUPONNUMBERS
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to coupon  numbers");
            Random random = new Random();
            String str = "abcdefghijklmnopqrstuvwxyz0123456789";
            int size = 6;
            int n= 0;
            Console.WriteLine("please enter any number for how many number of times to generate a coupon ");
            int x=Convert.ToInt32(Console.ReadLine());
          for (n = 0; n < x; n++) 
            {
                Console.WriteLine(n);
                String randomstring = " ";

                for (int i = 0; i < size; i++)
                {
                    int y = random.Next(str.Length);
                    randomstring = randomstring + str[y];
                }
                Console.WriteLine("coupon code:" + randomstring);
            }
        }
    }
}
