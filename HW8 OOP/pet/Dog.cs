namespace HW8_OOP.pet
{
    public class Dog : Pet, ITrainable
    {
        private bool trained;

        public Dog(int height, float weight, string eyeColor, string name, string breed, string color, int birthYear, bool trained)
            : base(height, weight, eyeColor, name, breed, color, birthYear)
        {
            this.trained = trained;
        }

        public bool IsTrained()
        {
            return trained;
        }

        public void SetTrained(bool trained)
        {
            this.trained = trained;
        }

        public override void Affect()
        {
            Console.WriteLine("Dog is happy and wagging the tail");
        }
        

        public override void MakeSound()
        {
            Console.WriteLine("Wofff!");
        }

        public void Train()
        {
            if (!IsTrained()){
                this.SetTrained(true);
            }
        }

        public override string ToString()
        {
            return "Dog: " + base.ToString() + ", trained=" + IsTrained();
        } 
    }
}
