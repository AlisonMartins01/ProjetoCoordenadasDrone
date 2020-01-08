
using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Insira as coordenadas: ");
            var x = Console.ReadLine();

            Coordenada coordenada = new Coordenada();

            Console.WriteLine(Coordenada.PosicaoCartesiana(x));


        }
    }
}
