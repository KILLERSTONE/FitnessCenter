using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCenterLib.Interface;

namespace FitnessCenterLib.Admin
{
    public interface IServices
    {
        void addUser(IUser user);
        void removeUser(IUser user);

        IUser getUser(string name, DateOnly dob);

        void editUser(IUser user, string name, DateOnly dob, IAddress address, int age, string collegeName,
            IAddress collegeAddress, string collegeId, string emailId, string empId, string phoneNo);

        IUser getUser(string name, DateOnly dob, string collegeName, string companyName);

        void printUser(IUser user);
        void printUsers();
    }
}
