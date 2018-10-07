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
            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.profissao = "Dev C#";
            gabriela.cpf = "15036981731";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563452;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
