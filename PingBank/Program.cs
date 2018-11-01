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
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 456817);
                ContaCorrente conta2 = new ContaCorrente(455, 456815);

                conta1.Transferir(1000, conta2);
            }
            catch(OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
