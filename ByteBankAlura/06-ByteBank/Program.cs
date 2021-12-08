using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            Console.WriteLine("Digite seu CPF: ");
            cliente.Cpf = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
