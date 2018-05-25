using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDepot.Ohm.Model;

namespace HomeDepot.Ohm.Provider
{
   public class OhmCalculator : IOhmCalculator
    {
        private IOhmColorStaticValues _ohmColorStaticValues;


       public  OhmCalculator(IOhmColorStaticValues _ohmColorStaticValues)
        {
            this._ohmColorStaticValues = _ohmColorStaticValues;
        }

        ResistenceValues IOhmCalculator.CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            ResistenceValues resistenceValues = new ResistenceValues();
            int bandAColorValue = _ohmColorStaticValues.SignificantFigures(bandAColor);
            int bandBColorValue = _ohmColorStaticValues.SignificantFigures(bandBColor);
            int bandCColorValue_Multiplier = _ohmColorStaticValues.Multifplier(bandCColor);
            double bandDColorValue_Tolarance = _ohmColorStaticValues.Tolerance(bandDColor);
            bandDColorValue_Tolarance = bandDColorValue_Tolarance == 0 ? 1 : bandDColorValue_Tolarance;
            resistenceValues.MaximumResistance = FormatResistance(Convert.ToInt32(string.Format("{0}{1}", bandAColorValue, bandBColorValue)) * (Math.Pow(10, bandCColorValue_Multiplier) * (1 + bandDColorValue_Tolarance)));
            resistenceValues.MinimumResistance = FormatResistance(Convert.ToInt32(string.Format("{0}{1}", bandAColorValue, bandBColorValue)) * (Math.Pow(10, bandCColorValue_Multiplier) * (1 - bandDColorValue_Tolarance)));

            return resistenceValues;
        }

        public string FormatResistance(double num)
        {
            // Mega format 
            if (num >= 100000000)
                return (num / 1000000).ToString("#,0M");

            else if (num >= 10000000)
                return (num / 1000000).ToString("0.#") + "M";
            // Kilo format
            else if (num >= 100000)
                return (num / 1000).ToString("#,0K");

            else if (num >= 10000)
                return (num / 1000).ToString("0.#") + "K";

            else
                return num.ToString();

        }
    }
}
