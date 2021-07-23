using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk
{
    public class StaffParking : ParkingType
    {

        public override double Calculate(double HoursParked)
        {
            base.Hours = Math.Ceiling(HoursParked);
            double totalCost = 0.0d;
            if (Hours > 24)
            {
                ParkingException newExcept = new ParkingException();
                throw newExcept;
            } else if(Hours > 0)
            {
                totalCost += 2;
            } else if(Hours > 10)
            {
                totalCost += Hours * 2.00;
            }

            return totalCost;
        }

        public override string ParkingInfo()
        {
            throw new System.NotImplementedException();
        }
    }


}