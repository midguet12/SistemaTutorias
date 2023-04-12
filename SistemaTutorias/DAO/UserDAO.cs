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
        string connectionString = "Server=DESKTOP-JKKF8L6,1433;Database=SistemaTutorias;User Id=SistemaTutorias;Password=Magt22081998;";
        public UserDAO() {
           
        
        }

        public User getUser(string username)
        {
            User user = new User();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand("Select * from [dbo].[User] where username = '" + username + "'", connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        

                        user = new User(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetInt32(2)
                            );
                    }

                }
                else
                {
                    Debug.WriteLine("Sin usuarios");
                }

                reader.Close();


            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
                throw;
            }

            return user;
        }
    }
}
