using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

// add delete edit get
namespace DataAccessLayer
{
    public class CategoryRepository
    {
        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public List<Category> GetAllCategories() //radi
        {
            List<Category> category = new List<Category>();
            using (DbConnection connection = new SqlConnection(connectionString)) // povezivanje na bazu preko stringa
            using (DbCommand command = connection.CreateCommand()) // pripremanje query-a za čitanje iz baze
            {
                command.CommandText = "SELECT * FROM Project_Category";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        category.Add(new Category()
                        {
                            id = (int)reader["Id"],
                            name = (string)reader["Name"]
                        });
                    }
                }

            }
            return category;
        }
        public void AddCategory(Category category) //radi
        {
            using (DbConnection connection = new SqlConnection(connectionString)) 
            using (DbCommand command = connection.CreateCommand()) 
            {
                command.CommandText = "INSERT INTO Project_Category (Id, Name) VALUES ('"+ category.id +"', '"+ category.name+"')";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                }

            }

        }
        public void DeleteCategory(Category category) //radi
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM Project_Category WHERE Id=" + category.id;
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {

                }

            }

        }
        public void EditCategory(Category category)//radi
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Project_Category SET Name='" + category.name + "' WHERE Id=" + category.id;
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {

                }

            }

        }
    }
}

