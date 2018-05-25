using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDepot.Ohm.Provider
{
   public interface IOhmColorStaticValues
    {
         int SignificantFigures(string color);
         int Multifplier(string color);
         double Tolerance(string color);
    }
}
