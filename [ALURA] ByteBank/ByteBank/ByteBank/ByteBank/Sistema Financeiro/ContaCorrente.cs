using System;

namespace ByteBank.Operacoes
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        private double _saldo = 100;
        private int TaxaOperacao;
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            VerificaSeValido(agencia, numero);

            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        private static void VerificaSeValido(int agencia, int numero)
        {
            if (agencia < 0)
            {
                throw new ArgumentNullException("O argumento Agencia deve ser maior que zero");
            }

            if (numero < 0)
            {
                throw new ArgumentNullException("O argumento Numero deve ser maior que zero");
            }
        }

        public ContaCorrente()
        {
        }

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

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsulficenteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a tranferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsulficenteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada", ex);

            }

            contaDestino.Depositar(valor);
        }
    }
}
