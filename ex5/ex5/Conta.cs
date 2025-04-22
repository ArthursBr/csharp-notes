using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5 {
    class Conta {
        public int Id;
        public string Nome;
        public double Saldo;
        public Conta(int _id, string _nome) {
            Id = _id;
            Nome = _nome;
            Saldo = 0.0;
        }

        public Conta(int _id, string _nome, double _incial) : this (_id, _nome){
            Id = _id;
            Nome = _nome;
            Saldo = _incial;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        public override string ToString() {
            return "Conta "
                + Id
                + ", Titular: "
                + Nome
                + ", Saldo $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
