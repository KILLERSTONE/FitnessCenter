namespace FitnessCenter.Model.Class;

public abstract class addressAbsc : IAddress
{
    public addressAbsc(int doorNo, string streetName, string area, string city, int pincode)
    {
        this.doorNo = doorNo;
        this.streetName = streetName;
        this.area = area;
        this.city = city;
        this.pincode = pincode;
    }

    public string printAddress()
    {
        return "DoorNo: " + doorNo + ", Street Name: " + streetName + ", Area: " + area + ", City: " + city +
               ", Pincode: " + pincode;
    }

    public int doorNo { get; set; }
    public string streetName { get; set; }
    public string area { get; set; }
    public string city { get; set; }
    public int pincode { get; set; }
}