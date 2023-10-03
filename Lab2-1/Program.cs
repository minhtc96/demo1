using System;

class Program
{
    static int SoNgayTrongThang(int nam, int thang)
    {
        if (thang < 1 || thang > 12)
        {
            return -1; 
        }

        if (thang == 2)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            {
                return 29; 
            }
            else
            {
                return 28;
            }
        }
        else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
        {
            return 30; 
        }
        else
        {
            return 31; 
        }
    }
    static void Main()
    {
        Console.Write("Nhap vao nam: ");
        int nam = int.Parse(Console.ReadLine());

        Console.Write("Nhap vào thang: ");
        int thang = int.Parse(Console.ReadLine());

        int soNgayTrongThang = SoNgayTrongThang(nam, thang);
        Console.WriteLine($"So ngay trong thang {thang} nam {nam} la: {soNgayTrongThang}");
    }


}
