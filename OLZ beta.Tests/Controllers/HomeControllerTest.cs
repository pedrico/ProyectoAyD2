using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OLZ_beta;
using OLZ_beta.Controllers;

namespace OLZ_beta.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;
            //JULIAN
            // Assert
            Assert.AreEqual("OLZ Una manera segura y rápida de comprar por internet.", result.ViewBag.Message, "El mensaje no está bien.");
        }
    }
}
