using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Utility
{
    public class Serialization<T>
    {

        public bool SerializeToJsonFile(string filePath, List<T> objects)
        {
            File.Delete(filePath);
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var obj in objects)
                    {
                        sw.WriteLine(SerializeObject(obj));
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<T> DeserializeFromJsonFile(string filePath)
        {
            List<T> objects = new List<T>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    T obj = DeSerializeToObject(line);
                    objects.Add(obj);

                }
            }
            return objects;
        }

        public string SerializeObject(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public T DeSerializeToObject(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }

}
