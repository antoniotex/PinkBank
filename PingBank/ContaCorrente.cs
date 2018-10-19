using System;

namespace PingBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia { get; }
   
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0 || numero <= 0)
            {

                //nameof() é um operador do CSharp que transforma em string o nome da variavel (Boa prática)
                //Dessa forma abaixo estou passando como argumento a Message e o ParamName
                ArgumentException excecao = new ArgumentException("A ag e numero devem ser maiores que zero", nameof(numero));

                throw excecao;

                //throw new Exception("A ag e numero devem ser maiores que zero");
                //Console.WriteLine(Titular.Nome);
                //Lançando uma excessão
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}