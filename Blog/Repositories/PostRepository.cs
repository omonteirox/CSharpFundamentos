using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class PostRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;
        public PostRepository(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }
        public void AddTag(int postId, int tagId)
        {
            var query = @"
            INSERT INTO [PostTag] (PostId, TagId)
            VALUES (@PostId, @TagId)";
            _connection.Execute(query, new { PostId = postId, TagId = tagId });
        }
        // public IEnumerable<Post> GetWithPostsCount()
        // {
        //     var query = @"
        //     SELECT [Post].*, [Category].*
        //     FROM [Post]
        //     INNER JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
        //     INNER JOIN [Role] ON [Role].[Id] = [UserRole].[RoleId]";
        //     return _connection.Query<Category>(query);
        // }

    }
}