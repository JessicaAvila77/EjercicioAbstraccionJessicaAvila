using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccionJessicaAvila
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instanciado la clase

            Operacion operacion = new Operacion();

            try
            {
                Console.WriteLine("Calculo de Potencia, Logaritmo, Area de un cuadrado y Módulo");
                Console.Write("Ingrese el primer numero para las operaciones:");
                operacion.Numero1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo numero para las operaciones:");
                operacion.Numero2 = Convert.ToDouble(Console.ReadLine());

                if (operacion.Numero2 != 0)
                {
                    Console.WriteLine("");
                    operacion.Imprimir();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("El segundo numero no puede ser un 0 por una de las operaciones a realizar");
                }
               


            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Gracias por usar este programa");

            }

            
        }
    }
}
