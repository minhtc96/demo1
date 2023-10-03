using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cac so co 3 chu so, tong chu so la chan tu 100 đen 999:");
        for (int i = 100; i <= 999; i++)
        {
            int digitSum = SumOfDigits(i);
            if (digitSum % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}