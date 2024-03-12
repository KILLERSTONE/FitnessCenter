namespace FitnessCenter.Model.Class;

public class User : userAbsc
{
    public User(string name, int age, DateOnly dob, string sex, IAddress address) : base(name, age, dob, sex, address)
    {
    }
}