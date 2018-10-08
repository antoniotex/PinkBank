using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            //return Salario + (Salario * 0.10);            
            return Salario + base.GetBonificacao();
        }
    }
}
