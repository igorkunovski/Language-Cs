namespace HW8_OOP.bird
{
    public class Chicken : Bird
    {
        private int flyHeight;
        private bool flyAbility;
        public Chicken(int height, float weight, string eyeColor) : base(height, weight, eyeColor, flyHeight: 0)
        {
            this.flyAbility = false;
            this.flyHeight = 0;
        }

        public override void MakeSound()
        {
            Console.WriteLine("ku-ka-re-ku");
        }

        public override string ToString()
        {
            return "Chicken " + base.ToString();
        }
    }
}
