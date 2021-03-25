using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Models;
using MovieSystem.Data.Repository;
using System.Threading.Tasks;

namespace MovieSystem.Data.Services
{
    public class UserService
    {
        IRepository<User> userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        public int AddUser(User item)
        {
            return userRepository.Insert(item);
        }

        public int UpdateUser(User item)
        {
            return userRepository.Update(item);
        }

        public int DeleteUser(int id)
        {
            return userRepository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return userRepository.GetById(id);
        }

        //async
        public Task<int> AddUserAsync(User item)
        {
            return userRepository.InsertAsync(item);
        }

        public Task<int> UpdateUserAsync(User item)
        {
            return userRepository.UpdateAsync(item);
        }

        public Task<int> DeleteUserAsync(int id)
        {
            return userRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            return userRepository.GetAllAsync();
        }

        public Task<User> GetByIdAsync(int id)
        {
            return userRepository.GetByIdAsync(id);
        }
    }
}
