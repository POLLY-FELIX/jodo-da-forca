using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jodo_da_forca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####################");
            Console.WriteLine("## Seja Bem vindo####");
            Console.WriteLine("## Ao jogo da Forca #");
            Console.WriteLine("#####################");
            Thread.Sleep(4000);
            Console.Clear();

            // Regras do jogo
            Console.WriteLine("voce tera um número de chace limitado");
            Console.WriteLine("O numero de chance será igual ao numero de letras da palavra.");
            Console.WriteLine("tentativas extras de 6 a 7");
            Console.WriteLine("se voce acerta a letra ela sera revelada na ordem certa.");
            Console.WriteLine("caso contrário, voce perdera uma chance.");
            Console.WriteLine("Acertando a palavra antes das chance acabar voce ganha o jogo,");
            Console.WriteLine("se não acerta, voce perde o jogo.");
            Thread.Sleep(4000);
            Console.Clear();

            string[] palavras =
            {
              "Nike",
              "Puma",
              "Adidas",
            };

            {
                static void Tentativa(int numeroSorteado, int tentativas);
            }
        }

    }
}
