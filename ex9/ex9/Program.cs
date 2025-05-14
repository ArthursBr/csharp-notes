using System;

namespace ex9 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe M: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Informe N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("\nInforme X: ");
            int x = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] == x) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}