using System.Text.Json;

namespace Vordr.Client.WebApi.Config;

public static class ConfigManager
{
    private static readonly string ConfigPath = Path.Combine(AppContext.BaseDirectory, "config.json");
    private static readonly Lock Lock = new();
    private static Dictionary<string, string> _config = null!;

    public static void LoadData()
    {
        Load();
    }

    private static void Load()
    {
        lock (Lock)
        {
            if (!File.Exists(ConfigPath))
            {
                _config = new Dictionary<string, string>();
                Save();
            }
            else
            {
                var json = File.ReadAllText(ConfigPath);
                _config = JsonSerializer.Deserialize<Dictionary<string, string>>(json)
                          ?? new Dictionary<string, string>();
            }
        }
    }

    private static void Save()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(_config, options);
        File.WriteAllText(ConfigPath, json);
    }

    public static string? Get(string key)
    {
        lock (Lock)
        {
            return _config.GetValueOrDefault(key);
        }
    }

    public static void Set(string key, string value)
    {
        lock (Lock)
        {
            _config[key] = value;
            Save();
        }
    }

    public static void Remove(string key)
    {
        lock (Lock)
        {
            if (_config.Remove(key))
                Save();
        }
    }

    public static bool Contains(string key)
    {
        lock (Lock)
        {
            return _config.ContainsKey(key);
        }
    }

    public static IReadOnlyDictionary<string, string> GetAll()
    {
        lock (Lock)
        {
            return new Dictionary<string, string>(_config);
        }
    }
}
