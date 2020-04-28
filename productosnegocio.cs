using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace articulos
{
    class productosnegocio
    {

        public List<productos> listar()
        {
            List<productos> listado = new List<productos>();
            SqlConnection coneccion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                coneccion.ConnectionString = "data source=NOTE055; initial catalog= CATALOGO_DB; integrated security=false; user=acaceres; password=andy1994";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.ID,  A.CODIGO,  A.NOMBRE, A.Descripcion, M.Descripcion, C.Descripcion, IMAGENURL, PRECIO, M.id, C.Id FROM ARTICULOS A LEFT JOIN MARCAS M ON M.Id= A.IdMarca LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria";
                comando.Connection = coneccion;
                coneccion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    productos p = new productos();
                    p.marca = new marcas();
                    p.categoria = new categorias();
                    p.marca.descripcion = (string)lector["descripcion"];
                    p.categoria.descripcion = (string)lector["descripcion"];
                    p.precio = lector.GetDecimal(7);
                    p.id = lector.GetInt32(0);

                    p.codigo = lector.GetString(1);
                    p.nombre = lector.GetString(2);

                    p.descripcion = lector.GetString(3);
                    p.imagenurl = (string)lector[6];
                   


                    listado.Add(p);


                }
                return listado;

            }
            catch (SqlException sq)
            {

                throw sq;
            }
            catch (Exception ex)
            {
                throw ex;


            }

            finally
            {
                coneccion.Close();

            }
        }


        public void agregar (productos nuevo)
        {
            SqlConnection coneccion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {

                coneccion.ConnectionString = "data source=NOTE055; initial catalog= CATALOGO_DB; integrated security=false; user=acaceres; password=andy1994";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO ARTICULOS (CODIGO, NOMBRE, IDMARCA, IMAGENURL, IDCATEGORIA, DESCRIPCION, PRECIO ) VALUES  ('" + nuevo.codigo + "','" + nuevo.nombre +"' , '"+ nuevo.marca.codigo.ToString() + "', '" + nuevo.imagenurl + "', '"+ nuevo.categoria.codigo.ToString() +"' , '"+ nuevo.descripcion +"' , '"+ nuevo.precio+"' )";
                comando.Connection = coneccion;
                coneccion.Open();
                comando.ExecuteNonQuery();
                

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void modificar (productos nuevo)
            {

            SqlConnection coneccion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {

                coneccion.ConnectionString = "data source=NOTE055; initial catalog= CATALOGO_DB; integrated security=false; user=acaceres; password=andy1994";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "update articulos set codigo = @codigo, nombre =@nombre, marca= @marca, imagenurl= @imagenurl, categoria =@categoria, descipcion = @descripcion, precio=@precio where id= @id ";
                comando.Parameters.AddWithValue("@codigo", nuevo.codigo);
                comando.Parameters.AddWithValue("@nombre", nuevo.nombre);
                comando.Parameters.AddWithValue("@marca", nuevo.marca.codigo.ToString());
                comando.Parameters.AddWithValue("@imagenurl", nuevo.imagenurl);
                comando.Parameters.AddWithValue("@categoria", nuevo.categoria.codigo.ToString());
                comando.Parameters.AddWithValue("@descripcion", nuevo.descripcion);
                comando.Parameters.AddWithValue("@precio", nuevo.precio);
                
                comando.Connection = coneccion;
                coneccion.Open();
                comando.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }


             

    }
    }
}

