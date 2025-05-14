using System;

namespace ex8 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe TAM: ");
            int TAM = int.Parse(Console.ReadLine());
            int[,] matriz = new int[TAM, TAM];
            for (int i = 0; i < matriz.GetLength(0); i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int f = 0; f < matriz.GetLength(1); f++) {
                    matriz[i,f] = int.Parse(values[f]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < matriz.GetLength(0); i++) {
                Console.Write(matriz[i,i] + " ");
            }

            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int f = 0; f < matriz.GetLength(1); f++) {
                    if (matriz[i,f] < 0) count++;
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
