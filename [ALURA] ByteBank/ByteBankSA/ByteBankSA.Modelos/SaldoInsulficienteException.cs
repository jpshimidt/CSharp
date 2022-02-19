using System;
namespace ByteBank
{
    public class SaldoInsulficenteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsulficenteException() { }

        public SaldoInsulficenteException(double saldo, double valorSaque) :
            this("Tentativa de saque do valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;

        }

        public SaldoInsulficenteException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna) { }

        public SaldoInsulficenteException(string mensagem) : base(mensagem) { }
    }
}
