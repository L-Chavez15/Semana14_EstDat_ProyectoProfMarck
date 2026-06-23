using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese cantidad de ciudades: ");
            int cant=int.Parse(Console.ReadLine());
            Grafo gf = new Grafo(cant);
            gf.GenerarMatriz();
            gf.MostrarMatriz();
            Console.ReadKey();
            gf.CrearGrafo();
            gf.Recorrer(gf.GetInicio());
        }
    }
}
