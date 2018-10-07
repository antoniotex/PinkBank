

using System;

namespace _04_PingBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadoBruno = new ContaCorrente();

            ContaCorrente contaDaGabi = new ContaCorrente();
            contaDaGabi.titular = "Gabriela";

            Console.WriteLine("Saldo anterior Bruno: " + contadoBruno.saldo);
            Console.WriteLine("Saldo anterior Gabi: " + contaDaGabi.saldo);

            contadoBruno.Transferir(50, contaDaGabi);

            Console.WriteLine("Saldo atual Bruno: " + contadoBruno.saldo); 
            Console.WriteLine("Saldo atual Gabi: " + contaDaGabi.saldo);

            Console.ReadLine();

        }
    }
}
