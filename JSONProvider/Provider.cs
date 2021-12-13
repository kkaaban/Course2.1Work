using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JSONProvider
{
    public static class Provider
    {
        public static void Serialize<T>(T objects, string path)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
            if (File.Exists(path))
                File.Delete(path);
            using (var file = new FileStream(path, FileMode.Create))
            {
                jsonFormatter.WriteObject(file, objects);
            }
        }
        public static T Deserialize<T>(string path)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(T));
            T obj;
            using (var file = new FileStream(path, FileMode.Open))
            {
                obj = (T)jsonFormatter.ReadObject(file);
            }
            return obj;
        }
    }
}
