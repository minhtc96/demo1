using System;

class Program
{
    static void Main()
    {
        int n = 6; // Số dòng (số hàng) của hình

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("$");
            }
            Console.WriteLine(); // Xuống dòng sau khi in mỗi dòng
        }
    }
}