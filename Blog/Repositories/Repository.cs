using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;
        public Repository(SqlConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<T> GetAll() => _connection.GetAll<T>();
        public T Get(int id) => _connection.Get<T>(id);
        public long Create(T model) => _connection.Insert<T>(model);
        public bool Update(T model)
        {
            PropertyInfo id = typeof(T).GetProperty("Id");
            if ((int)id.GetValue(model) != 0)
            {
                return _connection.Update<T>(model);
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            if (id <= 0)
                return false;
            var model = Get(id);
            return _connection.Delete<T>(model);
        }
        public bool Delete(T model)
        {
            PropertyInfo id = typeof(T).GetProperty("Id");
            if ((int)id.GetValue(model) != 0)
                return _connection.Delete<T>(model);

            return false;
        }
    }
}