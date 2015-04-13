using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Luis.MasteringExtJs.WebApi.Mapping;
using D = Luis.MasteringExtJs.WebApi.Models;
using R = Luis.MasteringExtJs.WebApi.Repository;

namespace Luis.MasteringExtJs.WebApi.Handlers
{
    public interface IUserHandler
    {
        Task<List<D.User>> GetUsers();
        Task<D.User> AddUser(D.User user);
        Task<D.User> UpdateUser(int userId, D.User user);
        Task<D.User> DeleteUser(int userId);
        Task<D.User> GetUser(int userId);
    }

    public class UserHandler : IUserHandler
    {
        private readonly R.SakilaEntities _sakilaEntities;

        public UserHandler(R.SakilaEntities sakilaEntities)
        {
            _sakilaEntities = sakilaEntities;
        }

        public async Task<List<D.User>> GetUsers()
        {
            var users = (await _sakilaEntities.Users.ToListAsync()).ToDomain();
            return users;
        }

        public async Task<D.User> AddUser(D.User user)
        {
            _sakilaEntities.Users.Add(user.ToRepository());
            user.Id = await _sakilaEntities.SaveChangesAsync();
            return user;
        }

        public async Task<D.User> UpdateUser(int userId, D.User user)
        {
            if (!UserExists(userId))
            {
                return null;
            }

            _sakilaEntities.Entry(user.ToRepository()).State = EntityState.Modified;

            await _sakilaEntities.SaveChangesAsync();

            return user;
        }

        public async Task<D.User> DeleteUser(int userId)
        {
            var user = await _sakilaEntities.Users.FindAsync(userId);

            if (user == null) 
                return null;

            _sakilaEntities.Users.Remove(user);

            await _sakilaEntities.SaveChangesAsync();

            return user.ToDomain();
        }

        public async Task<D.User> GetUser(int userId)
        {
            var user = await _sakilaEntities.Users.FindAsync(userId);

            if (user == null)
                return null;

            return user.ToDomain();
        }

        private bool UserExists(int id)
        {
            var userExits = _sakilaEntities.Users.Count(e => e.Id == id) > 0;
            return userExits;
        }
    }
}