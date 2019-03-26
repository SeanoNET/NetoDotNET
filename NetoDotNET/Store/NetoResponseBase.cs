using NetoDotNET.Exceptions;
using NetoDotNET.Objects;
using Newtonsoft.Json;

namespace NetoDotNET
{

    public class NetoResponseBase
    {
        [JsonProperty("Messages")]
        public ResponseMessage Messages { get; private set; }

        [JsonProperty("CurrentTime")]
        public string CurrentTime { get; private set; }

        [JsonProperty("Ack")]
        public Ack Ack { get; private set; }

        /// <summary>
        /// Checks the response to make sure no errors are present.
        /// </summary>
        /// <exception cref="System.NetoRequestException">Thrown when Neto response Ack has Error status.</exception>
        /// <returns>false on valid response</returns>
        internal void ThrowOnError() {
            if (this.Ack == Ack.Error)
            {
                throw new NetoRequestException(this.Messages.Error[0].Message);
            }
        }

    }

}
