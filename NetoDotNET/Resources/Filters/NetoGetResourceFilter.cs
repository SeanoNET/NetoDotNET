using Newtonsoft.Json;

namespace NetoDotNET.Resources
{
    /// <summary>
    /// Generic get Neto resource filter
    /// </summary>
    public abstract class NetoGetResourceFilter
    {

        /// <summary>
        /// Validates the resource filter. 
        /// </summary>
        /// <returns>bool</returns>
        internal abstract bool isValid();

        private string Serialize<NetoGetResourceFilter>(NetoGetResourceFilter Filter)
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.DefaultValueHandling = DefaultValueHandling.Ignore;

            var root = new
            {
                Filter
            };

            return JsonConvert.SerializeObject(root, settings: settings);
        }
        public virtual string ToJSON()
        {
            return Serialize(this);
        }
    }
}