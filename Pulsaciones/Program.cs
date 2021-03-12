using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulsaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string sexo, nombreApellido;
            decimal pulsacion;

            Console.WriteLine("Ingrese el nombre completo: ");
            nombreApellido = Console.ReadLine();

            do
            {
                Console.WriteLine("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                if ((edad < 0) || (edad > 120))
                    Console.WriteLine("Edad no valida, intentelo de nuevo");
            } while ((edad < 0) || (edad > 120));

            do
            {
                Console.WriteLine("Ingrese el sexo: ");
                sexo = Console.ReadLine();
                sexo = sexo.ToUpper();
                if ((sexo != "F") && (sexo != "M"))
                    Console.WriteLine("Sexo no valido, intentelo de nuevo");
            } while ((sexo != "F") && (sexo != "M"));

            if (sexo.ToUpper().Equals("M"))
            {
                pulsacion = (210 - edad) / 10;
            }
            else 
            {
                pulsacion = (220 - edad) / 10;
            }

            Console.WriteLine($"La pulsacion es: {pulsacion}");

            Console.ReadKey();
        }
    }
}
