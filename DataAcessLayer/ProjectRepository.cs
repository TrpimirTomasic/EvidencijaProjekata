using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAcessLayer.ViewModels;
using System.Data.Common;
using System.Data.SqlClient;
using DataAccessLayer;

namespace DataAcessLayer
{
    public class ProjectRepository
    {

        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public List<Project> _project = new List<Project>();
        public EmployeeRepository employeeRepo = new EmployeeRepository();
        public CategoryRepository categoryRepo = new CategoryRepository();


        public ProjectRepository()
        {
            //Console.WriteLine("ProjectRepository");
            _project = GetProjects();
        }
        public List<ProjectVM> GetProjectsForView() 
        {

            var employees = employeeRepo.GetEmployees();
            var category = categoryRepo.GetAllCategories();
            Console.WriteLine(employees.Count());
            var employee = _project.Select(o => new ProjectVM
            {               
                id = o.id,
                name = o.name,
                description = o.description, 
                managerFullName = employees.Where(e => e.id == o.id).Select(e => e.name + " " + e.surname).FirstOrDefault(),
                category = category.Where(d => d.id == o.category).Select(d => d.name).FirstOrDefault(),
                deadline = o.deadline,

            }).ToList();
            return employee;
          
        }
        public List<Project> GetProjects() 
        {
            Console.WriteLine("GetProjects");
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
                            manager = (int)reader["Manager"],
                            category = (int)reader["Category"],
                            deadline = (DateTime)reader["Deadline"],
                        });
                    }
                }

            }
            return project;
        }

     
        public void AddProject(Project project, string deadline) 
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                //command.CommandText = "INSERT INTO Project_Project (Id, Name, Description, Deadline, Manager, Category ) VALUES ('" + project.id + "', '" + project.name + "' , '" + project.description + "', '" + DateTime.Parse(project.deadline) + "', '" + project.manager + "', '" + project.category + "')";
                command.CommandText = "INSERT INTO Project_Project (Name, Description, Manager, Category, Deadline ) VALUES ('" + project.name + "' , '" + project.description + "', '" + project.manager + "', '" + project.category + "', '"+ deadline +"')";
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
                //command.CommandText = "UPDATE Project_Project SET Name='" + project.name + "', Description='"+ project.description +"', Deadline='"+ project.deadline+"', Manager = '" + project.manager+ "', Category='" + project.category +"' WHERE Id=" + project.id;
                 command.CommandText = "UPDATE Project_Project SET Name='" + project.name + "', Description='" + project.description + "', Manager = '" + project.manager + "', Category='" + project.category + "' WHERE Id=" + project.id;
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {

                }

            }

        }
    }
}
