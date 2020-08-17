using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Random r = new Random();
            int aleatorio = r.Next(1, 7);
            Console.WriteLine("Se genero un numero aleatorio entre 1 y 6 ¿Podras adivinarlo?");
            Console.WriteLine("Indica el numero que creas: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == aleatorio)
                Console.WriteLine("Correcto, has acertado el numero al primer intento");
            else
            {
                if (numero < aleatorio)
                    Console.WriteLine("Prueba un numero mas alto: ");
                if (numero > aleatorio)
                    Console.WriteLine("Prueba un numero mas bajo: ");

                Console.WriteLine("No has conseguido, vamos por la segunda chanse");
                Console.WriteLine("Indica el numero que creas: "); numero = Convert.ToInt32(Console.ReadLine());

                if (numero == aleatorio)
                    Console.WriteLine("Correcto, has acertado el numero al segundo intento");
                else
                    if (numero < aleatorio)
                    Console.WriteLine("Prueba un numero mas alto: ");
                if (numero > aleatorio)
                    Console.WriteLine("Prueba un numero mas bajo: ");
                Console.WriteLine("No has conseguido, vamos por la tercera y ultima chanse");
                Console.WriteLine("Indica el numero que creas: "); numero = Convert.ToInt32(Console.ReadLine());
                if (numero == aleatorio)
                    Console.WriteLine("Correcto, has acertado el numero al tercer intento");

                else
                    Console.WriteLine("No has acertado, era {0}", aleatorio);
            }

            Console.ReadKey();
        }
    }
}
