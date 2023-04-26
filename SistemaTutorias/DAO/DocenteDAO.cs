using SistemaTutorias.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTutorias.DAO
{
    internal class DocenteDAO
    {
        string cadenaDeConexion = Conexion.cadenaDeConexion;

        public DocenteDAO()
        {
        }

        public List<Docente> getDocentes()
        {
            List<Docente> listaDocentes = new List<Docente>();
            SqlConnection conexion = new SqlConnection(cadenaDeConexion);
            int contadorDocentes = 0;
            try
            {
                SqlCommand comando = new SqlCommand("select * from Docente", conexion);
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        contadorDocentes++;

                        listaDocentes.Add(new Docente(
                            lector.GetInt32(0),
                            lector.GetString(1),
                            lector.GetString(2),
                            lector.GetString(3),
                            lector.GetString(4),
                            lector.GetInt32(5),
                            lector.GetBoolean(6),
                            lector.GetInt32(7)
                            
                        ));
                    }
                }
                else
                {
                    Debug.WriteLine("Sin docentes");
                }
            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
                throw;
            }
            finally
            {
                Debug.WriteLine($"Se obtuvieron: {contadorDocentes} docentes");
                conexion.Close();
            }

            return listaDocentes;
        }
    }

    
}
