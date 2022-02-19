using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ByteBank
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
