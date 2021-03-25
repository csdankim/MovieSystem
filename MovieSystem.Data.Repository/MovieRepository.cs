using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using MovieSystem.Data.Models;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repository
{
    public class MovieRepository : IRepository<Movie>
    {
        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from Movie where Id = @id";
                return connection.Execute(cmd, new { id = id });
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from Movie where Id = @id";
                var result = await connection.ExecuteAsync(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<Movie> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Title, Overview, Tagline, Budget, Revenue, ImdbUrl, TmdbUrl, PosterUrl, BackdropUrl, OriginalLanguage, ReleaseDate, RunTime, Price, CreatedDate, UpdatedDate, UpdatedBy, CreatedBy from Movie";
                return connection.Query<Movie>(cmd);
            }
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Title, Overview, Tagline, Budget, Revenue, ImdbUrl, TmdbUrl, PosterUrl, BackdropUrl, OriginalLanguage, ReleaseDate, RunTime, Price, CreatedDate, UpdatedDate, UpdatedBy, CreatedBy from Movie";
                var result = await connection.QueryAsync<Movie>(cmd);
                return result;
            }
        }

        public IEnumerable<Movie> GetAllWith()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Title, Overview, Tagline, Budget, Revenue, ImdbUrl, TmdbUrl, PosterUrl, BackdropUrl, OriginalLanguage, ReleaseDate, RunTime, Price, CreatedDate, UpdatedDate, UpdatedBy, CreatedBy from Movie where Id = @id";
                return connection.QueryFirstOrDefault<Movie>(cmd, new { id = id });
            }
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Title, Overview, Tagline, Budget, Revenue, ImdbUrl, TmdbUrl, PosterUrl, BackdropUrl, OriginalLanguage, ReleaseDate, RunTime, Price, CreatedDate, UpdatedDate, UpdatedBy, CreatedBy from Movie where Id = @id";
                var result = await connection.QueryFirstOrDefaultAsync<Movie>(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<Movie> GetByIdWith(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Movie item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into Movie values(@Title, @Overview, @Tagline, @Budget, @Revenue, @ImdbUrl, @TmdbUrl, @PosterUrl, @BackdropUrl, @OriginalLanguage, @ReleaseDate, @RunTime, @Price, @CreatedDate, @UpdatedDate, @UpdatedBy, @CreatedBy)";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> InsertAsync(Movie item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into Movie values(@Title, @Overview, @Tagline, @Budget, @Revenue, @ImdbUrl, @TmdbUrl, @PosterUrl, @BackdropUrl, @OriginalLanguage, @ReleaseDate, @RunTime, @Price, @CreatedDate, @UpdatedDate, @UpdatedBy, @CreatedBy)";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }

        public int Update(Movie item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Movie set Title = @Title, Overview = @Overview, Tagline = @Tagline, Budget = @Budget, Revenue = @Revenue, ImdbUrl = @ImdbUrl, TmdbUrl = @TmdbUrl, PosterUrl = @PosterUrl, BackdropUrl = @BackdropUrl, OriginalLanguage = @OriginalLanguage, ReleaseDate = @ReleaseDate, RunTime = @RunTime, Price = @Price, CreatedDate = @CreatedDate, UpdatedDate = @UpdatedDate, UpdatedBy = @UpdatedBy, CreatedBy = @CreatedBy where Id = @id";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> UpdateAsync(Movie item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Movie set Title = @Title, Overview = @Overview, Tagline = @Tagline, Budget = @Budget, Revenue = @Revenue, ImdbUrl = @ImdbUrl, TmdbUrl = @TmdbUrl, PosterUrl = @PosterUrl, BackdropUrl = @BackdropUrl, OriginalLanguage = @OriginalLanguage, ReleaseDate = @ReleaseDate, RunTime = @RunTime, Price = @Price, CreatedDate = @CreatedDate, UpdatedDate = @UpdatedDate, UpdatedBy = @UpdatedBy, CreatedBy = @CreatedBy where Id = @id";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
             }
        }
    }
}
