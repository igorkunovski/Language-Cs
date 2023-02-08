using HW8_OOP.animal;

namespace HW8_OOP.bird
{
    public  class Bird : Animal, IFlyable
    {
        private int flyHeight;
        private bool flyAbility;

        public Bird(int height, float weight, string eyeColor, int flyHeight) : base(height, weight, eyeColor)
        {
            this.flyHeight = flyHeight;
            this.flyAbility = true;
        }


        public int GetFlyHeight()
        {
            return flyHeight;
        }

        public bool GetFlyAbility()
        {
            return flyAbility;
        }

        public void SetFlyAbility(bool flyAbility)
        {
            this.flyAbility = flyAbility;

        }

        public void fly()
        {
            Console.WriteLine("I'm flying at " + GetFlyHeight() + "meters");
        }

        public override string ToString()
        {
            return GetFlyAbility() ?  base.ToString() + ", flyHeight = " + this.GetFlyHeight() + "m" : "flyHeight = " + this.GetFlyHeight() + "m";
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
