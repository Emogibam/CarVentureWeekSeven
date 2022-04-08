using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVentureCore.Interface
{
   public interface IAuthRepository
    {
        Task<bool> Login(string email, string password);
    }
}
