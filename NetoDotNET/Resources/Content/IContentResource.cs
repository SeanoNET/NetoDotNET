using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Contents
{
    public interface IContentResource
    {

        /// <summary>
        /// Use this call to get content page.
        /// </summary>
        /// <param name="contentFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetContentFilter"/></param>
        /// <typeparam name="GetContentFilter">
        /// </typeparam>
        /// <returns>content matching the GetContentFilter <see cref="Content"/></returns>
        Content[] GetContent(GetContentFilter contentFilter);


        /// <summary>
        /// Use this call to add a new content page.
        /// </summary>
        /// <param name="content">New content page to add.</param>
        /// <typeparam name="Content">
        /// </typeparam>
        /// <returns>returns the unique identifier (ContentID) for the content page, and the date and time the content page was added (CurrentTime) <see cref="AddContentResponse"/></returns>
        AddContentResponse AddContent(Content[] content);

        /// <summary>
        /// Use this call to update an existing content page.
        /// </summary>
        /// <param name="content">Content page to update. <see cref="Content"/></param>
        /// <typeparam name="Content">
        /// </typeparam>
        /// <returns>The unique identifier (ContentID) for the  content page, and the date and time the  content page was updated (CurrentTime) <see cref="UpdateContentResponse"/></returns>
        UpdateContentResponse UpdateContent(Content[] content);
    }
}
