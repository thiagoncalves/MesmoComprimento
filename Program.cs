﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesmoComprimento
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;
            int tamanhonome1;
            int tamanhonome2;

            Console.WriteLine("Digite alguma coisa: ");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite alguma coisa novamente: ");
            nome2 = Console.ReadLine();

            Console.Clear();

            tamanhonome1 = nome1.Length;
            tamanhonome2 = nome2.Length;

            Console.WriteLine("Primeiro Texto: " + nome1);
            Console.WriteLine("Segundo Texto: " + nome2 + "\n");

            Console.WriteLine("Tamanho de '" + nome1 + "': " + tamanhonome1);
            Console.WriteLine("Tamanho de '" + nome2 + "': " + tamanhonome2 + "\n");

            if (tamanhonome1 == tamanhonome2)
                Console.WriteLine("Os dois textos têm tamanhos iguais");
            else
                Console.WriteLine("Os dois textos têm tamanhos diferentes");

            if (nome1 == nome2)
                Console.WriteLine("Os dois textos possuem conteúdo iguais");
            else
                Console.WriteLine("Os dois textos possuem conteúdo diferentes");

            Console.ReadLine();
        }
    }
}
