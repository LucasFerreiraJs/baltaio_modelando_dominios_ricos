
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTest
    {
        private readonly Name _name;
        private readonly Address _address;
        private readonly Document _document;
        private readonly Email _email;
        private readonly Student _student;
        private readonly Subscription _subscription;


        public StudentTest(){
            _name = new Name("Bruce", "Wayne");
            _document = new Document("97989037068", EDocumentType.CPF);
            _address = new Address("Rua 1", "12345", "Bairro Legal", "São Paulo", "SP", "BR", "13400000");
            _email = new Email("teste@teste.com");
            _student = new Student(_name, _document, _email);

            _subscription = new Subscription(null);

        

        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {


            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "teste corp", _document, _address, _email);

            _subscription.AddPayment(payment);

            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Invalid);

        }


        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
        {
 

            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Invalid);

        }



        [TestMethod]
        public void ShouldReturnSuccessWhenAddSubscription()
        {
            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "teste corp", _document, _address, _email);

            _subscription.AddPayment(payment);

            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Valid);

        }
    }

}