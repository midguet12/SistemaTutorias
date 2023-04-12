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
        string connectionString = "Server=DESKTOP-JKKF8L6,1433;Database=SistemaTutorias;User Id=SistemaTutorias;Password=Magt22081998;";

        public StudentDAO()
        {

        }
        public Student getStudent(string matricula)
        {
            Student student = null;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                

                SqlCommand command = new SqlCommand("Select * from [dbo].[Student] where matricula = '" + matricula + "'", connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    //student = new Student(reader.GetString(0));

                    string prueba = reader.GetString(0);
                    Debug.WriteLine(prueba);
                   

                }
                else
                {
                    Debug.WriteLine("Sin datos");
                }

                reader.Close();
            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }


            return student;
        }

        public List<Student> getStudents()
        {
            List<Student> listStudents = new List<Student>();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                

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
                            reader.GetString(4),
                            reader.GetString(5)
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
            finally
            {
                connection.Close();
            }
            return listStudents;
        }
    }

    
}
