

using System;

namespace _04_PingBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadoBruno = new ContaCorrente();


            Console.WriteLine("Saldo atual: " + contadoBruno.saldo);

            contadoBruno.Depositar(500);

            Console.WriteLine("Saldo anterior: " + contadoBruno.saldo);

            Console.ReadLine();

        }
    }
}
