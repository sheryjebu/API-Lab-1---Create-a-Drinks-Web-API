using APIInteractiveLab1.Controllers;
namespace APIInteractiveLab1.Tests.Controllers
{
    public class HomeControllerTests
    {
        // this attribute tells NUnit to run this method as a test
        [Test]
        public void TestGetHome()
        {
            // ARRANGE - we set up everything needed for our test
            string expectedContent = "Welcome to the Drinks API!";
        
            var controller = new HomeController();
            // ACT - we perform the test
            var result = controller.Get();
            // ASSERT - we compare the result to the expected result
             Assert.AreEqual(expectedContent, result);
        }
    }
}
