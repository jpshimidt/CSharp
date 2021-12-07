using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoJoao = new ContaCorrente();
            contaDoJoao.titular = new Cliente();

            contaDoJoao.titular.nome = "João Pedro";
        }
    }
}
