using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    //VERTICE = NODO
    public class Vertice
    {
        public Ciudad dato;
        //lista simple
        public Vertice sig = null;

        //grafo
        /*public Vertice arista1 = null;
        public Vertice arista2 = null;
        public Vertice arista3 = null;
        public Vertice arista4 = null;
        public Vertice arista5 = null;*/
        public listaArista ls = new listaArista();
    }
}
