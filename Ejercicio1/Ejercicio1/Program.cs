using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MiliSeg = DateTime.Now.Millisecond;
            int NumeroAle = MiliSeg % 100 + 1;
            Console.Write("El numero aleatorio es: ");
            Console.WriteLine(NumeroAle);

            Console.ReadKey();
        }
    }
}
