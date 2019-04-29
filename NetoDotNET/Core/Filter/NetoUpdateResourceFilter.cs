using Newtonsoft.Json;

namespace NetoDotNET.Resources
{
    public abstract class NetoUpdateResourceFilter
    {

        /// <summary>
        /// Validates the get resource filter. 
        /// </summary>
        /// <returns>bool</returns>
        internal abstract bool isValid();

        private string Serialize<NetoGetResourceFilter>(NetoGetResourceFilter Filter)
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.DefaultValueHandling = DefaultValueHandling.Ignore;

            return JsonConvert.SerializeObject(Filter, settings: settings);
        }
        public string ToJSON()
        {
            return Serialize(this);
        }
    }
}