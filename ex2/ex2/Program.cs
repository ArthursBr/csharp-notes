using System;

namespace ex2 {
    class Program {
        static void Main(string[] args) {
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Name = Console.ReadLine();
            Console.Write("Salario bruto: ");
            f.Salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nFuncionario: {f}");

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            int aum = int.Parse(Console.ReadLine());

            f.AumentarSalario(aum);
            Console.WriteLine($"\nDados atualizados: {f}");
        }
    }
}