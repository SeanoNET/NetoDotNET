using NetoDotNET.Entities.Contents;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Contents
{
    public interface IContentResource
    {

        /// <summary>
        /// Use this call to get product content data.
        /// </summary>
        /// <param name="contentFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetContentFilter"/></param>
        /// <typeparam name="GetContentFilter">
        /// </typeparam>
        /// <returns>content matching the GetContentFilter <see cref="Content"/></returns>
        Content[] GetContent(GetContentFilter contentFilter);
    }
}
