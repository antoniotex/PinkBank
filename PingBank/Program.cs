using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            //conta.saldo = -10;

            conta.DefinirSaldo(1000);

            conta.Sacar(800);

            conta.Depositar(120);

            Console.WriteLine("Saldo em conta: " + conta.ObterSaldo());

            Console.ReadLine();
        }
    }
}
