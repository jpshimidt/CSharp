using System;

namespace ByteBank.Modelos
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
