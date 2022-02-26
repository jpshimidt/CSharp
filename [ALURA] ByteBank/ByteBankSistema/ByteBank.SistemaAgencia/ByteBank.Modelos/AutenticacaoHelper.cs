using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenha(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaTentativa == senhaVerdadeira;
        }
    }
}
