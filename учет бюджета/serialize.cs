using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace учет_бюджета
{
    internal class serialize
    {
        public static void Serialize<T>(T list)
        {
            string json = JsonConvert.SerializeObject(list);
            string path = "";
            File.WriteAllText(path, json);
        }
        public static T Deserialize<T>()
        {
            string path = "";
            string json = File.ReadAllText(path); ;
            T list = JsonConvert.DeserializeObject<T>(json);
            return list;
        }
    }
}
