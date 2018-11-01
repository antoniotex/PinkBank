using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingBank.Modelos;

namespace PingBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2019, 12, 02);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + GetIntervaloDeTempoLegivel(diferenca);

            Console.WriteLine(mensagem);

            Console.WriteLine(dataFimPagamento);

            Console.ReadLine();
        }

        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if(timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                return quantidadeMeses + " meses";
            }

            return timeSpan.Days + " dias";
        }
    }
}
