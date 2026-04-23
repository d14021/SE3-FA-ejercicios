using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA3_FA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese segundos: ");
            int s = int.Parse(Console.ReadLine());

            int h = s / 3600;
            int m = (s % 3600) / 60;
            int sr = s % 60;

            Console.WriteLine($"\n{h} : {m} : {sr}");
        }
    }
}
