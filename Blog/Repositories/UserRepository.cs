using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UserRepository
    {
        private readonly SqlConnection _connection;
        public UserRepository(SqlConnection connection) => _connection = connection;
        public IEnumerable<User> GetAll() => _connection.GetAll<User>();
        public User Get(int id) => _connection.Get<User>(id);
        public long Create(User user) => _connection.Insert<User>(user);
        public bool Update(User user)
        {
            if (user.Id != 0)
            {
                return _connection.Update<User>(user);
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            if (id != 0)
                return false;
            var user = Get(id);
            return _connection.Delete<User>(user);
        }
        public bool Delete(User user)
        {
            if (user.Id != 0)
                return _connection.Delete<User>(user);

            return false;
        }

    }
}