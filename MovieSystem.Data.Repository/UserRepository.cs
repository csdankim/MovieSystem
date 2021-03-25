using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Models;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repository
{
    public class UserRepository : IRepository<User>
    {
        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from User where Id = @id";
                return connection.Execute(cmd, new { id = id });
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "delete from User where Id = @id";
                var result = await connection.ExecuteAsync(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, FirstName, LastName, DateOfBirth, Email, HashedPassword, Salt, PhoneNumber, TwoFactorEnabled, LockoutEndDate, LastLoginDateTime, IsLocked, AccessFailedCount from User";
                return connection.Query<User>(cmd);
            }
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllWith()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, FirstName, LastName, DateOfBirth, Email, HashedPassword, Salt, PhoneNumber, TwoFactorEnabled, LockoutEndDate, LastLoginDateTime, IsLocked, AccessFailedCount from User where Id = @id";
                return connection.QueryFirstOrDefault<User>(cmd, new { id = id });
            }
        }

        public async Task<User> GetByIdAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "select Id, FirstName, LastName, DateOfBirth, Email, HashedPassword, Salt, PhoneNumber, TwoFactorEnabled, LockoutEndDate, LastLoginDateTime, IsLocked, AccessFailedCount from User where Id = @id";
                var result = await connection.QueryFirstOrDefaultAsync<User>(cmd, new { id = id });
                return result;
            }
        }

        public IEnumerable<User> GetByIdWith(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(User item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into User values(@FirstName, @LastName, @DateOfBirth, @Email, @HashedPassword, @Salt, @PhoneNumber, @TwoFactorEnabled, @LockoutEndDate, @LastLoginDateTime, @IsLocked, @AccessFailedCount)";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> InsertAsync(User item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "insert into User values(@FirstName, @LastName, @DateOfBirth, @Email, @HashedPassword, @Salt, @PhoneNumber, @TwoFactorEnabled, @LockoutEndDate, @LastLoginDateTime, @IsLocked, @AccessFailedCount)";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }

        public int Update(User item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update User set FirstName=@FirstName, LastName=@LastName, DateOfBirth=@DateOfBirth, Email=@Email, HashedPassword=@HashedPassword, Salt=@Salt, PhoneNumber=@PhoneNumber, TwoFactorEnabled=@TwoFactorEnabled, LockoutEndDate=@LockoutEndDate, LastLoginDateTime=@LastLoginDateTime, IsLocked=@IsLocked, AccessFailedCount=@AccessFailedCount where Id = @id";
                return connection.Execute(cmd, item);
            }
        }

        public async Task<int> UpdateAsync(User item)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                string cmd = "update User set FirstName=@FirstName, LastName=@LastName, DateOfBirth=@DateOfBirth, Email=@Email, HashedPassword=@HashedPassword, Salt=@Salt, PhoneNumber=@PhoneNumber, TwoFactorEnabled=@TwoFactorEnabled, LockoutEndDate=@LockoutEndDate, LastLoginDateTime=@LastLoginDateTime, IsLocked=@IsLocked, AccessFailedCount=@AccessFailedCount where Id = @id";
                var result = await connection.ExecuteAsync(cmd, item);
                return result;
            }
        }
    }
}
