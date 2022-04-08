using CarVentureCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVentureCore.Helper
{
    public class ServiceHelper : IServiceHelper
    {
        public int Random()
        {
            Random rnd = new();
            return rnd.Next(1, 15);
        }
    }
}
