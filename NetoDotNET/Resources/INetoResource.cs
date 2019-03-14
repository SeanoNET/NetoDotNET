using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources
{
     public interface INetoResource<T>
    {

   
        Uri BuildURI();

        T Get(string id);


    }
}
