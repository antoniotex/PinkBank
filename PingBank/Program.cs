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
                ContaCorrente conta1 = new ContaCorrente(0, 0);

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
