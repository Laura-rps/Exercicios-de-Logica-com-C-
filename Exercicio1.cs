using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCsharp.Aula08
{
    internal class Exercicio1
    {
        public static void Main(string[] args)
        {
            string txtAspasDuplas = "Teste Aula \"Jailson\".";
            Console.WriteLine(txtAspasDuplas);

            string txtContraBarra = "Teste contra barra \\";
            Console.WriteLine(txtContraBarra);

            string txtPularLinha = "Teste pular \n linha";
            Console.WriteLine(txtPularLinha);

            string txtTab = "Teste com o\t tab";
            Console.WriteLine(txtTab);

            string txtBackSpace = "Teste com \bbackSpace";
            Console.WriteLine(txtBackSpace);
        }
    }
}
