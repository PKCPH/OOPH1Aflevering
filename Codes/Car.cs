using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.Codes
{
    internal class Car : MotorVehicle
    {

        public string? Brand { get; set; }

        //For Question 2.1
        public string? Model { get; set; }

        //Vehicle Tax for Question 4.1
        public virtual double VehicleTax()
        {
            //Formular for VehicleTax

            //example of an number to return
            return 2.1;
        }

    }
}
