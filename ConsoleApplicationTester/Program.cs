using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAcessLayer;

namespace ConsoleApplicationTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //var categoryRepo = new CategoryRepository();          
            //Category kateg = new Category();
            //kateg.id = 1;
            //kateg.name = "Database";
            //categoryRepo.EditCategory(kateg);
            //var categories = categoryRepo.GetAllCategories();
            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category.id + " " + category.name);
            //}



            //var employeeRepo = new EmployeeRepository();
            //Employee emp = new Employee();
            //emp.id = 2;
            //emp.name = "Mirko";
            //emp.surname = "Marković";
            //employeeRepo.DeleteEmployee(emp);
            //var employees = employeeRepo.GetEmployees();
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.id + " " + employee.name + " " + employee.surname);
            //}


            var projRepo = new ProjectRepository();
            Project pro = new Project();
            pro.id = 2;
            pro.name = "Plava Tvornica";
            pro.description = "Web dizajn";
            pro.manager = 1;
            pro.category = 3;
            projRepo.EditProject(pro);
            var projects = projRepo.GetProjects();
            foreach (var project in projects)
            {
                Console.WriteLine(project.id + " " + project.name + " " + project.description);
            }


            Console.ReadLine();
        }
    }
}
