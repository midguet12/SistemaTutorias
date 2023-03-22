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

    internal class StudentDAO
    {
        string connectionString = "Server=MB1,1433;Database=SistemaTutorias;User Id=SistemaTutorias;Password=Magt22081998;";

        public StudentDAO()
        {

        }
        public List<Student> getStudents()
        {
            List<Student> listStudents = new List<Student>();

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand("Select * from [dbo].[Student]", connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        listStudents.Add(new Student(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4)
                        ));
                       
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
            return listStudents;
        }
    }

    
}
