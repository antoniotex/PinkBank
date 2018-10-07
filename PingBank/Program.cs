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
            Console.WriteLine("Total contas criadas: " + ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(867, 867452);
            Cliente cliente = new Cliente();

            conta.Saldo = 1000;

            conta.Sacar(700);

            conta.Depositar(120);

            Console.WriteLine("Saldo em conta: " + conta.Saldo);

            Console.WriteLine("Total contas criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
