using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UmbracoTrial.Controllers;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void NewSubmition_Returns_ActionResult()
        {
            PrizeDrawerController prizeDrawerController = new PrizeDrawerController();

            ViewResult result = prizeDrawerController.NewSubmition() as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void IfSerialNumberExists()
        {
            //DrawSubmition drawSubmition = new DrawSubmition();
            DrawEntryRepository drawEntryReposiroty = DrawEntryRepository.Instance;


            Assert.IsTrue(drawEntryReposiroty.SerialNumberExists("01725f5cf2a64c15a580bd8cddf8b835"));

            

        }
    }
}
