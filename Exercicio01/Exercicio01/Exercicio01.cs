using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, me diga seu nome: ");
            string nome = Console.ReadLine();

            string nomeInvertido = new string(nome.Reverse().ToArray());

            Console.Write(nomeInvertido);
            Console.ReadLine();
        }

        static public String InverterNome(string nome)
        {
            char[] ArrayChar = nome.ToCharArray();
            Array.Reverse(ArrayChar);
            return new string(ArrayChar);
        }
    }
}
