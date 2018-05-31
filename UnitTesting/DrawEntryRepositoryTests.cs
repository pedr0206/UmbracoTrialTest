using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class DrawEntryRepositoryTests
    {
        [TestMethod]
        public void Add_IsEqualTo_ReturnTrue()  //SerialNumberExists_Scenario_ExpectedBehavour
        {
            //Arrange
            var drawEntryRepository = DrawEntryRepository.Instance;

            //Act
            var result = drawEntryRepository.Add( new DrawSubmition { Age >= 18 } );
            //Assert
            Assert.AreEqual()
        }
        
    }
}
