using System;

namespace Programs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Kaç terim olacağını belirtiniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            Calculate(n);
        }

        public static int Fibonacci(int k)
        {
            if (k <= 1) // k 0 veya 1 olduğunda 
            {
                return k; // k 0 ise 0, k 1 ise 1 döner
            }
            else
            {
                return Fibonacci(k - 1) + Fibonacci(k - 2);
            }
        }

        public static void Calculate(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Fibonacci(i);
            }
            double result = (double)sum / n; // Ortalamayı hesaplamak için sum'ı n'e böl
            Console.WriteLine("Ortalama: " + result);
        }
    }
}


