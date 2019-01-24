using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;


namespace DataAccessLayer
{
    public class CategoryRepository
    {
        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public List<Category> GetAllCategories()
        {
            List<Category> category = new List<Category>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
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
        public List<string> GetCategoriesName()
        {
            List<string> category = new List<string>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Project_Category";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        category.Add(  (string)reader["Name"] );
                    }
                }

            }
            return category;
        }
        public void AddCategory(Category category) 
        {
            using (DbConnection connection = new SqlConnection(connectionString)) 
            using (DbCommand command = connection.CreateCommand()) 
            {
                command.CommandText = "INSERT INTO Project_Category (Name) VALUES ('"+ category.name+"')";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                }

            }

        }
        public void DeleteCategory(Category category)
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
        public void EditCategory(Category category)
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
        public int GetCategoryID(string name)
        {
            int category = 0;
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Project_Category WHERE  CONVERT(VARCHAR, Name) ='" + name + "'";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        category = (int)reader["Id"];
                    }
                }

            }
            return category;
        }
    }
}

