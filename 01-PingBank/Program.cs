using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PingBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabi = new ContaCorrente();

            contaDaGabi.titular = "Gabriela";
            contaDaGabi.agencia = 863;
            contaDaGabi.numero = 863452;
            contaDaGabi.saldo = 100;

            Console.WriteLine(contaDaGabi);

            Console.ReadLine();
        }
    }
}
