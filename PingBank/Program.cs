using PingBank.Funcionarios;
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
            ContaCorrente conta1 = new ContaCorrente(846, 846387);
            ContaCorrente conta2 = new ContaCorrente(846, 846388);
            ContaCorrente conta3 = new ContaCorrente(846, 846389);

            try
            {
                Console.WriteLine("log1: " + conta1.Saldo);
                conta1.Depositar(100);
                Console.WriteLine("log2: " + conta1.Saldo);
                conta1.Sacar(-150);
                Console.WriteLine("log3: " + conta1.Saldo);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
