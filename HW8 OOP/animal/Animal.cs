namespace HW8_OOP.animal
{
    public abstract class Animal
    {
        private int height;
        private float weight;
        private String eyeColor;


        public abstract void MakeSound();

        public Animal(int height, float weight, String eyeColor)
        {
            this.height = height;
            this.weight = weight;
            this.eyeColor = eyeColor;
        }

        public int GetHeight()
        {
            return height;
        }

        public float GetWeight()
        {
            return weight;
        }

        public String GetEyeColor()
        {
            return eyeColor;
        }


    public override string ToString(){
         return "height=" + this.GetHeight() + " sm" +
                ", weight=" + this.GetWeight() + " kg" +
                ", eyeColor=" + this.GetEyeColor();
    }

    }
}