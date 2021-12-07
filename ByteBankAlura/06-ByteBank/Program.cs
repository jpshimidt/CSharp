using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();


            Console.WriteLine(conta.ObterSaldo());
            Console.ReadKey();
        }
    }
}
