using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcIntegrationTestFramework;
using MvcIntegrationTestFramework.Hosting;
using MvcIntegrationTestFramework.Browsing;
using NUnit;
using NUnit.Framework;
using System.IO;
using MVC_Sample.Controllers;
using System.Web.Mvc;

namespace Sample_Tests
{
    //[TestFixture]
    //public class IntegrationTest
    //{
    //    // Amend this path to point to whatever folder contains your ASP.NET MVC application
    //    // (i.e., the folder that contains your app's main web.config file)
    //    private static readonly string mvcAppPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "C:\Users\Emergency\Downloads\New folssssdeDDr\New folder\MVC Sample");
    //    private readonly AppHost appHost = new AppHost(mvcAppPath);


    //    [Test]
    //    public void HomeIndex_DemoTests()
    //    {
    //        appHost.(browsingSession => {
    //            RequestResult result = browsingSession.ProcessRequest("home/index");

    //            // Routing config should match "home" controller
    //            Assert.AreEqual("home", result.ActionExecutedContext.RouteData.Values["controller"]);

    //            // Should have rendered the "index" view
    //            ActionResult actionResult = result.ActionExecutedContext.Result;
    //            Assert.IsInstanceOf(typeof(ViewResult), actionResult);
    //            Assert.AreEqual("index", ((ViewResult)actionResult).ViewName);

    //            // App should not have had an unhandled exception
    //            Assert.IsNull(result.ResultExecutedContext.Exception);
    //        });
    //    }



    //    [Test]
    //    public void Root_Url_Renders_Index_View()
    //    {
    //        AppHost.SimulateBrowsingSession(browsingSession => {
    //            // Request the root URL
    //            RequestResult result = browsingSession.ProcessRequest("/");

    //            // You can make assertions about the ActionResult...
    //            //var viewResult = (ViewResult)result.ActionExecutedContext.Result;
    //            //Assert.AreEqual("Index", viewResult.ViewName);
    //            //Assert.AreEqual("Welcome to ASP.NET MVC!", viewResult.ViewData["Message"]);

    //            // ... or you can make assertions about the rendered HTML
    //            Assert.IsTrue(result.ResponseText.Contains("<!DOCTYPE html"));
    //        });
    //    }
    //}[TestCase]

    [TestFixture]

    public class IntegrationTest
    {
        //private static readonly string mvcAppPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "");
        //private readonly AppHost appHost = new AppHost(mvcAppPath);




        [TestCase]
        public void Does_Index_Displays_Html()
        {


            //dónde va 


            //Arrange
            //RequestResult result = .ProcessRequest("/");
            //appHost.(browsingSession =>
            //{
            //    RequestResult result = browsingSession.ProcessRequest("home/index");


            HomeController controller = new HomeController();



            //Act

            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsTrue(result.Model(mvc)


            });

        }
    }
}