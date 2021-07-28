using System;

namespace ConsoleApp2
{
    class Program
    {
        public static int factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public static void Main(string[] args)
        {
            int n=1;
            int tnum=0;
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 1){
                while (factorial(n) < num)
                {
                    //int tnum;
                    tnum = factorial(n);
                    n++;
                }
            }
            else
            {
                tnum = -1;
            }

            Console.WriteLine(tnum);
            Console.ReadKey();
            
        }
    }
}
