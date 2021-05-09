using Ferreteria.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
            cargarComboMarca();
            cargarComboCategoria();
            btn_BorrarArticulo.Visible = false;
        }

        private void cargarComboMarca()
        {
            try
            {

                cmb_marcaArticulo.DataSource = AD_Marca.ObtenerMarca();
                cmb_marcaArticulo.DisplayMember = "descripcion";
                cmb_marcaArticulo.ValueMember = "idMarca";
                cmb_marcaArticulo.SelectedIndex = -1;

            }
            catch (Exception )
            {
                MessageBox.Show("Error al cargar combo de marcas");
            }
        }

        private void cargarComboCategoria()
        {
            try
            {

                cmb_categoriaArticulo.DataSource = AD_Categorias.ObtenerCategorias();
                cmb_categoriaArticulo.DisplayMember = "descripcion";
                cmb_categoriaArticulo.ValueMember = "idCategoria";
                cmb_categoriaArticulo.SelectedIndex = -1;

            }
            catch (Exception )
            {
                MessageBox.Show("Error al cargar combo de categorias");
            }
        }

        private void btn_GuardarArticulo_Click(object sender, EventArgs e)
        {
           
            string Descripcion = txt_descripcionArticulo.Text;
            int codUnid = int.Parse(txt_codUnidad.Text);
            float precUnitario = float.Parse(txt_precioUnitario.Text);
            int marca = (int)cmb_marcaArticulo.SelectedValue;
            int categoria = (int)cmb_categoriaArticulo.SelectedValue;
            bool resultado = existeEnGrilla(Descripcion);

            DialogResult asd;
            if (resultado == false)
            {
                asd = MessageBox.Show("¿Está seguro que desea Agregar el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (asd == DialogResult.Yes)
                {

                    AccesoADatos.AD_Articulo.agregarArticulo(Descripcion,codUnid,precUnitario,marca,categoria);
                    cargarGrilla();
                    txt_descripcionArticulo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ya existe la categoria seleccionada");
            }
        }

     

        private bool existeEnGrilla(string criteroaBuscar)
        {
            bool resultado = false;

            for (int i = 0; i < dgv_Articulo.Rows.Count; i++)
            {
                if (dgv_Articulo.Rows[i].Cells["Descripcion"].Value.Equals(criteroaBuscar))
                {
                    resultado = true;
                    break;
                }
            }


            return resultado;
        }

        private void cargarGrilla()
        {
            dgv_Articulo.DataSource = AccesoADatos.AD_Articulo.ObtenerArticulos();
        }

        private void Articulo_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btn_BorrarArticulo_Click(object sender, EventArgs e)
        {

            string Descripcion = txt_descripcionArticulo.Text;
            bool resultado = existeEnGrilla(Descripcion);
            DialogResult asd;
            if (resultado == true)
            {
                asd = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (asd == DialogResult.Yes)
                {
                    for (int i = 0; i < dgv_Articulo.Rows.Count; i++)
                    {
                        if (dgv_Articulo.Rows[i].Cells["Descripcion"].Value.Equals(Descripcion))
                        {
                            dgv_Articulo.Rows.Remove(dgv_Articulo.Rows[i]);
                        }

                    }

                    AccesoADatos.AD_Articulo.borrarArticulo(Descripcion);
                    cargarGrilla();
                    txt_descripcionArticulo.Focus();
                }
            }
            else
            {
                MessageBox.Show("No existe esa categoria para borrar");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txt_codUnidad.Enabled = false;
            txt_precioUnitario.Enabled = false;
            cmb_categoriaArticulo.Enabled = false;
            cmb_marcaArticulo.Enabled = false;
            btn_BorrarArticulo.Visible = true;
        }
    }
}
