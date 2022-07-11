
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        //  red/green refactor
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);

        }


        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {

            var doc = new Document("40956197000151", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);

        }




        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {

            var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);

        }


        [TestMethod]
        public void ShouldReturnSuccessWhenCPFIsValid()
        {

            var doc = new Document("97989037068", EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);

        }
    }

}