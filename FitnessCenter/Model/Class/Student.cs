namespace FitnessCenter.Model.Class;

public class Student:userAbsc
{
    public string collegeName { get; set; }
     public IAddress collegeAddress { get; set; }
     public string studentId { get; set; }
     public string studentEmail { get; set; }

    public Student(string name, int age, DateOnly dob, string sex, IAddress address, string collegeName, IAddress collegeAddress, string studentId, string studentEmail) : base(name, age, dob, sex, address)
    {
        this.collegeName = collegeName;
        this.collegeAddress = collegeAddress;
        this.studentId = studentId;
        this.studentEmail = studentEmail;
    }
}