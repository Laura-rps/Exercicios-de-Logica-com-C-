﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Soma
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculo da soma de 2 numeros");

            Console.Write("Digite o primeiro valor: ");

            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");

            int B = int.Parse(Console.ReadLine());

            int soma = A + B;

            Console.WriteLine("O resultado é: " + soma);
        }
    }
}