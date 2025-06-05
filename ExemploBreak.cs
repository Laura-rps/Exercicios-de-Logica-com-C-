using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCsharp.Aula08
{
    internal class ExemploBreak01
    {
        public static void Main(string[] args)
        {
            for (int i = 0;i < 10; i++)
            {
                if(i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
