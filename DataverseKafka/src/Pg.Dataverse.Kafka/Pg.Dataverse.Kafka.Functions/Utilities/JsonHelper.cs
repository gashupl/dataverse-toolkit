using System.Runtime.Serialization.Json;
using System.Text;

namespace Pg.Dataverse.Kafka.Functions.Utilities
{
    public static class JsonHelper
    {
        public static string FormatJson(string unformattedJson)
        {
            string formattedJson = string.Empty;
            try
            {
                formattedJson = unformattedJson.Trim('"');
                formattedJson = System.Text.RegularExpressions.Regex.Unescape(formattedJson);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return formattedJson;
        }

        public static T DeserializeJsonString<T>(string jsonString)
        {
            //create an instance of generic type object
            var instance = Activator.CreateInstance<T>();
            if (instance != null)
            {
                using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonString)))
                {
                    var serializer = new DataContractJsonSerializer(instance.GetType());

                    if (serializer != null)
                    {
                        instance = (T?)serializer?.ReadObject(ms);
                        ms.Close();

                    }
                }
            }

            return instance;
        }
    }
}
