using System;
using APIInteractiveLab1.Controllers;
using APIInteractiveLab1.Models;

namespace APIInteractiveLab1Tests.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        [Test]
        public void Test_Get_CoffeeLover()
        {
            string expectedContent = "I like coffee!";
            var controller = new CoffeeController();
            var result = controller.GetCoffeeLover();
            Assert.AreEqual(expectedContent, result);
        }
        [Test]
        public void Test_Get_Coffee_No_Params()
        {
            int Id = -1;
            string Name = "latte";
            
            Coffee coffee = new Coffee( Id, Name);


            var controller = new CoffeeController();
            var result = controller.Get(null);

            Assert.AreEqual(Name, result.Name);
            Assert.AreEqual(Id, result.Id);
        }
        [Test]
        public void Test_Get_Coffee_By_Name()
        {
            string name = "cappuccino";
            int Id = 7;
           
            Coffee coffee = new Coffee(Id, name);


            var controller = new CoffeeController();
            var result = controller.Get(name);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(Id, result.Id);
        }
    }
}

