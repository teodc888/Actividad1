using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1Y2.Interfaces
{
    public interface IColleccion
    {
        bool estaVacia();
        object extraer();
        object primero();
        bool añadir(object newObjet);
    }
}
