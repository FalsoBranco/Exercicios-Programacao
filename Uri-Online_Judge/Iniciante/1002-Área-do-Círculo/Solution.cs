using System; 

class URI {

    static void Main(string[] args) { 

        double R = Convert.ToDouble(Console.ReadLine());
        double A = 3.14159 * R * R;
        Console.WriteLine("A=" + A.ToString("0.0000"));

    }

}