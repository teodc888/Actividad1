using Actividad1Y2.Interfaces;

namespace Actividad1Y2.Clases
{
    public class Pila : IColleccion
    {
        object[] objects;
        int contador;
        public Pila(int tamanio)
        {
            objects = new object[tamanio];
            contador = 0;
        }

        public bool estaVacia()
        {
            if (objects.Length == 0)
            {
                return true;
            }
            return false;
        }

        public object extraer()
        {
            if (contador == 0)
            {
                return false;
            }

            object elementoQuitado = objects[contador - 1];
            object[] nuevoOjeto = new object[objects.Length];

            var contarNuevo = 0;
            foreach(object obj in objects)
            {
                if (elementoQuitado == obj)
                    continue;
                
                nuevoOjeto[contarNuevo] = obj;
                contarNuevo++;
            }

            objects = nuevoOjeto;

            contador--;


            return elementoQuitado;
        }

        public object primero()
        {
            return objects[0];
        }

        public bool añadir(object newObjet)
        {       
            objects[contador] = newObjet;
            contador++;
            if (objects[contador] != null)
            {
                return false;
            }

            return true;
        }
    }
}
