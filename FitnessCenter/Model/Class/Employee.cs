namespace FitnessCenter.Model.Class;

public class Employee : userAbsc
{
    public Employee(string name, int age, DateOnly dob, string sex, IAddress address, string companyName,
        IAddress companyAddr, string empId, string phoneNo, string emailId) : base(name, age, dob, sex, address)
    {
        this.companyName = companyName;
        this.companyAddr = companyAddr;
        this.empId = empId;
        this.phoneNo = phoneNo;
        this.emailId = emailId;
    }

    public string companyName { get; set; }
    public IAddress companyAddr { get; set; }
    public string empId { get; set; }
    public string phoneNo { get; set; }
    public string emailId { get; set; }
}