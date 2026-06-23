using System;

namespace Clases
{
    public class listaArista
    {
        public Arista primero = null;

        public void Insertar(Vertice d, float p)
        {
            Arista nuevo = new Arista();
            nuevo.destino = d;
            nuevo.peso = p;

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Arista temp = primero;

                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }

        public void Mostrar()
        {
            Arista temp = primero;
            int i=1;
            while (temp != null)
            {
                Console.WriteLine(i + ". " + temp.destino.dato + " - Peso: " + temp.peso);
                temp = temp.sig;
                i++;
            }
        }
    }
}