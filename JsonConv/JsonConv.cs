using Newtonsoft.Json;

namespace JsonConv
{
    public class JsonConv<t>
    {
        public void Serialize(List<t> data, string filePath)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, json);
        }

        public List<t> Desirealize(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<t>>(json);
        }
    }
}
