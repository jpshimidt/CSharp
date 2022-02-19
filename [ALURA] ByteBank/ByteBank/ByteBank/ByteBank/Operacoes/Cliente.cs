using System;

namespace ByteBank.Operacoes
{
    public class Cliente
    {
        public string nome;
        public string Profissao { get; set; }
        private string _cpf;

        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                if (value.Length > 11)
                {
                    Console.WriteLine("Cpf inválido");
                }
                _cpf = value;
            }
        }
    }
}