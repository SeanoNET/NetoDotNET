using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class ShippingTests : NetoBaseTests
    {
        /// <summary>
        /// Test retrieval of shipping methods
        /// </summary>
        [Test]
        public void Should_Get_Shipping_Methods()
        {
            var netoStore = GetStoreManager();

            var result = netoStore.Shipping.GetShippingMethods();

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ShippingMethod);
        }

       
}
}
