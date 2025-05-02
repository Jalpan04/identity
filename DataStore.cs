using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PersonalInterestApp
{
    public static class DataStore<T>
    {
        private static string GetPath(string typeName) => $"{typeName}.json";

        public static List<T> Load(string typeName)
        {
            var path = GetPath(typeName);
            if (!File.Exists(path)) return new List<T>();

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(json);
        }

        public static void Save(List<T> items, string typeName)
        {
            var json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(GetPath(typeName), json);
        }
    }
}