using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MVC_Sample;
using MVC_Sample.Controllers;


namespace Sample_Tests
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result =  controller.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(result);



        }
    }
}
