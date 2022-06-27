using System;
using System.Text;

namespace FibonacciLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Reset();

            sw.Start();

            Console.WriteLine(Fibonacci_StringBuilder(100));
            //Console.WriteLine(Fibonacci(100));

            sw.Stop();

            string result1 = sw.Elapsed.TotalMilliseconds.ToString();

            Console.WriteLine(result1);

        }

        static string Fibonacci(int n)
        {
            StringBuilder sqlCmd = new StringBuilder("");
            string s = "";

            decimal temp0 = 1;
            decimal temp1 = 1;

            s += ("Fibo" + temp0 + " ");
            s += ("Fibo" + temp1 + " ");

            for (int i = 0; i < n - 2; i++)
            {
                decimal temp = temp0 + temp1;

                s += ("Fibo" + temp + " ");

                temp0 = temp1;
                temp1 = temp;
            }

            return s;
        }

        static StringBuilder Fibonacci_StringBuilder(int n)
        {

            StringBuilder sqlCmd = new StringBuilder("");

            decimal temp0 = 1;
            decimal temp1 = 1;

            sqlCmd.Append("Fibo" + temp0 + " ");
            sqlCmd.Append("Fibo" + temp1 + " ");

            for (int i = 0; i < n - 2; i++)
            {
                decimal temp = temp0 + temp1;

                sqlCmd.Append("Fibo" + temp + " ");

                temp0 = temp1;
                temp1 = temp;
            }

            return sqlCmd;
        }
    }
}
