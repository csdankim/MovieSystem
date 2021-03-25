using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MovieSystem.Data.Models;
using Dapper;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repository
{
    public class MovieCastRepository : IRepository<MovieCast>
    {
        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from Cast where id = @id";
                return connection.Execute(cmd, new { id = id });
            }
        }

        public IEnumerable<MovieCast> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select MovieId, CastId, Character from MovieCast";
                return connection.Query<MovieCast>(cmd);
            }
        }

        public MovieCast GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select MovieId, CastId, Character from MovieCast where MovieId = @id";
                return connection.QueryFirstOrDefault<MovieCast>(cmd, new { id = id });
            }
        }

        public int Insert(MovieCast item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into MovieCast values(@MovieId, @CastId, @Character)";
                return connection.Execute(cmd, item);
            }
        }

        public int Update(MovieCast item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Cast set MovieId=@MovieId, CastId=@CastId, Character=@Character where MovieId=@id";
                return connection.Execute(cmd, item);
            }
        }
        public IEnumerable<MovieCast> GetAllWith()
        {
            // To-do after class
            /*using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select mc.MovieId, m.Title, m.ReleaseDate, m.Budget, m.Revenue, mc.CastId, mc.Character, c.Name " +
                             "from MovieCast as mc inner join Movie m on mc.MovieId = m.Id inner join Cast c on mc.CastId = c.Id";
                return connection.Query<MovieCast, Movie, Cast, MovieCast>(cmd, (mc, m, c) => { mc.Movie = m; mc.Cast = c; return mc; });
            }*/
            throw new NotImplementedException();
        }

        public IEnumerable<MovieCast> GetByIdWith(int id)
        {
            // To-do after class
            /* using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
             {
                 string cmd = "select mc.MovieId, m.Title, m.ReleaseDate, m.Budget, m.Revenue, mc.CastId, mc.Character, c.Name " +
                              "from MovieCast as mc inner join Movie m on mc.MovieId = m.Id inner join Cast c on mc.CastId = c.Id " +
                              "where mc.MovieId=@id";
                 return connection.Query<MovieCast, Movie, Cast, MovieCast>(cmd, (mc, m, c) => { mc.Movie = m; mc.Cast = c; return mc; }, 
                        new { id = id }, splitOn:"MovieId, Title");
             }*/
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MovieCast>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select MovieId, CastId, Character from MovieCast";
                var result = await connection.QueryAsync<MovieCast>(cmd);
                return result;
            }
        }

        public async Task<MovieCast> GetByIdAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select MovieId, CastId, Character from MovieCast where MovieId = @id";
                var result = await connection.QueryFirstOrDefaultAsync<MovieCast>(cmd, new { id = id });
                return result;
            }
        }

        public async Task<int> InsertAsync(MovieCast item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into MovieCast values(@MovieId, @CastId, @Character)";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }

        public async Task<int> UpdateAsync(MovieCast item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Cast set MovieId=@MovieId, CastId=@CastId, Character=@Character where MovieId=@id";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
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

        public Task<IEnumerable<MovieCast>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieCast>> GetByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
