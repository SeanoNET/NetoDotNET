using NetoDotNET.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class PaymentTests : NetoBaseTests
    {

        #region GetPaymentMethods
        /// <summary>
        /// Test retrieval of all payment methods
        /// </summary>
        [Test]
        public void Should_Get_All_Payment_Methods()
        {
            var netoStore = GetStoreManager();

            PaymentMethods result = netoStore.Payment.GetPaymentMethods();

            Assert.IsNotNull(result);
           // Assert.AreEqual(Ack.Success, result.Ack);
            Assert.IsNotNull(result.PaymentMethod);
        }
        #endregion
    }
}
