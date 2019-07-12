using Newtonsoft.Json;

namespace NetoDotNET.Resources
{
    /// <summary>
    /// Generic add Neto resource filter
    /// </summary>
    public abstract class NetoAddResourceFilter
    {

        /// <summary>
        /// Validates the resource filter. 
        /// </summary>
        /// <returns>bool</returns>
        internal abstract bool isValid();

        protected virtual string Serialize<NetoGetResourceFilter>(NetoGetResourceFilter Filter)
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            //settings.DefaultValueHandling = DefaultValueHandling.Ignore;

            return JsonConvert.SerializeObject(Filter, settings: settings);
        }
        public string ToJSON()
        {
            return Serialize(this);
        }
    }
}