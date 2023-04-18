﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SistemaTutorias.Domain;

namespace SistemaTutorias.DAO
{
    internal class UsuarioDAO
    {
        string cadenaDeConexion = "Server=192.168.1.155,1433;Database=SistemaTutorias;User Id=SistemaTutorias;Password=Magt220819981;";

        public Usuario getUsuario(string nombreUsuario)
        {
            Usuario usuario = new Usuario();
            SqlDataReader lector = null;
            SqlConnection conexion = new SqlConnection(cadenaDeConexion);

            try
            {
                

                SqlCommand comando = new SqlCommand($"Select * from [dbo].[Usuario] where username = '{nombreUsuario}'", conexion);

                conexion.Open();
                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {

                    while (lector.Read())
                    {


                        usuario = new Usuario(
                            lector.GetString(0),
                            lector.GetString(1),
                            lector.GetInt32(2)
                            );
                    }

                }
                else
                {
                    Debug.WriteLine("Sin usuarios");
                }

                lector.Close();


            }
            catch (Exception error)
            {
                conexion.Close();
                Debug.WriteLine(error.Message);
                throw;
                
            }
            finally
            {
                conexion.Close();
            }



            return usuario;

        }
    }

    
}
