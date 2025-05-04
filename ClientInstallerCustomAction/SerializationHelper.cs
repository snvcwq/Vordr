using Newtonsoft.Json;
using System;
using System.Text;

namespace MyCustomAction
{
    public static class SerializationHelper
    {
        public static T JsonDeserialize<T>(this string str)
        {
            T value = default;
            try
            {
                return JsonConvert.DeserializeObject<T>(str);
            }
            catch (Exception)
            {
                return value;
            }
        }

        public static string FromBytes(this int received, byte[] buffer)
        {
            return Encoding.UTF8.GetString(buffer, 0, received);
        }
    }
}
