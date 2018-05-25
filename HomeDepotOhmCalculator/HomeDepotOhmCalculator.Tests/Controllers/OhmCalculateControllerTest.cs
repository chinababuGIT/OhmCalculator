using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Xunit;
using FakeItEasy;
using HomeDepotOhmCalculator.Controllers;
using HomeDepot.Ohm.Provider;
using System.Web.Mvc;
using HomeDepot.Ohm.Model;
namespace HomeDepotOhmCalculator.Tests.Controllers
{
    [TestClass]
    public class OhmCalculateControllerTest
    {

        ResistenceValues resistenceValues = new ResistenceValues();
        private readonly OhmCalculatorController ohmCalculateController;
        public OhmCalculateControllerTest()
        {
            ohmCalculateController = new OhmCalculatorController( A.Fake<IOhmCalculator>());
        }
       
        [TestMethod]
        public void ResisterValues_Pass_All_Null()
        {
            Exception exceptionResult = null;

            try
            {
                ohmCalculateController.CalculateResistenceValue(null, null, null, null);
            }
            catch (Exception exception)
            {
                exceptionResult = exception;
            }

            // Assert
            Assert.IsNull(exceptionResult);
        }

        [TestMethod]
        public void Colors_Colletion_OutOf_Colors()
        {
            Exception exceptionResult = null;

            try
            {
                 ohmCalculateController.CalculateResistenceValue("black", "orange", "pink", "silver");
            }
            catch (Exception exception)
            {
                exceptionResult = exception;
            }

            // Assert
            Assert.IsNull(exceptionResult);
        }

    }
}
