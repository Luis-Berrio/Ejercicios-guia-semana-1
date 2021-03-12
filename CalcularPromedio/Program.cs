using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nota1, nota2, nota3, promedio, suma;

            Console.WriteLine("\tCalcular promedio\n");

            do
            {
                Console.WriteLine("Ingrese la nota 1: ");
                nota1 = Convert.ToDecimal(Console.ReadLine());
                if ((nota1 < 0) || (nota1 > 5))
                    Console.WriteLine("Nota no valida, intentelo de nuevo");
            } while ((nota1 < 0) || (nota1 > 5));

            do
            {
                Console.WriteLine("Ingrese la nota 2: ");
                nota2 = Convert.ToDecimal(Console.ReadLine());
                if((nota2 < 0) || (nota2 > 5))
                Console.WriteLine("Nota no valida, intentelo de nuevo");
            } while ((nota2 < 0) || (nota2 > 5));

            do
            {
                Console.WriteLine("Ingrese la nota 3: ");
                nota3 = Convert.ToDecimal(Console.ReadLine());
                if ((nota3 < 0) || (nota3 > 5))
                    Console.WriteLine("Nota no valida, intentelo de nuevo");
            } while ((nota3 < 0) || (nota3 > 5));

            suma = nota1 + nota2 + nota3;

            promedio = suma / 3;
            promedio = Math.Round(promedio, 2);

            if (promedio < 3)
            {
                Console.WriteLine("El estudiante perdio la materia...");
                Console.WriteLine($"Nota definitiva: {promedio}");
            }
            else
            {
                Console.WriteLine("El estudiante gano la materia...");
                Console.WriteLine($"Nota definitiva: {promedio}");
            }

            Console.ReadKey();
        }
    }
}
