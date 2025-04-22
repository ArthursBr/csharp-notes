using System;
using System.Globalization;
namespace ex5 {
    public class Program { 
        static void Main(string[] args) {
            int id;
            string nome;
            double valor;

            Conta c;

            Console.WriteLine("ABIR CONTA");
            Console.Write("Entre o número da conta:  ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta:  ");
            nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char tipo = char.Parse(Console.ReadLine());
            if(tipo == 'S' || tipo == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(id, nome, valor);
            }
            else {
                c = new Conta(id, nome);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(valor);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(valor);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

        }
    }
}