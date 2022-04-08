using CarVentureCore.Interface;
using CarVentureCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVentureCore.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string userFile = "Users.json";
        readonly IReadFromJson _readFromJson;
        public UserRepository(IReadFromJson readFromJson)
        {
            _readFromJson = readFromJson;
        }
        public async Task<bool> AddUser(User model)
        {
            try
            {
                return await _readFromJson.WriteJson(model, userFile);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<User>> GetAllUsers()
        {
            return (List<User>)await _readFromJson.ReadJson<User>(userFile);
        }
    }
}
