using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(String senha)
        {
            return Senha == senha;
        }
    }
}
