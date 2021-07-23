using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk
{
    public class ParkingException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Your car has been towed because you were parked for more than 24 hours";
            }
        }
    }
}