using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace articulos
{
    class marcasnegocio
    {

        public List<marcas> listarmarcas()
        {
            List<marcas> listadomarcas = new List<marcas>();
            SqlConnection coneccion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                coneccion.ConnectionString = "data source=NOTE055; initial catalog= CATALOGO_DB; integrated security=false; user=acaceres; password=andy1994";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT ID, DESCRIPCION FROM MARCAS";
                comando.Connection = coneccion;
                coneccion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    marcas m = new marcas();

                    m.codigo = lector.GetInt32(0);
                    m.descripcion = lector.GetString(1);
                   
                   


                    listadomarcas.Add(m);


                }
                return listadomarcas;

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
