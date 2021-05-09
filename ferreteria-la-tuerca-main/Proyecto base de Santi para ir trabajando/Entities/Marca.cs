using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class Marca
    {
        private string descripcion;

        public Marca()
        {

        }

        public Marca(string Descripcion)
        {
            descripcion = Descripcion;
        }

        public string descripcionMarca
        {
            get => descripcion;
            set => descripcion = value;
        }





    }
}
