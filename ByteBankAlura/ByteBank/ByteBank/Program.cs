using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario
            {
                Nome = "Carlos",
                Salario = 2000,
                CPF = "464.571.078.85"
            };

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor
            {
                Nome = "Roberta",
                Salario = 5000,
                CPF = "800.600.700.90"
            };

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: R$ " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
