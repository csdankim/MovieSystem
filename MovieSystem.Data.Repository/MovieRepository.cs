using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using MovieSystem.Data.Models;

namespace MovieSystem.Data.Repository
{
    public class MovieRepository : IRepository<Movie>
    {
        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from Movie where id = @id";
                return connection.Execute(cmd, new { id = id });
            }
        }

        public IEnumerable<Movie> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Title, Overview, Tagline, Budget, Revenue, ImdbUrl, TmdbUrl, PosterUrl, BackdropUr, OriginalLanguage, ReleaseDate, RunTime, Price, CreatedDate, UpdatedDate, UpdatedBy, CreatedBy from Movie";
                return connection.Query<Movie>(cmd);
            }
        }

        public Movie GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Title, Overview, Tagline, Budget, Revenue, ImdbUrl, TmdbUrl, PosterUrl, BackdropUrl, OriginalLanguage, ReleaseDate, RunTime, Price, CreatedDate, UpdatedDate, UpdatedBy, CreatedBy from Movie where Id = @id";
                
                return connection.QueryFirstOrDefault<Movie>(cmd, new { id = id });
            }
        }

        public int Insert(Movie item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into Movie values(@Title, @Overview, @Tagline, @Budget, @Revenue, @ImdbUrl, @TmdbUrl, @PosterUrl, @BackdropUrl, @OriginalLanguage, @ReleaseDate, @RunTime, @Price, @CreatedDate, @UpdatedDate, @UpdatedBy, @CreatedBy)";
                return connection.Execute(cmd, item);
            }
        }

        public int Update(Movie item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Movie set Title = @Title, Overview = @Overview, Tagline = @Tagline, Budget = @Budget, Revenue = @Revenue, ImdbUrl = @ImdbUrl, TmdbUrl = @TmdbUrl, PosterUrl = @PosterUrl, BackdropUrl = @BackdropUrl, OriginalLanguage = @OriginalLanguage, ReleaseDate = @ReleaseDate, RunTime = @RunTime, Price = @Price, CreatedDate = @CreatedDate, UpdatedDate = @UpdatedDate, UpdatedBy = @UpdatedBy, CreatedBy = @CreatedBy where id = @id";
                return connection.Execute(cmd, item);
            }
        }
    }
}
