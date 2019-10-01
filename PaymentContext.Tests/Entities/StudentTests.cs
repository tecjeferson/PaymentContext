using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace StudentTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student("Ryan", "Vieira de Vargas", "222916014", "ryan@gmail.com");
            student.AddSubscription(subscription);
        }
    }
}
