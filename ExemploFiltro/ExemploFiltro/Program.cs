using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFiltro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo para aprendizagem de filtro em listas...

            int contador = 0;
            String[] listaAleatoria = {"Ricardo", "Jeferson", "Luiza", "Luana", "Vitoria", "José", "Luiz", "Pepe", "Larissa", "Rick"};

            for (int i=0; i < listaAleatoria.Length; i++)
            {
                Console.WriteLine(i+1 + ". " + listaAleatoria[i]);
            }

            Console.WriteLine("Por qual nome você está procurando? ");
            String elementoFiltrado = Console.ReadLine();

            for (int j=0; j < listaAleatoria.Length; j++)
            {

                if (elementoFiltrado.ToUpper() == listaAleatoria[j].ToUpper())
                {
                    String[] listaFiltrada = {listaAleatoria[j]};
                    int posicao = j+1;
                    contador = contador + 1;

                    Console.WriteLine("Esse nome possui na lista! Ele está na posição " + posicao +".");
                } else {
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("Esse nome não possui na lista! Tente novamente.");
            }

            Console.ReadKey();
        }
    }
}
