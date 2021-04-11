using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> frutas = new List<string>
            {
                 "abacate", "banana", "caqui", "damasco", "figo"
            };
            //vamos imprimir essa lista
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

        }
    }
}
