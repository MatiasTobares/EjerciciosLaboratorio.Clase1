using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeroAle = new Random();
            int aleatorio1 = numeroAle.Next(1, 11);
            int aleatorio2 = numeroAle.Next(11, 21);
            Console.WriteLine("El numero del primer dado es: {0} ", aleatorio1);
            Console.WriteLine("El numero del segundo dado es: {0} ", aleatorio2);

            Console.ReadKey();
        }
    }
}
