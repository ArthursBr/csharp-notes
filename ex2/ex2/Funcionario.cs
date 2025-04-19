using System.Globalization;

namespace ex2 {
    class Funcionario {
        public string Name;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto;
        }

        public void AumentarSalario(int porcentagem) {
            Salario = (Salario * porcentagem / 100) + Salario;
        }

        public override string ToString() {
            return Name + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
