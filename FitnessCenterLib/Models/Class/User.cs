using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCenterLib.Interface;
using FitnessCenterLib.Models.AbsClass;

namespace FitnessCenterLib.Models.Class
{
    public class User : userAbsc
    {
        public User(string name, int age, DateOnly dob, string sex, IAddress address) : base(name, age, dob, sex, address)
        {
        }
    }
}
