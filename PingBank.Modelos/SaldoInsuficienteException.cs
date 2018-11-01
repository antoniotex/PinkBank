using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque no valor de " + valorSaque + ", em uma conta com o valor de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string msg)
            : base(msg)
        {
        }

        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {

        }
    }
}
