using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTutorias.Domain;

namespace SistemaTutorias.DAO
{
    internal class UserDAO
    {
        string connectionString = "Server=MB1,1433;Database=SistemaTutorias;User Id=SistemaTutorias;Password=Magt22081998;";
        public UserDAO() {


            
             
            
        
        }

        public User prueba()
        {

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand("Select * from [dbo].[User]", connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) { 
                    
                    while (reader.Read())
                    {
                        Debug.WriteLine(reader.GetString(0) + reader.GetString(1));

                    }
                    
                }
                else
                {
                    Debug.WriteLine("Sin filas");
                }

                reader.Close();

            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
                throw;
            }
            return new User();
        }
    }
}
