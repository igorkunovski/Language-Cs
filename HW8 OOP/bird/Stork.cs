namespace HW8_OOP.bird
{
    public class Stork : Bird
    {
        
        private bool flyAbility;
        public Stork(int height, float weight, string eyeColor, int flyHeight) : base(height, weight, eyeColor, flyHeight)
        {
            this.flyAbility = true;

        }

        public override void MakeSound()
        {
            Console.WriteLine("Tr-tr-tr - stork sound");
        }

        public override string ToString()
        {
            return "Stork " + base.ToString();
        }
    }
}
