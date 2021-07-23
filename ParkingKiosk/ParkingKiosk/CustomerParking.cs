using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk
{
    public class CustomerParking : ParkingType
    {

        public override double Calculate(double HoursParked)
        {
            base.Hours = Math.Ceiling(HoursParked);

            if(Hours > 24)
            {
                ParkingException newExcept = new ParkingException();
                throw newExcept;
            }
            else
            {
                return Hours * 2.00;
            }
        }

        public override string ParkingInfo()
        {
            return "Parking Price \r\n $2.00 per hour \r\nsssssssss Max parking time: 24 hours";
        }
    }
}