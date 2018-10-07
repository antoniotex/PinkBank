using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PinkBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadaGabi = new ContaCorrente();
            contadaGabi.titular = "Gabriela";
            contadaGabi.agencia = 863;
            contadaGabi.numero = 863452;

            Console.WriteLine(contadaGabi.titular);
        }
    }
}
