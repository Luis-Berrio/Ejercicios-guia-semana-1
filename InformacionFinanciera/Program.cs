using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformacionFinanciera
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            decimal saldo;

            Cuenta cuenta = new Cuenta();

            Console.WriteLine("Ingrese el saldo inicial: ");
            saldo = Convert.ToDecimal(Console.ReadLine());
            cuenta.saldo = saldo;


            do
             {

                Console.WriteLine($"_________________");
                Console.WriteLine($"1) Consignar");
                Console.WriteLine($"2) Retirar");
                Console.WriteLine($"3) Consultar");
                Console.WriteLine($"4) Salir");
                Console.WriteLine($"-----------------");

                opcion = int.Parse(Console.ReadLine());


                if (opcion == 1)
                {
                    Console.WriteLine($"Ingrese el valor:");
                    saldo = Convert.ToDecimal(Console.ReadLine());
                    cuenta.ConsignarSaldo(saldo);
                }
                else if (opcion == 2)
                {
                     Console.WriteLine($"Ingrese el valor:");
                     saldo = Convert.ToDecimal(Console.ReadLine());
                     cuenta.Retirar(saldo);
                }
                else
                {
                     Console.WriteLine($"Saldo: {cuenta.ConsultarSaldo()}");
                }

                } while (opcion != 4);            

                Console.ReadKey();
        }
    }
}
