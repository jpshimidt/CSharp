﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;


namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
