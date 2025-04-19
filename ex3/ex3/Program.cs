using System;

namespace ex3 {
    class Program {
        static void Main(string[] args) {
            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Informe as tres notas do aluno: ");
            a.Primeira = double.Parse(Console.ReadLine());
            a.Segunda = double.Parse(Console.ReadLine());
            a.Terceira = double.Parse(Console.ReadLine());

            double final = a.SomaTotal();
            a.ResultadoFinal(final);

        }
    }
}