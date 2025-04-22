using System.Globalization;
namespace ex4 {
    class ConversorDeMoeda {
        public static double Cotacao;
        public static double Dolar;

        public static double TotalEmReais() {
            double total = Cotacao * Dolar;
            return total + (total * 6 / 100.0);
        }
    }
}
