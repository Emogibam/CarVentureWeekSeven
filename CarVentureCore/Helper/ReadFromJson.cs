using CarVentureCore.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVentureCore.Helper
{
    public class ReadFromJson:IReadFromJson
    {
        private readonly string db = Path.Combine(Environment.CurrentDirectory, @"db\");
        public async Task<bool> WriteJson<T>(T model, string jsonFile)
        {

            try
            {
                string json = JsonConvert.SerializeObject(model) + Environment.NewLine;
                await File.AppendAllTextAsync(db + jsonFile, json);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<List<T>> ReadJson<T>(string jsonFile)
        {
            var readText = await File.ReadAllTextAsync(db + jsonFile);

            var objects = new List<T>();

            var serializer = new JsonSerializer();

            using (var stringReader = new StringReader(readText))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                jsonReader.SupportMultipleContent = true;

                while (jsonReader.Read())
                {
                    T json = serializer.Deserialize<T>(jsonReader);

                    objects.Add(json);
                }
            }

            return objects;
        }


        
    }
}
