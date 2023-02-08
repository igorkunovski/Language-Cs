using HW8_OOP.pet;

namespace HW8_OOP.wild
{
    public class Wolf : Wild
    {
        private bool leader;

        public Wolf(int height, float weight, string eyeColor, string place, int foundYear, bool leader) : base(height, weight, eyeColor, place, foundYear)
        {
            this.leader = leader;
        }

       
        public bool IsLeader()
        {
            return leader;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wolf is howling...");
        }

        public void SetLeadership(bool leader)
        {
            this.leader = leader;
        }

        public override string ToString()
        {
            return "Wolf: " + base.ToString() +
                ", leaderhip=" + IsLeader();
        }
    }
}
