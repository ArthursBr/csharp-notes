using System.Globalization;
using System.Xml;

namespace ex3 {
    class Aluno {
        public string Nome;
        public double Primeira;
        public double Segunda;
        public double Terceira;

        public double SomaTotal() {
            return (Primeira +  Segunda + Terceira);
        }

        public void ResultadoFinal(double nota) {
            Console.WriteLine($"NOTA FINAL = {nota}");
            if(nota < 60) {
                double faltou = 60 - nota;
                Console.WriteLine("REPROVADO\nFALTARAM " + faltou.ToString("F2", CultureInfo.InvariantCulture) + " PRONTOS");
            }
            else {
                Console.WriteLine("APROVADO");
            }
        }
    }
}
