namespace FitnessCenter.Model;

public interface IAddress
{
    int doorNo { get; set; }
    string streetName{ get; set; }
    string area{ get; set; }
    string city{ get; set; }
    int pincode{ get; set; }

    string printAddress();
}