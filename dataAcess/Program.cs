using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using dataAcess.Models;
using Microsoft.Data.SqlClient;

namespace dataAcess
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$; ;Trusted_Connection=False; TrustServerCertificate=True;";

            using (var connection = new SqlConnection(connectionString))
            {
                // ListCategories(connection);
                // UpdateCategory(connection);
                Console.Clear();
                GetCategories(connection);
                DeleteCategory(connection, new Guid("ea8059a2-e679-4e74-99b5-e4f0b310fe6f"));
                GetCategories(connection);

            }

        }
        static void GetCategories(SqlConnection connetionSring)
        {
            var categories = connetionSring.Query<Category>("SELECT [id], [title] FROM Category");
            foreach (var item in categories)
            {
                System.Console.WriteLine($"ID -> {item.Id} \t TITLE -> {item.Title}");
            }
        }
        static void CreateCategory(SqlConnection connectionString)
        {
            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "Amazon AWS";
            category.Url = "url";
            category.Description = "Curso AWS";
            category.Featured = false;
            category.Summary = "Sumário";
            category.Order = 8;
            var insertSql = @"INSERT INTO Category VALUES(@Id,@Title,@url,@summary,@order,@description,@featured)";
            var rows = connectionString.Execute(insertSql, new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featured
            });
            System.Console.WriteLine($"{rows} linhas inseridas");

        }
        static void UpdateCategory(SqlConnection connectionString, Category category)
        {
            var UpdateCategory = "UPDATE Category SET Title = @Title WHERE Id = @id";
            var rows = connectionString.Execute(UpdateCategory, new
            {
                id = category.Id,
                title = category.Title,
            });
        }
        static void CreateManyCategory(SqlConnection connectionString)
        {
            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "Amazon AWS";
            category.Url = "url";
            category.Description = "Curso AWS";
            category.Featured = false;
            category.Summary = "Sumário";
            category.Order = 8;
            var category2 = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "New category";
            category.Url = "url";
            category.Description = "New category";
            category.Featured = true;
            category.Summary = "Sumário";
            category.Order = 9;

        }
    }