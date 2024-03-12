using FitnessCenter.Model;
using FitnessCenter.Model.Class;

namespace FitnessCenter.Admin;

public class Services : IServices
{
    private readonly List<IUser> users;

    public Services()
    {
        users = new List<IUser>();
    }

    public void addUser(IUser user)
    {
        users.Add(user);
    }

    public void removeUser(IUser user)
    {
        users.Remove(user);
    }

    public void editUser(IUser user, string name, DateOnly dob, IAddress address, int age, string collegeName,
        IAddress collegeAddress, string collegeId, string emailId, string empId, string phoneNo)
    {
        if (user is Employee emp)
        {
            if (emp.name.Equals(name) && emp.dob.Equals(dob))
            {
                if (address != null) emp.address = address;
                if (age != 0) emp.age = age;
                if (collegeName != null) emp.companyName = collegeName;
                if (collegeAddress != null) emp.companyAddr = collegeAddress;
                if (empId != null) emp.empId = empId;
                if (emailId != null) emp.emailId = emailId;
                if (phoneNo != null) emp.phoneNo = phoneNo;
                Console.WriteLine("Employee details updated successfully.");
            }
            else
            {
                Console.WriteLine("No user with this name and date of birth found in our system.");
            }
        }
        else if (user is Student std)
        {
            if (std.name.Equals(name) && std.dob.Equals(dob))
            {
                if (address != null) std.address = address;
                if (age != 0) std.age = age;
                if (collegeName != null) std.collegeName = collegeName;
                if (collegeAddress != null) std.collegeAddress = collegeAddress;
                if (empId != null) std.studentId = empId;
                if (emailId != null) std.studentEmail = emailId;
                Console.WriteLine("Student details updated successfully.");
            }
        }
        else
        {
            if (user.name.Equals(name) && user.dob.Equals(dob))
            {
                if (address != null) user.address = address;
                if (age != 0) user.age = age;
                Console.WriteLine("User details updated successfully.");
            }
            else
            {
                Console.WriteLine("No user with this name and date of birth found in our system.");
            }
        }
    }


    public IUser getUser(string name, DateOnly dob, string collegeName, string companyName)
    {
        var user = getUser(name, dob);
        if (user is Employee)
        {
            var emp = (Employee)user;
            if (emp.companyName.Equals(companyName)) return emp;
        }
        else if (user is Student)
        {
            var std = (Student)user;
            if (std.collegeName.Equals(collegeName)) return std;
        }

        return user;
    }

    public IUser getUser(string name, DateOnly dob)
    {
        foreach (var user in users)
        {
            if (user.name.Equals(name) && user.dob.Equals(dob))
                return user;
        }

        return null;
    }

    public void printUser(IUser user)
    {
        if (user is Employee)
        {
            var emp = (Employee)user;
            Console.WriteLine(
                $"Name= {emp.name} Address= {emp.address.printAddress()} Age= {emp.age} Date of Birth= {emp.dob} \nCompany Name= {emp.companyName} Company Address= {emp.companyAddr.printAddress()} Employee Id= {emp.empId} Phone Number= {emp.phoneNo} Email Id= {emp.emailId} Status=Employee");
        }
        else if (user is Student)
        {
            var std = (Student)user;
            Console.WriteLine(
                $"Name= {std.name} Address= {std.address.printAddress()} Age= {std.age} Date of Birth= {std.dob} \nCollege Name= {std.collegeName} College Address= {std.collegeAddress.printAddress()} Student Id= {std.studentId} Student Email= {std.studentEmail} Status=Student");
        }
        else if(user is User)
        {
            Console.WriteLine(
                $"Name= {user.name} Addres= {user.address.printAddress()} Age= {user.age} Date of Birth= {user.dob} Status=User");
        }
        else
        {
            Console.WriteLine("No user details associated");
        }
    }

    public void printUsers()
    {
        foreach (var user in users)
            if (user is Employee)
            {
                var emp = (Employee)user;
                Console.WriteLine(
                    $"Name= {emp.name} Address= {emp.address.printAddress()} Age= {emp.age} Date of Birth= {emp.dob} \nCompany Name= {emp.companyName} Company Address= {emp.companyAddr.printAddress()} Employee Id= {emp.empId} Phone Number= {emp.phoneNo} Email Id= {emp.emailId} Status=Employee");
            }

            else if (user is Student)
            {
                var std = (Student)user;
                Console.WriteLine(
                    $"Name= {std.name} Address= {std.address.printAddress()} Age= {std.age} Date of Birth= {std.dob} \nCollege Name= {std.collegeName} College Address= {std.collegeAddress.printAddress()} Student Id= {std.studentId} Student Email= {std.studentEmail} Status=Student");
            }
            else
            {
                Console.WriteLine(
                    $"Name= {user.name} Addres= {user.address.printAddress()} Age= {user.age} Date of Birth= {user.dob} Status=User");
            }
    }
}