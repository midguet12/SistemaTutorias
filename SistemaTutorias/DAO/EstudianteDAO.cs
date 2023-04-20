using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Printing;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SistemaTutorias.Domain;
using SistemaTutorias.DAO;


namespace SistemaTutorias.DAO
{
    internal class EstudianteDAO
    {
        string cadenaDeConexion = Conexion.cadenaDeConexion;
    
        public EstudianteDAO()
        {

        }

        public Boolean registrarEstudiante(Estudiante estudiante)
        {
            Boolean registrado = false;
            Int32 contador;
            SqlConnection conexion = new SqlConnection(cadenaDeConexion);
            SqlCommand comando;

            try
            {
                comando = new SqlCommand($"INSERT INTO Estudiante " +
                    $"VALUES ('{estudiante.nombre}'," +
                    $"'{estudiante.apellidoPaterno}'," +
                    $"'{estudiante.apellidoMaterno}'," +
                    $"'{estudiante.matricula}'," +
                    $"'{estudiante.programaEducativo}', " +
                    $"'z{estudiante.matricula}@estudiantes.uv.mx');", conexion);
                conexion.Open();
                contador = comando.ExecuteNonQuery();

                if (contador !=0)
                {
                    Debug.WriteLine($"Se registraron: {contador} estudiantes");
                    registrado = true;
                }
                
                throw new Exception();

            }
            catch (SqlException error)
            {
                Debug.WriteLine("Estudiante ya se encuentra registrado: " + error.Message);
                throw;
                
            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
                throw;

            } finally 
            {conexion.Close();}

            
        }

        

        public Estudiante getEstudiante(string matricula)
        {
            Estudiante estudiante = new Estudiante() ;
            SqlDataReader lector = null;
            SqlConnection conexion = new SqlConnection(cadenaDeConexion);
           
           
            try
            {

                SqlCommand comando = new SqlCommand($"Select * from [dbo].[Estudiante] where matricula = '{matricula}';", conexion);

                conexion.Open();
                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    
                    lector.Read();
                    Debug.WriteLine($"Estudiante {lector.GetString(0)} obtenido");
                    estudiante = new Estudiante(
                        lector.GetString(0),
                        lector.GetString(1),
                        lector.GetString(2),
                        lector.GetString(3),
                        lector.GetString(4),
                        lector.GetString(5)
                        );
                }
                else
                {
                    Debug.WriteLine("Usuario no encontrado");
                }

                
            }
            catch (Exception error)
            {
                
                Debug.WriteLine(error.Message);
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return estudiante;

        }

        public List<Estudiante> getEstudiantes()
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            SqlConnection conexion = new SqlConnection(cadenaDeConexion);
            Int16 contadorEstudiantes = 0;
            try
            {
                SqlCommand comando = new SqlCommand("Select * from [dbo].[Estudiante]", conexion);
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {

                    while (lector.Read())
                    {
                        contadorEstudiantes++;
                        listaEstudiantes.Add(new Estudiante(
                            lector.GetString(0),
                            lector.GetString(1),
                            lector.GetString(2),
                            lector.GetString(3),
                            lector.GetString(4),
                            lector.GetString(5)
                        ));

                    }

                }
                else
                {
                    Debug.WriteLine("Sin usuarios");
                }

                
            }
            catch (Exception error)
            {
                
                Debug.WriteLine(error.Message);
                throw;
            }
            finally
            {
                Debug.WriteLine($"Se obtuvieron: {contadorEstudiantes} estudiantes");
                conexion.Close();
            }



            return listaEstudiantes;
        }

        public Boolean actualizarEstudiante(String matriculaPrevia, Estudiante estudiante)
        {
            Boolean actualizado = false;
            Int32 contador;
            SqlConnection conexion = new SqlConnection(cadenaDeConexion);
            SqlCommand comando;

            try
            {

                comando = new SqlCommand($"update Estudiante set " +
                    $"nombre = '{estudiante.nombre}', " +
                    $"apellidoPaterno = '{estudiante.apellidoPaterno}', " +
                    $"apellidoMaterno ='{estudiante.apellidoMaterno}', " +
                    $"matricula ='{estudiante.matricula}', " +
                    $"programaEducativo = '{estudiante.programaEducativo}', " +
                    $"correoInstitucional ='{estudiante.correoInstitucional}' " +
                    $"where matricula = '{matriculaPrevia}';\r\n", conexion);

                conexion.Open();
                contador = comando.ExecuteNonQuery();

                if (contador != 0)
                {
                    Debug.WriteLine($"Se actualizaron: {contador} lineas");
                    actualizado = true;

                }
                else
                {
                    Debug.WriteLine("No se pudo actualizar");
                }


            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
                return actualizado = false;
                throw;

            }
            finally
            {
                conexion.Close();
            }



            return actualizado;
        }

        public Boolean eliminarEstudiante(Estudiante estudiante)
        {
            Boolean registrado = false;
            Int32 contador;
            SqlConnection conexion = new SqlConnection(cadenaDeConexion);
            SqlCommand comando;

            try
            {
                comando = new SqlCommand($"delete from Estudiante where matricula = '{estudiante.matricula}';", conexion);
                conexion.Open();
                contador = comando.ExecuteNonQuery();

                if (contador != 0)
                {
                    Debug.WriteLine($"Se eliminaron: {contador} estudiantes");
                    registrado = true;
                }
            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
                return registrado = false;
                throw;
            }
            finally { conexion.Close(); }

            return registrado;
        }
    }
}
