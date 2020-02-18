using System;

namespace Laboratory1
{
   public  class Program
    {
       public static void Main(string[] args)
        {
            double x = 0;
            Func(x);
        }
        public static double Func(double a)
        {
            double y = Math.Pow(a, 3) - 4 * Math.Pow(a, 2) - 5 * a + 9 + Math.Cos(a);
            Console.WriteLine(y);
            return y;
        }
    
    }
}
