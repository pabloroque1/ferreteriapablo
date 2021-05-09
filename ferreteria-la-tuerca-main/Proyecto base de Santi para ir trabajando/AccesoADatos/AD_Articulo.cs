using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.AccesoADatos
{
    public class AD_Articulo
    {
        public static System.Data.DataTable ObtenerArticulos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Articulo";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);



                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static System.Data.DataTable agregarArticulo(string descArt, int codUnidad, float preUn, int idM, int idC)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Articulo (descripcion,codUnidad,precioUnitario,idMarca,idCategoria) values (@descripcion,@codunidad,@precioUnitario,@idMarca,@idCategoria)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", descArt);
                cmd.Parameters.AddWithValue("@codunidad", codUnidad);
                cmd.Parameters.AddWithValue("@precioUnitario", preUn);
                cmd.Parameters.AddWithValue("@idMarca", idM);
                cmd.Parameters.AddWithValue("@idCategoria", idC);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static System.Data.DataTable borrarArticulo(string descripcion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Articulo WHERE descripcion = @Descripcion";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static System.Data.DataTable modificarArticulo(int codProd, string desc, int codU, float pU, int M, int C)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Articulo SET descripcion = @Descripcion, codUnidad = @codUni, precioUnitario = @precioUni, idMarca = @idM, idCategoria = @idC  WHERE codProducto like @codProducto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codProducto", codProd);
                cmd.Parameters.AddWithValue("@Descripcion", desc);
                cmd.Parameters.AddWithValue("@codUni", codU);
                cmd.Parameters.AddWithValue("@precioUni", pU);
                cmd.Parameters.AddWithValue("@idM", M);
                cmd.Parameters.AddWithValue("@idC", C);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }



    }
}
