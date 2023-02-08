using HW8_OOP.pet;

namespace HW8_OOP.wild
{
    public class Tiger : Wild
    {
        public Tiger(int height, float weight, string eyeColor, string place, int foundYear) 
            : base(height, weight, eyeColor, place, foundYear)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Tiger's  Rrr-rr!!");
        }

        public override string ToString()
        {
            return "Tiger: " + base.ToString();
        }
    }
}
