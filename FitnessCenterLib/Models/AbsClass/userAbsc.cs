

using FitnessCenterLib.Interface;

namespace FitnessCenterLib.Models.AbsClass
{
    public abstract class userAbsc : IUser
    {
        protected userAbsc(string name, int age, DateOnly dob, string sex, IAddress address)
        {
            this.name = name;
            this.age = age;
            this.dob = dob;
            this.sex = sex;
            this.address = address;
        }

        public string name { get; set; }
        public int age { get; set; }
        public DateOnly dob { get; set; }
        public string sex { get; set; }
        public IAddress address { get; set; }
    }
}
