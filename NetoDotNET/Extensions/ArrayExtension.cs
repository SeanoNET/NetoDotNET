using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Extensions
{
    internal static class ArrayExtension
    {
        /// <summary>
        /// Null safe array length check
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Length if the array or 0 if null</returns>
        public static int NullSafeLength(this Array array)
        {
            if (array == null)
            {
                return 0;
            }
            else
            {
                return array.Length;
            }
        }
    }
}
