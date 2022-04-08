using CarVentureCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVentureCore.Interface
{
    public interface IUserRepository
    {
        Task<bool> AddUser(User model);
        Task<List<User>> GetAllUsers();
    }
}
