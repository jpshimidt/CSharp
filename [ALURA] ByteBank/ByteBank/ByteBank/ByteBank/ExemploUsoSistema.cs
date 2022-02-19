using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    public class ExemploUsoSistema
    {
        public ExemploUsoSistema()
        {
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

            ParceiroComercial Luciano = new ParceiroComercial()
            {
                Senha = "987"
            };

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "ABC");
            sistemaInterno.Logar(Luciano, "ABC");
            sistemaInterno.Logar(Luciano, "987");
        }
    }
}
