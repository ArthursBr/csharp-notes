using System;
using ex1;

namespace Ex1 {
    class Program {
        static void Main(string[] args) {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            r.Altura = double.Parse(Console.ReadLine());
            r.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area: {r.Area()}");
            Console.WriteLine($"Perimetro: {r.Perimetro():F2}");
            Console.WriteLine($"Diagonal: {r.Diagonal():F2}");
        }
    }
}