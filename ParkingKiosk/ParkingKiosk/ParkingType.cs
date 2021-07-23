using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk
{
    public class ParkingType
    {
        private double _hours;

        public double Hours
        {
            get
            {
                return _hours;
            }

            set
            {
                _hours = value;
            }
        }

        public virtual double Calculate(double HoursParked)
        {
            throw new System.NotImplementedException();
        }

        public virtual string ParkingInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}