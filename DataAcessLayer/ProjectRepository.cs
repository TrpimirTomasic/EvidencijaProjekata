using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using System.Data.Common;
using System.Data.SqlClient;


namespace DataAcessLayer
{
    public class ProjectRepository
    {

        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public List<Project> GetProjects() 
        {
            List<Project> project = new List<Project>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Project_Project";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        project.Add(new Project()
                        {
                            id = (int)reader["Id"],
                            name = (string)reader["Name"],
                           description = (string)reader["Description"],
                            deadline = (DateTime)reader["Deadline"],
                            manager = (int)reader["Manager"],
                            category = (int)reader["Category"]
                         });
                    }
                }

            }
            return project;
        }

        //Conversion failed when converting date and/or time from character string.
        public void AddProject(Project project) 
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
               // command.CommandText = "INSERT INTO Project_Project (Id, Name, Description, Deadline, Manager, Category ) VALUES ('" + project.id + "', '" + project.name + "' , '" + project.description + "', '" + project.deadline + "', '" + project.manager + "', '" + project.category + "')";
                command.CommandText = "INSERT INTO Project_Project (Id, Name, Description, Manager, Category ) VALUES ('" + project.id + "', '" + project.name + "' , '" + project.description + "', '" + project.manager + "', '" + project.category + "')";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                }

            }

        }
        public void DeleteProject(Project project) 
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM Project_Project WHERE Id=" + project.id;
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {

                }

            }

        }
        public void EditProject(Project project)
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Project_Project SET Name='" + project.name + "', Description='"+ project.description +"', Deadline='"+ project.deadline+"', Manager = '" + project.manager+ "', Category='" + project.category +"' WHERE Id=" + project.id;
                // command.CommandText = "UPDATE Project_Project SET Name='" + project.name + "', Description='" + project.description + "', Manager = '" + project.manager + "', Category='" + project.category + "' WHERE Id=" + project.id;
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {

                }

            }

        }
    }
}
