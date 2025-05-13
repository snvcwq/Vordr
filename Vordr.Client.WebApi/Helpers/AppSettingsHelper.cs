using System.Text.Json;
using System.Text.Json.Serialization;

namespace Vordr.Client.WebApi.Helpers;

public static class AppSettingsHelper
{
 private const string AppSettingsFilePath = "appsettings.json";
 public const string Separator = "__";
 private static readonly Lock Lock = new();

    private static dynamic? _configInstance;

    public static void Load<T>() where T : class, new()
    {
        lock (Lock)
        {
            if (!File.Exists(AppSettingsFilePath))
                throw new FileNotFoundException($"Could not find {AppSettingsFilePath}");

            var json = File.ReadAllText(AppSettingsFilePath);
            _configInstance = JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
            }) ?? throw new InvalidOperationException("Failed to deserialize appsettings");
        }
    }

    public static void UpdateValue(string keyPath, object newValue)
    {
        lock (Lock)
        {
            if (_configInstance == null)
                throw new InvalidOperationException("AppSettings not loaded. Call Load<T>() first.");

            var parts = keyPath.Split(Separator);
            var current = _configInstance;

            for (var i = 0; i < parts.Length - 1; i++)
            {
                var prop = current.GetType().GetProperty(parts[i]);
                if (prop == null) throw new ArgumentException($"Property '{parts[i]}' not found.");
                current = prop.GetValue(current) ?? throw new NullReferenceException($"Property '{parts[i]}' is null.");
            }

            var finalProp = current.GetType().GetProperty(parts[^1]);
            if (finalProp == null) throw new ArgumentException($"Property '{parts[^1]}' not found.");

            var converted = Convert.ChangeType(newValue, finalProp.PropertyType);
            finalProp.SetValue(current, converted);

            Save();
        }
    }

    private static void Save()
    {
        var json = JsonSerializer.Serialize(_configInstance, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText(AppSettingsFilePath, json);
    }
}
