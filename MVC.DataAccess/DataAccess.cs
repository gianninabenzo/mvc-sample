using MVC.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MVC.DataAccess
{
    public static class SQLDataAccess
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["CountryContext"].ConnectionString;

        //To View all employees details    
        public static List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SqlCommand command = new SqlCommand(query.ToString(), connection);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;


                try
                {
                    connection.Open();

                    //EJEMPLO DE EXECUTE READER
                    //DataReader vs DataSet
                    command.CommandText = "SelectPeople"; //Nombre del Stored Procedure
                    //command.Parameters.AddWithValue("@Country", paramValue);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Person person = new Person();

                        person.PersonID = int.Parse(reader["Id"].ToString());
                        person.Name = reader["Name"].ToString();
                        person.LastName = reader["LastName"].ToString();
                        person.Phone = reader["Phone"].ToString();
                        person.Email = reader["Email"].ToString();

                        persons.Add(person);
                    }
                    reader.Close();

                    //EJEMPLO EXECUTE SCALAR con Stored Procedure GetCantCustomers
                    //command.CommandText = "GetCantCustomers"; //Nombre del Stored Procedure
                    //command.Parameters.AddWithValue("@Country", paramValue);
                    //int customerAmount = (int)command.ExecuteScalar();
                    //Console.WriteLine("Cantidad de clientes: {0}", customerAmount);

                    //EJEMPLO DE EXECUTE NON QUERY INSERTANDO UN CUSTOMER AddCustomer
                    //command.CommandText = "AddCustomer";
                    //command.Parameters.AddWithValue("@CustomerId", 5);
                    //command.Parameters.AddWithValue("@CustomerName", "Astul Apellido");
                    //command.Parameters.AddWithValue("@ContactName", "El contacto que utiliza Astul como secretario");
                    //command.Parameters.AddWithValue("@Address", "La dirección de Astul");
                    //command.Parameters.AddWithValue("@City", "Moscú");
                    //command.Parameters.AddWithValue("@PostalCode", "20000");
                    //command.Parameters.AddWithValue("@Country", "Rusia");

                    //int rowsAffected = command.ExecuteNonQuery();
                    //Console.WriteLine("Cantidad de clientes insertados: {0}", rowsAffected);
                }
                catch (SqlException sqlEx)
                {

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }


                return persons;
            }
        }


        //To Add new employee record    
        public static void Create(Person persons) //Firma de la función
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SqlCommand command = new SqlCommand(query.ToString(), connection);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;


                try
                {
                    connection.Open();

                    //EJEMPLO DE EXECUTE READER
                    //DataReader vs DataSet
                    command.CommandText = "AddPerson"; //Nombre del Stored Procedure
                                                       //command.Parameters.AddWithValue("@Country", paramValue);




                    //EJEMPLO DE EXECUTE NON QUERY INSERTANDO UN CUSTOMER AddCustomer


                    command.Parameters.AddWithValue("@Name", persons.Name);
                    command.Parameters.AddWithValue("@LastName", persons.LastName);
                    command.Parameters.AddWithValue("@Phone", persons.Phone);
                    command.Parameters.AddWithValue("@Email", persons.Email);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void Edit(Person persons)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SqlCommand command = new SqlCommand(query.ToString(), connection);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;


                try
                {
                    connection.Open();

                    //EJEMPLO DE EXECUTE NON QUERY INSERTANDO UN CUSTOMER AddCustomer
                    command.CommandText = "EditPerson";
                    command.Parameters.AddWithValue("@Id", persons.PersonID);
                    command.Parameters.AddWithValue("@Name", persons.Name);
                    command.Parameters.AddWithValue("@LastName", persons.LastName);
                    command.Parameters.AddWithValue("@Phone", persons.Phone);
                    command.Parameters.AddWithValue("@Email", persons.Email);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
        public static void Delete(int id) //Firma de la función
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SqlCommand command = new SqlCommand(query.ToString(), connection);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;


                try
                {
                    connection.Open();

                    //EJEMPLO DE EXECUTE READER
                    //DataReader vs DataSet
                    command.CommandText = "DeletePerson"; //Nombre del Stored Procedure
                                                       //command.Parameters.AddWithValue("@Country", paramValue);




                    //EJEMPLO DE EXECUTE NON QUERY INSERTANDO UN CUSTOMER AddCustomer


                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}