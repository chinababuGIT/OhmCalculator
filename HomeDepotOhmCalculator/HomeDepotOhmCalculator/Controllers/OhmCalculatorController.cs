using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeDepot.Ohm.Provider;
using HomeDepot.Ohm.Model;
using HomeDepotOhmCalculator.Models;

namespace HomeDepotOhmCalculator.Controllers
{
    public class OhmCalculatorController : Controller
    {
        private IOhmCalculator _ohmCalculator;

        public OhmCalculatorController(IOhmCalculator ohmCalculator)
        {
            this._ohmCalculator = ohmCalculator;
        }

        // GET: OhmCalculator
        public ActionResult Index()
        {
            OhmDropDownData OhmDropDownData = new OhmDropDownData();
            return View(OhmDropDownData);
        }

        [HttpPost]
        public ActionResult CalculateResistenceValue(string _bandAColor, string _bandBColor, string _bandCColor, string _bandDColor)
        {
            try
            {
                ResistenceValues resistenceValues = _ohmCalculator.CalculateOhmValue(_bandAColor, _bandBColor, _bandCColor, _bandDColor);

                return Json(new { minimumValue = resistenceValues.MinimumResistance, maximumValue = resistenceValues.MaximumResistance });
            }
            catch (Exception ex)
            {
                return Json(new { error = "Resistence Calculation Error: " + ex.Message });
            }

        }
    }
}