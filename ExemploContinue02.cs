using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCsharp.Aula08
{
    internal class ExemploContinue02
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                if(i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
