using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterLib.Interface
{
    public interface IUser
    {
        string name { get; set; }
        int age { get; set; }
        DateOnly dob { get; set; }
        string sex { get; set; }
        IAddress address { get; set; }
    }
}
