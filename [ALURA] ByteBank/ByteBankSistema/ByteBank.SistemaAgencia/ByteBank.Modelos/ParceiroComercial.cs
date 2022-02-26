using System;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();

        public bool Autenticar(String senha)
        {
            return _autenticacaoHelper.CompararSenha(Senha, senha);

        }
    }
}
