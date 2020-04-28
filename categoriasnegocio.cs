using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace articulos
{
    class categoriasnegocio
    {

        public List<categorias> listarcategorias()
        {
            List<categorias> listadocategorias = new List<categorias>();
            SqlConnection coneccion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                coneccion.ConnectionString = "data source=NOTE055; initial catalog= CATALOGO_DB; integrated security=false; user=acaceres; password=andy1994";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT ID, DESCRIPCION FROM CATEGORIAS";
                comando.Connection = coneccion;
                coneccion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    categorias p = new categorias();

                    p.codigo = lector.GetInt32(0);
                    p.descripcion = lector.GetString(1);




                    listadocategorias.Add(p);


                }
                return listadocategorias;

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
    }
}
