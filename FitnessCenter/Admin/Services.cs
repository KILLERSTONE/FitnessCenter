using FitnessCenter.Model;
using FitnessCenter.Model.Class;

namespace FitnessCenter.Admin;

public class Services:IServices
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

    public void editUser(IUser user,string name, DateOnly dob, IAddress address, int age, string collegeName, IAddress collegeAddress, string collegeId, string emailId, string empId, string phoneNo)
    {
        if (user is Employee)
        {
            Employee emp = (Employee)user;

            if (emp.name.Equals(name) && emp.dob.Equals(dob))
            {
                emp.address = address;
                emp.age = age;
                emp.companyName = collegeName;
                emp.companyAddr=collegeAddress;
                emp.empId = empId;
                emp.emailId = emailId;
                emp.phoneNo = phoneNo;
            }
            else
            {
                Console.WriteLine("No user having this credential is in our system");
            }
        }
        if (user is Student)
        {
            Student emp = (Student)user;

            if (emp.name.Equals(name) && emp.dob.Equals(dob))
            {
                emp.address = address;
                emp.age = age;
                emp.collegeName = collegeName;
                emp.collegeAddress=collegeAddress;
                emp.studentId = collegeId;
                emp.studentEmail = emailId;
            }
            else
            {
                Console.WriteLine("No user having this credential is in our system");
            }
        }
        
    }

    public IUser getUser(string name, DateOnly dob, string collegeName, string companyName)
    {

        foreach (IUser user in users)
        {
            if (collegeName != null || collegeName!="")
            {
                if (user is Student)
                {
                    Student std = (Student)user;
                    if (std.name.Equals( name) && std.dob.Equals(dob)) return std;
                }
            }

            if (companyName != null || companyName!="")
            {
                if (user is Employee)
                {
                    Employee emp = (Employee)user;
                    if (emp.name.Equals(name) && emp.dob.Equals(dob)) return emp;
                }
            }
        }


        return null;
    }

    public void printUser(IUser user)
    {
        if (user is Employee)
        {
            Employee emp = (Employee)user;
            Console.WriteLine($"Name= {emp.name} Address= {emp.address.printAddress()} Age= {emp.age} Date of Birth= {emp.dob} \nCompany Name= {emp.companyName} Company Address= {emp.companyAddr.printAddress()} Employee Id= {emp.empId} Phone Number= {emp.phoneNo} Email Id= {emp.emailId} Status=Employee");
        }
        if (user is Student)
        {
            Student std = (Student)user;
            Console.WriteLine($"Name= {std.name} Address= {std.address.printAddress()} Age= {std.age} Date of Birth= {std.dob} \nCollege Name= {std.collegeName} College Address= {std.collegeAddress.printAddress()} Student Id= {std.studentId} Student Email= {std.studentEmail} Status=Student");
        }
        
    }
    
    public void printUsers()
    {

        foreach (IUser user in users)
        {
            if (user is Employee)
            {
                Employee emp = (Employee)user;
                Console.WriteLine($"Name= {emp.name} Address= {emp.address.printAddress()} Age= {emp.age} Date of Birth= {emp.dob} \nCompany Name= {emp.companyName} Company Address= {emp.companyAddr.printAddress()} Employee Id= {emp.empId} Phone Number= {emp.phoneNo} Email Id= {emp.emailId} Status=Employee");
            }

            if (user is Student)
            {
                Student std = (Student)user;
                Console.WriteLine($"Name= {std.name} Address= {std.address.printAddress()} Age= {std.age} Date of Birth= {std.dob} \nCollege Name= {std.collegeName} College Address= {std.collegeAddress.printAddress()} Student Id= {std.studentId} Student Email= {std.studentEmail} Status=Student");
            }
        }

    }

}