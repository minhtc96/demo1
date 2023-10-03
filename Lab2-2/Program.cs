using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so giay: ");
        int soGiay = int.Parse(Console.ReadLine());

        int gio = soGiay / 3600;
        int phut = (soGiay % 3600) / 60;
        int giay = soGiay % 60;

        string gioStr = gio.ToString().PadLeft(2, '0');
        string phutStr = phut.ToString().PadLeft(2, '0');
        string giayStr = giay.ToString().PadLeft(2, '0');

        Console.WriteLine($"Dinh dang gio:phut:giay la {gioStr}:{phutStr}:{giayStr}");
    }
}