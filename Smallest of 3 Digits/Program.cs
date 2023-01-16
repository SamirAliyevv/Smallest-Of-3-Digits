using System;

namespace Smallest_of_3_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 4;
            int c = 4;
            if (a >= b && a >= c)
            {
                Console.WriteLine("A ededi en boyuk ededdir");
            }
            else if (b >= c && b >= a)
            {

                Console.WriteLine(" B ededi en boyuk ededdir");
            }
            else
            {
                Console.WriteLine("C  ededi en boyuk ededdir");
            }
        }
    }
}
