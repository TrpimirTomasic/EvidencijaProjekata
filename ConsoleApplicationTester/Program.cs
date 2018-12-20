using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAcessLayer;
using DataAccessLayer;

namespace ConsoleApplicationTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //var categoryRepo = new CategoryRepository();   
            //var categories = categoryRepo.GetAllCategories();
            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category.id + " " + category.name);
            //}



            //var employeeRepo = new EmployeeRepository();
            //var employees = employeeRepo.GetEmployees();
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.id + " " + employee.name + " " + employee.surname);
            //}

         

            var projRepo = new ProjectRepository();   
            var projects = projRepo.GetProjects();  
            foreach (var project in projects)
            {
                Console.WriteLine(project.id + " " + project.name +" "+ project.deadline + " " + project.description);
            }

            //Project _project = new Project();
            //_project.id = 8;
            //_project.name = "Fortika";
            //_project.description = "kewl";
            ////_project.deadline =;
            //_project.manager = 5;
            //_project.category = 4;
            //projRepo.AddProject(_project);


            //Project _project = new Project();
            //_project.id = 8;
            //_project.name = "Fortika";
            //_project.description = "kewl";
            ////_project.deadline =;
            //_project.manager = 5;
            //_project.category = 4;
            //projRepo.DeleteProject(_project);

            Console.ReadLine();
        }
    }
}
