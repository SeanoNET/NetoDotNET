using System.Net.Http;

namespace NetoDotNET.Resources
{
    public interface INetoRequest
    {
        /// <summary>
        /// The request you want to make. Required.
        /// </summary>
        /// <returns></returns>
        string NetoAPIAction { get; }

        /// <summary>
        /// Validates the Neto request
        /// </summary>
        /// <returns>true or false</returns>
        bool isValidRequest();

        /// <summary>
        /// Returns the JSON for the request body
        /// </summary>
        /// <returns></returns>
        string GetBody();
       
    }
}