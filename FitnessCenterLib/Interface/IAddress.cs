using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterLib.Interface
{
    public interface IAddress
    {
        int doorNo { get; set; }
        string streetName { get; set; }
        string area { get; set; }
        string city { get; set; }
        int pincode { get; set; }

        string printAddress();
    }
}
