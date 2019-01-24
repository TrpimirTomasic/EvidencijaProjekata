using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using System.Data.Common;
using System.Data.SqlClient;
using DataAcessLayer.ViewModels;
namespace DataAcessLayer
{


    public class EmployeeRepository
    {
        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        List<Employee> _employee = new List<Employee>();
        public EmployeeRepository()
        {
            _employee = GetEmployees();
        }

        public List<Employee> GetEmployees() 
        {
            List<Employee> employee = new List<Employee>();
            using (DbConnection connection = new SqlConnection(connectionString)) 
            using (DbCommand command = connection.CreateCommand()) 
            {
                command.CommandText = "SELECT * FROM Project_Employee";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employee.Add(new Employee()
                        {
                            id = (int)reader["Id"],
                            name = (string)reader["Name"],
                            surname = (string)reader["Surname"]
                        });
                    }
                }

            }
            return employee;
        }


        public void AddEmployee(Employee employee) 
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Project_Employee (Id, Name, Surname) VALUES ('" + employee.id + "', '" + employee.name + "' , '"+ employee.surname +"')";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                }

            }

        }
        public void DeleteEmployee(Employee employee) 
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM Project_Employee WHERE Id=" + employee.id;
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {

                }

            }

        }
        public void EditEmployee(Employee employee) 
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Project_Employee SET Name='" + employee.name + "', Surname='" + employee.surname +"' WHERE Id=" + employee.id;
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {

                }

            }

        }

        public int GetEmployeeID(string name)
        {
            int employee = 0;
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Project_Employee WHERE CONVERT(VARCHAR, Name) ='"+ name +"'";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                      employee = (int)reader["Id"];
                    }
                }

            }
            return employee;
        }
    }
}
