// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Blog.Models;
// using Dapper.Contrib.Extensions;
// using Microsoft.Data.SqlClient;

// namespace Blog
// {
//     public class Program
//     {
//         const string CONNECTIONSTRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$; ;Trusted_Connection=False; TrustServerCertificate=True;";
//         public static void Main(string[] args)
//         {
//             Console.Clear();
//             var connection = new SqlConnection(CONNECTIONSTRING);
//             ReadUsers(connection);
//             // CreateRole(connection);
//             System.Console.WriteLine();
//             // ReadRoles(connection);
//             // ReadRole(connection, 2);
//             // DeleteRole(connection, 2);
//             // System.Console.WriteLine();
//             // ReadRoles(connection);
//         }
//         public static void ReadUsers(SqlConnection connection)
//         {
//             var repository = new Repositories.Repository<User>(connection);
//             var users = repository.GetAll();
//             System.Console.WriteLine("Users -> ");
//             foreach (var user in users)
//             {
//                 System.Console.WriteLine(user.Id);
//                 System.Console.WriteLine(user.Name);
//             }
//         }
//         public static void ReadRoles(SqlConnection connection)
//         {
//             var repository = new Repositories.Repository<Role>(connection);
//             var roles = repository.GetAll();
//             System.Console.WriteLine("Roles -> ");
//             foreach (var role in roles)
//             {
//                 System.Console.WriteLine(role.Id);
//                 System.Console.WriteLine(role.Name);
//             }
//         }
//         public static void ReadRole(SqlConnection connection, int id)
//         {
//             var repository = new Repositories.Repository<Role>(connection);
//             var role = repository.Get(id);
//             System.Console.WriteLine("Role -> ");
//             System.Console.WriteLine(role.Id);
//             System.Console.WriteLine(role.Name);
//         }
//         public static void CreateRole(SqlConnection connection)
//         {
//             var repository = new Repositories.Repository<Role>(connection);
//             var role = new Role() { Id = 2, Name = "Role de teste2", Slug = "role-de-teste2" };
//             repository.Create(role);
//         }
//         public static void DeleteRole(SqlConnection connection, int id)
//         {
//             var repository = new Repositories.Repository<Role>(connection);
//             var delete = repository.Delete(id);
//             System.Console.WriteLine(delete);
//         }

//     }
// }