using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Diretor roberta = new Diretor("111.111.1111")
            {
                Nome = "Roberta",
            };

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: R$ " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {

        }
    }
}
