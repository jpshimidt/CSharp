using ByteBank.Modelos;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(0012,65656);

            Console.WriteLine(conta.Agencia);
            Console.ReadLine();

        }
    }
}
