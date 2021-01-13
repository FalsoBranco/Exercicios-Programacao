using System; 

class URI {

    static void Main(string[] args) { 
        int.TryParse(Console.ReadLine(),out int a);
        int.TryParse(Console.ReadLine(), out int b);
        Console.WriteLine($"PROD = {a * b}");
    }
}