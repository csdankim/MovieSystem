using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Models;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repository
{
    public class GenreRepository : IRepository<Genre>
    {
        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from Cast where id = @id";
                return connection.Execute(cmd, new { id = id });
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from Cast where id = @id";
                var result = await connection.ExecuteAsync(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<Genre> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Name from Genre";
                return connection.Query<Genre>(cmd);
            }
        }

        public async Task<IEnumerable<Genre>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Name from Genre";
                var result = await connection.QueryAsync<Genre>(cmd);
                return result;
            }
        }

        public IEnumerable<Genre> GetAllWith()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Genre>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public Genre GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Name from Genre where Id = @id";
                return connection.QueryFirstOrDefault<Genre>(cmd, new { id = id });
            }
        }

        public async Task<Genre> GetByIdAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Name from Genre where Id = @id";
                var result = await connection.QueryFirstOrDefaultAsync<Genre>(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<Genre> GetByIdWith(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Genre>> GetByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Genre item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into Genre values(@Name)";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> InsertAsync(Genre item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into Genre values(@Name)";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }

        public int Update(Genre item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Genre set Name=@Name where Id=@Id";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> UpdateAsync(Genre item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Genre set Name=@Name where Id=@Id";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
             }
        }
    }
}
