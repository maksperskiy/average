using System;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Average(int.MinValue, int.MinValue));
            Console.WriteLine(Average(int.MinValue, -2));
            Console.WriteLine(Average(int.MinValue, -1));
            Console.WriteLine(Average(int.MinValue, 0));
            Console.WriteLine(Average(int.MinValue, 1));
            Console.WriteLine(Average(int.MinValue, 2));
            Console.WriteLine(Average(0, 0));
            Console.WriteLine(Average(0, 1));
            Console.WriteLine(Average(1, 1));
            Console.WriteLine(Average(2, 2));
            Console.WriteLine(Average(2, 3));
            Console.WriteLine(Average(5, 5));
            Console.WriteLine(Average(int.MaxValue, 1));
            Console.WriteLine(Average(int.MaxValue, 2));
            Console.WriteLine(Average(int.MaxValue, int.MaxValue));
        }

        public static int Average(int a, int b)
        {
            var ha = a / 2;
            var ra = a % 2;

            var hb = b / 2;
            var rb = b % 2;

            var avg = ha + hb + ((ra == 1 || rb == 1) ? 1 : 0);

            return avg;
        }
    }
}
