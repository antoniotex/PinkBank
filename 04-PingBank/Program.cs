

using System;

namespace _04_PingBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadoBruno = new ContaCorrente();

            contadoBruno.titular = "Bruno";

            Console.WriteLine("Saldo anterior: " + contadoBruno.saldo);

            contadoBruno.Sacar(75);

            Console.WriteLine("Saldo atual: " + contadoBruno.saldo);

            Console.ReadLine();

        }
    }
}
