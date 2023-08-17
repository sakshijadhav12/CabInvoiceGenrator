using CabInvoiceGenerator;

namespace CabInvoiceTestProject
{
    [TestClass]
    public class CabInvoiceTestClass
    {
        [TestMethod]
        public void Given_Ride_Details_Should_Return_Total_Fair()
        {
            //AAA
            Ride ride = new Ride(5,5,Ridecategory.RideType.NORMAl);
            double expected = 55;
            CabInvoiceGeneratorClass cabInvoiceGeneratorClass = new CabInvoiceGeneratorClass();
            //Act
            double actual =cabInvoiceGeneratorClass.CalculateFair(ride);
            //Assert
             Assert.AreEqual(expected, actual);
           

        }
    }
}