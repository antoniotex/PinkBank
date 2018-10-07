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

            conta.Saldo = 1000;

            conta.Sacar(700);

            conta.Depositar(120);

            Console.WriteLine("Saldo em conta: " + conta.Saldo);

            Console.ReadLine();
        }
    }
}
