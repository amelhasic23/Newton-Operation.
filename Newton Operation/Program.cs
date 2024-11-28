using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to find its square root:");
        double number = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The square root of {number} is approximately: {Sqrt(number)}");
    }

    static double Sqrt(double a)
    {
        if (a < 0)
        {
            Console.WriteLine("Invalid input: Negative number");
            return -1;
        }

        double tolerance = 0.00001;
        double x = 1;

        while (true)
        {
            double val = x * x;
            double difference = Math.Abs(val - a);

            if (difference <= tolerance)
                return x;

            x = 0.5 * (x + (a / x));
        }
    }
}

