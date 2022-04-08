using CarVentureCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVentureCore.Repository
{
    public class AuthenticationRepo: IAuthRepository
    {
        private readonly IUserRepository _userRepository;
        public AuthenticationRepo(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Login(string email, string password)
        {
            var users = await _userRepository.GetAllUsers();
            foreach (var item in users)
            {
                if (item.Email == email && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
