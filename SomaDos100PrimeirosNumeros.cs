﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SomaDos100PrimeirosNumeros
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma de um numero qualquer ate 100");
            Console.WriteLine("Digite qualquer numero: ");
            int i = 1, totalSoma = 0;
                while (i < 101)
            {
                totalSoma += i;
                i++;
            }
            Console.WriteLine($"Total da soma dos 100 primeiros numeros inteiros \n\n{totalSoma}");
        }
    }
}
