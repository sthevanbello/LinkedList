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

            //List<string> frutas = new List<string>
            //{
            //     "abacate", "banana", "caqui", "damasco", "figo"
            //};
            ////vamos imprimir essa lista
            //foreach (var fruta in frutas)
            //{
            //    Console.WriteLine(fruta);
            //}

            LinkedList<string> dias = new LinkedList<string>();

            var d4 = dias.AddFirst("Wednesday");

            //Console.WriteLine(d4.Value);

            var d2 = dias.AddBefore(d4, "Monday");

            var d3 = dias.AddAfter(d2, "Tuesday");

            var d6 = dias.AddAfter(d4, "Friday");

            var d5 = dias.AddBefore(d6, "Thursday");

            var d1 = dias.AddBefore(d2, "Sunday");

            var d7 = dias.AddAfter(d6, "Saturday");

            Console.WriteLine(string.Join("\n", dias));

            dias.Remove(d4);

            Console.WriteLine(string.Join("\n", dias));
            //foreach (var item in dias)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();

        }
    }
}
