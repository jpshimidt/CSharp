﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}