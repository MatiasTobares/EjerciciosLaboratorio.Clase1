using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numaleatorio, ingresado;
            int restantes = 13;
            Random generador = new Random(); Numaleatorio = generador.Next(1, 10001);
            Console.WriteLine("Te quedan {0} intentos", restantes);
            Console.Write("Introduce un número: ");
            ingresado = Convert.ToInt32(Console.ReadLine());
            //Bucle que se repite hasta que acierte o se quede sin intentos
            while ((ingresado != Numaleatorio) && (restantes > 1))
            {
                restantes = restantes - 1;
                if (ingresado < Numaleatorio) Console.WriteLine("¡Te has quedado corto!");
                if (ingresado > Numaleatorio) Console.WriteLine("¡Te has pasado!");
                Console.WriteLine("Te quedan {0} intentos", restantes);
                Console.Write("Introduce un nuevo número: ");
                ingresado = Convert.ToInt32(Console.ReadLine());
                //Comprobar si gana o pierde
            }
            if (ingresado == Numaleatorio) Console.WriteLine("¡¡¡Has ganado!!!");
            else
            {
                Console.WriteLine("Has perdido!"); Console.WriteLine("El numero aleatorio era el:  {0}", Numaleatorio);
            }

            Console.ReadKey();
        }
    }
}
