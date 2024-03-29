/*using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class Save
{
    public static void SaveToFile<T>(string filePath, T data)
    {
        string json = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public static T LoadFromFile<T>(string filePath)
    {
        if (!File.Exists(filePath)) return default(T);
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<T>(json);
    }
}*/
