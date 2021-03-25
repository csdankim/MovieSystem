using MovieSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repository
{
    public class CastRepository : IRepository<Cast>
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

        public IEnumerable<Cast> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Name, Gender, TmdbUrl, ProfilePath from Cast";
                return connection.Query<Cast>(cmd);
            }
        }

        public async Task<IEnumerable<Cast>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Name, Gender, TmdbUrl, ProfilePath from Cast";
                var result = await connection.QueryAsync<Cast>(cmd);
                return result;
            }
        }

        public IEnumerable<Cast> GetAllWith()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cast>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public Cast GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Name, Gender, TmdbUrl, ProfilePath from Cast where Id = @id";
                return connection.QueryFirstOrDefault<Cast>(cmd, new { id = id });
            }
        }

        public async Task<Cast> GetByIdAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, Name, Gender, TmdbUrl, ProfilePath from Cast where Id = @id";
                var result = await connection.QueryFirstOrDefaultAsync<Cast>(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<Cast> GetByIdWith(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cast>> GetByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Cast item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into Cast values(@Name, @Gender, @TmdbUrl, @ProfilePath)";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> InsertAsync(Cast item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into Cast values(@Name, @Gender, @TmdbUrl, @ProfilePath)";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }

        public int Update(Cast item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Cast set Name=@Name, Gender=@Gender, TmdbUrl=@TmdbUrl, ProfilePath=@ProfilePath where id=@id";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> UpdateAsync(Cast item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Cast set Name=@Name, Gender=@Gender, TmdbUrl=@TmdbUrl, ProfilePath=@ProfilePath where id=@id";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }
    }
}
