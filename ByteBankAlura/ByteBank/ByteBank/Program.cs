using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("111.111.1111")
            {
                Nome = "Roberta",
                Senha = "123"
            };

            GerenteDeConta camila = new GerenteDeConta("222.222.2222")
            {
                Nome = "Camila",
                Senha = "ABC"
            };

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "ABC");
        }

        public static void CalcularBonificacao()
        {

        }
    }
}
