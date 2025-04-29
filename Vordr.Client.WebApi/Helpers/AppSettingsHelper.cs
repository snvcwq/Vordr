namespace Vordr.Client.WebApi.Helpers;

public static class AppSettingsHelper
{
    public const string PropertySeparator = "__";

    public static void SetValueValue(object target, string keyPath, object newValue)
    {
        var parts = keyPath.Split(PropertySeparator);
        var currentObject = target;

        for (var i = 0; i < parts.Length - 1; i++)
        {
            var prop = currentObject.GetType().GetProperty(parts[i]);
            if (prop == null)
                throw new ArgumentException($"Property '{parts[i]}' not found on type '{currentObject.GetType().Name}'");

            currentObject = prop.GetValue(currentObject);
            if (currentObject == null)
                throw new NullReferenceException($"Property '{parts[i]}' is null.");
        }

        var finalPropertyName = parts[^1];
        var finalProp = currentObject.GetType().GetProperty(finalPropertyName);
        if (finalProp == null)
            throw new ArgumentException($"Property '{finalPropertyName}' not found on type '{currentObject.GetType().Name}'");

        var convertedValue = Convert.ChangeType(newValue, finalProp.PropertyType);
        finalProp.SetValue(currentObject, convertedValue);
    }
}
