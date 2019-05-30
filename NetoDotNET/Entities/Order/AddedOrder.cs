using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class AddedOrder
    {
        public string OrderID { get; set; }
        public StickyNotes[] StickyNotes { get; set; }
    }
}
