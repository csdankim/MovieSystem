using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Models;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repository
{
    public class ReviewRepository : IRepository<Review>
    {
        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from Review where MovieId = @id";
                return connection.Execute(cmd, new { id = id });
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from Review where MovieId = @id";
                var result = await connection.ExecuteAsync(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<Review> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "Select MovieId, UserId, Rating, ReviewText from Review"; 
                return connection.Query<Review>(cmd);
            }
        }

        public async Task<IEnumerable<Review>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "Select MovieId, UserId, Rating, ReviewText from Review";
                var result = await connection.QueryAsync<Review>(cmd);
                return result;
            }
        }

        public IEnumerable<Review> GetAllWith()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public Review GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select MovieId, UserId, Rating, ReviewText from Review where MovieId = @id";
                return connection.QueryFirstOrDefault<Review>(cmd, new { id = id });
            }
        }

        public async Task<Review> GetByIdAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select MovieId, UserId, Rating, ReviewText from Review where MovieId = @id";
                var result = await connection.QueryFirstOrDefaultAsync<Review>(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<Review> GetByIdWith(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Review item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into Review values(@MovieId, @UserId, @Rating, @ReviewText)";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> InsertAsync(Review item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into Review values(@MovieId, @UserId, @Rating, @ReviewText)";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }

        public int Update(Review item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Review set UserId=@UserId, Rating=@Rating, ReviewText=@ReviewText where MovieId=@MovieId";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> UpdateAsync(Review item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update Review set UserId=@UserId, Rating=@Rating, ReviewText=@ReviewText where MovieId=@MovieId";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }
    }
}
