using System;

class URI
{

    static void Main(string[] args)
    {

        double.TryParse(Console.ReadLine(), out double A);
        double.TryParse(Console.ReadLine(), out double B);
        double.TryParse(Console.ReadLine(), out double C);
        double media = (A * 2 + B * 3 + C * 5) / 10;
        Console.WriteLine($"MEDIA = {media:F1}");

    }

}