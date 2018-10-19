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

                conta1.Depositar(50);
                Console.WriteLine(conta1.Saldo);
                conta1.Sacar(500);
                Console.WriteLine(conta1.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("argumentException type");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            

            Console.ReadLine();
        }
    }
}
