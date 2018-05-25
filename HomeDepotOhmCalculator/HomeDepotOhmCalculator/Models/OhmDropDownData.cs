using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDepotOhmCalculator.Models
{
   public class OhmDropDownData
    {
            // For Band A & B drop down data
            public Dictionary<string, string> significantData;
        // For Band C drop down data
        public Dictionary<string, string> multiflierData;
        // For Band D drop down data
        public Dictionary<string, string> toleranceData;

            public OhmDropDownData()
            {
            significantData = new Dictionary<string, string> {
                    {"black", "0 Black"},
                    {"brown", "1 brown"},
                    {"red", "2 red"},
                    {"orange", "3 orange"},
                    {"yellow", "4 yellow"},
                    {"green", "5 green"},
                    {"blue", "6 blue"},
                    {"violet", "7 violet"},
                    {"gray", "8 gray"},
                    {"white", "9 white"}
                };

            multiflierData = new Dictionary<string, string> {
                    {"pink", "÷1000 Pink"},
                    {"silver", "÷100 Silver"},
                    {"gold", "÷10 Gold"},
                    {"black", "x1 Black"},
                    {"brown", "x10 Brown"},
                    {"red", "x100 Red"},
                    {"orange", "x1k Orange"},
                    {"yellow", "x10k Yellow"},
                    {"green", "x100k Green"},
                    {"blue", "x1M Blue"},
                    {"violet",  "x10M Violet"},
                    {"gray",  "x100M Gray"},
                    {"white", "1G White"}
            };

            toleranceData = new Dictionary<string, string> {
                    {"gray", "± 0.05% Gray"},
                    {"violet", "± 0.1% Violet"},
                    {"blue",  "± 0.25% Blue"},
                    {"green", "± 0.5% Green"},
                    {"brown", "± 1% Brown"},
                    {"red", "± 2% Red"},
                    {"yellow", "± 4% Yellow"},
                    {"gold",  "± 5% Gold"},
                    {"silver",  "± 10% Silver"}
            };
            }
    }
}
