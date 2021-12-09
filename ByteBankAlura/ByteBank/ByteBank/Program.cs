using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario(1);

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;
            carlos.CPF = "464.571.078.85";

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            
            Console.ReadLine();
        }
    }
}
