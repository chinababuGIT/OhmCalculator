﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDepot.Ohm.Provider
{
    public class OhmColorStaticValues : IOhmColorStaticValues
    {
        public int Multifplier(string color)
        {
            Dictionary<string,int> multiplier = new Dictionary<string, int> {
                    {"pink", -3},
                    {"silver",  -2},
                    {"gold",  -1},
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange",3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue",  6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
            };
            return multiplier[color];
        }

        public int SignificantFigures(string color)
        {
            Dictionary<string, int>  significantFigures = new Dictionary<string, int> {
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange", 3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue", 6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
                };
            return significantFigures[color];

        }

        public double Tolerance(string color)
        {
            Dictionary<string, double> tolerance = new Dictionary<string, double> {
                    {"pink", 0.00},
                    {"silver", 0.10},
                    {"gold", 0.05},
                    {"brown",  0.01},
                    {"red", 0.02},
                    {"yellow", 0.05},
                    {"green", 0.005},
                    {"blue", 0.0025},
                    {"violet", 0.001},
                    {"gray", 0.0005}
               
            };

            return tolerance[color];
        }
    }
}
