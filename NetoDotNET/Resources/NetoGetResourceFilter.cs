using Newtonsoft.Json;

namespace NetoDotNET.Resources
{


    public abstract class NetoGetResourceFilter
    {

        /// <summary>
        /// Checks for at least one filter in the GetItem request. 
        /// </summary>
        /// <returns>bool</returns>
        internal abstract bool isValid();

        private string Serialize<NetoFilter>(NetoFilter Filter)
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
        public string ToJSON()
        {
            return Serialize(this);
        }
    }
}