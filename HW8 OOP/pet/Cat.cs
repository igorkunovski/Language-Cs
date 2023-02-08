namespace HW8_OOP.pet
{
    public class Cat:Pet
    {
        private bool hasWool;

        public Cat(int height, float weight, string eyeColor, string name, string breed, string color, int birthYear, bool hasWool) 
                : base(height, weight, eyeColor, name, breed, color, birthYear)
        {
            this.hasWool = hasWool;
        }

        public bool IsHasWool(){
            return hasWool;
        }

        public override void Affect()
        {
            Console.WriteLine("Murmur");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return "Cat: " + base.ToString() +
                ", hasWool=" + IsHasWool();
        }
    }
}