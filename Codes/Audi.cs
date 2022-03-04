using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes
{
    internal class Audi : Car
    {

        public string? Model { get; set; }

        //Question 4.1
        public override double VehicleTax()
        {

            //overridden method

            //example of returned value
            return 2.2;

        }
    }

}
