using System;
using System.Globalization;
using System.Runtime.CompilerServices;
 
namespace ex6 {
    class Program {
        static void Main(string[] args) {
            Estudante[] vectEstudantes = new Estudante[10];

            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for(int i = 1; i <= n; i++) {
                Console.WriteLine("\nAluguel #" + i);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vectEstudantes[quarto] = new Estudante(name, email);
            }
            Console.WriteLine("\nQuartos ocupados: ");
            for(int i = 0; i < 10; i++) {
                if (vectEstudantes[i]  != null) {
                    Console.WriteLine(i + ": "+ vectEstudantes[i]);
                }
           }
        }
    }
}