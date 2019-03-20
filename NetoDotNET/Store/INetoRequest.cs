using System.Net.Http;

namespace NetoDotNET.Resources
{
    public interface INetoRequest
    {
        string NetoAPIAction { get; }

        /// <summary>
        /// Validates the Neto request
        /// </summary>
        /// <returns></returns>
        bool isValidRequest();

        string GetBody();
       
    }
}