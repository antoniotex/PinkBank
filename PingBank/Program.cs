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
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "15036981731";
            carlos.Salario = 2000;

            Diretor roberto = new Diretor();
            roberto.Nome = "Roberto";
            roberto.CPF = "524856357";
            roberto.Salario = 5000;

            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine(roberto.GetBonificacao());

            Console.ReadLine();
        }
    }
}
