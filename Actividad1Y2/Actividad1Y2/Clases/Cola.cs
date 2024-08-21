using Actividad1Y2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Actividad1Y2.Clases
{
    public class Cola : IColleccion
    {
        List<object> lstObjet;
        public Cola()
        {
            lstObjet = new List<object>();
        }

        public bool estaVacia()
        {
            if (lstObjet.Count == 0)
                return true;

            return false;
        }

        public object extraer()
        {
            if (lstObjet.Count == 0)
                return false;

            object elementoElimiando = lstObjet.Last();

            lstObjet.Remove(elementoElimiando);

            return elementoElimiando;
        }

        public object primero()
        {
            if (lstObjet.Count == 0)
                return false;

            return lstObjet.First();
        }

        public bool añadir(object newObjet)
        {

            lstObjet.Add(newObjet);

            return true;
        }
    }
}
