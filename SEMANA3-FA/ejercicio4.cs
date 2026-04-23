using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA3_FA
{
    internal class ejercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número decimal");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nRaiz cuadrada: {Math.Sqrt(num)}");
            Console.WriteLine($"Redondeando: {Math.Round(num)}");
            Console.WriteLine($"Elevado al cubo: {Math.Pow(num,3)}");
            Console.WriteLine($"Raiz cubica: {Math.Pow(num,1/3d)}");

            //Agregamos subfijo "d" para obtener el resultado exacto.
            //Cuando son fracciones.
        }
    }
}
