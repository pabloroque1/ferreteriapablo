using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class Articulo
    {
        private string Descripcion;
        private int codUnidad;
        private float precioUnitario;
        private int marca;
        private int categoria;

        public Articulo()
        {

        }
        
        public Articulo(string descripcion,int codunidad,int preciounitario, int Marca, int Categoria)
        {
            Descripcion = descripcion;
            codUnidad = codunidad;
            precioUnitario = preciounitario;
            marca = Marca;
            categoria = Categoria;
        }

        public string descripcionArticulo
        {
            get => Descripcion;
            set => Descripcion = value;
        }

        public int codigoUnidadArticulo
        {
            get => codUnidad;
            set => codUnidad = value;
        }


        public float precioUnitarioArticulo
        {
            get => precioUnitario;
            set => precioUnitario = value;
        }

        public int marcaArticulo
        {
            get => marca;
            set => marca = value;
        }

        public int categoriaArticulo
        {
            get => categoria;
            set => categoria = value;
        }


    }


}
