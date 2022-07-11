using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Commands
{

    [TestClass]
    internal class CreateBoletoSubscriptionCommandTests
    {


        [TestMethod]
        public void ShouldReturnErrorWhenNameIsInvalid() {

            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "";

            command.Validate();
            Assert.AreEqual(false , command.Valid);
        }
    }
}
