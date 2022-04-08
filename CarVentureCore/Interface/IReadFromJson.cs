using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CarVentureCore.Interface
{
    public interface IReadFromJson
    {
        Task<List<T>> ReadJson<T>(string jsonFile);
        Task<bool> WriteJson<T>(T model, string jsonFile);

    }
}
