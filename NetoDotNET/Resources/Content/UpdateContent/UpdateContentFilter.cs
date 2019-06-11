using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Contents
{
    public class UpdateContentFilter : NetoUpdateResourceFilter
    {
        public Content[] Content { get; set; }

        public UpdateContentFilter(Content[] content)
        {
            this.Content = content;
        }

        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}
