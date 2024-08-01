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
            Operacion operacion = new Operacion();

            try
            {
                Console.WriteLine("Calculo de Potencia, Logaritmo, Area de un cuadrado y Módulo");
                Console.Write("Ingrese el primer numero para las operaciones:");
                operacion.Numero1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo numero para las operaciones:");
                operacion.Numero2 = Convert.ToDouble(Console.ReadLine());

                operacion.Imprimir();


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
