using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class Categoria
    {
        private string descripcion;

        public Categoria()
        {

        }

        public Categoria(string Descripcion)
        {
            descripcion = Descripcion;
        }

        public string descripcionCategoria
        {
            get => descripcion;
            set => descripcion = value;
        }



        
        
    }

    
}
