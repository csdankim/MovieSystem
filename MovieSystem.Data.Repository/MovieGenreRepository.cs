using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Models;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repository
{
    public class MovieGenreRepository : IRepository<MovieGenre>
    {
        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from Cast where MovieId = @id";
                return connection.Execute(cmd, new { id = id });
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from Cast where MovieId = @id";
                var result = await connection.ExecuteAsync(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<MovieGenre> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select MovieId, GenreId from MovieGenre";
                return connection.Query<MovieGenre>(cmd);
            }
        }

        public async Task<IEnumerable<MovieGenre>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select MovieId, GenreId from MovieGenre";
                var result = await connection.QueryAsync<MovieGenre>(cmd);
                return result;
            }
        }

        public IEnumerable<MovieGenre> GetAllWith()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieGenre>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public MovieGenre GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select MovieId, GenreId from MovieGenre where MovieId = @id";
                return connection.QueryFirstOrDefault<MovieGenre>(cmd, new { id = id });
            }
        }

        public async Task<MovieGenre> GetByIdAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select MovieId, GenreId from MovieGenre where MovieId = @id";
                var result = await connection.QueryFirstOrDefaultAsync<MovieGenre>(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<MovieGenre> GetByIdWith(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieGenre>> GetByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(MovieGenre item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into MovieGenre values(@MovieId, @GenreId)";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> InsertAsync(MovieGenre item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into MovieGenre values(@MovieId, @GenreId)";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }

        public int Update(MovieGenre item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update MovieGenre set GenreId = @GenreId where MovieId=@MovieId";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> UpdateAsync(MovieGenre item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update MovieGenre set GenreId = @GenreId where MovieId=@MovieId";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }
    }
}
