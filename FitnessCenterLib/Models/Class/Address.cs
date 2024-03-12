using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCenterLib.Models.AbsClass;

namespace FitnessCenterLib.Models.Class
{
    public class Address : addressAbsc
    {
        public Address(int doorNo, string streetName, string area, string city, int pincode) : base(doorNo, streetName,
            area, city, pincode)
        {
        }
    }
}
