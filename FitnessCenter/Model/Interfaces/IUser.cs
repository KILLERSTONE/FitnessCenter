namespace FitnessCenter.Model;

public interface IUser
{
    string name { get; set; }
    int age{ get; set; }
    DateOnly dob{ get; set; }
    string sex{ get; set; }
    IAddress address{ get; set; }
    
}