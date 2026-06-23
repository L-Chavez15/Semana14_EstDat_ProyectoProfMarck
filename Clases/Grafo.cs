using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Grafo
    {
        //1. Lista Vertices
        //2. Matriz Adyacencia
        //3. Crear grafo,
        //4. Recorrer grafo

        ListaSimple l_vertices = new ListaSimple();
        int[,] ma;

        // llenar datos iniciales de las ciudades(NO USAR EN EXAMEN)
        String[] nom_ciudades = { "CAJAMARCA", "LIMA", "TRUJILLO", "CHICLAYO", "PIURA", "TUMBES", "HUANCAYO" };
        String[] tipo_climas = { "FRIO", "CALIDO", "TEMPLADO", "SECO", "TROPICAL" , "HUMEDO" , "MEDITERRANEO" };

        public Grafo(int cant)
        {
            Random R = new Random();
            for (int i = 0; i < cant; i++)
            {
                Ciudad c = new Ciudad();

                /*//insertar datos de los vertices
                Console.Write("Ingrese nombre de la ciudad: ");
                c.nombre=Console.ReadLine();
                Console.Write("Tipo de Clima: ");
                c.tipo_clima = Console.ReadLine();
                Console.Write("Temperatura: ");
                c.temperatura=float.Parse(Console.ReadLine());*/
                c.nombre = nom_ciudades[i];
                c.tipo_clima = tipo_climas[i];
                c.temperatura = R.Next(10, 30);

                l_vertices.Insertar(c);
            }
            ma =new int[cant, cant];
        }

        public Vertice GetInicio()
        {
            return l_vertices.primero;
        }
        //matrices
        public void GenerarMatriz()
        {
            Random r= new Random();
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    ma[i, j] = r.Next(0, 2);
                }
            }
        }
        public void MostrarMatriz()
        {
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    Console.Write(ma[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }

        public void CrearGrafo()
        {
            Random r = new Random();
            Vertice temp_i = l_vertices.primero;
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                Vertice temp_j = l_vertices.primero;
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    //i,j
                    //temp_i,temp_j
                    if (ma[i, j] == 1)
                    {
                        //unir temp_i con el temp_j
                        temp_i.ls.Insertar(temp_j, (float)r.Next(100, 501));
                    }
                    temp_j = temp_j.sig;
                }
                temp_i = temp_i.sig;
            }
        }

        public void Recorrer(Vertice v, ref float total)
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ciudad actual: \n"+v.dato+"\n");
            Console.ResetColor();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Viajes disponibles: ");
            v.ls.Mostrar();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ingrese el numero de la ciudad a la que desea viajar: ");
            int op= int.Parse(Console.ReadLine());

            if (op == 0) return;
            Arista temp= v.ls.primero;
            for (int i = 0; i < op; i++)
            {
                temp = temp.sig;
            }
            total += temp.peso;
            //salimos con la arista por la que tengo que recorrer
            Recorrer(temp.destino, ref total);
        }
    }
}
