using HW8_OOP.animal;

namespace HW8_OOP.pet
{
    public abstract class Wild : Animal
    {
        private String place;
        private int foundYear;

        protected Wild(int height, float weight, string eyeColor, String place, int foundYear) : base(height, weight, eyeColor)
        {
            this.place = place;
            this.foundYear = foundYear;
        }

        public String GetPlace()
        {
            return place;
        }

        public int GetFoundYear()
        {
            return foundYear;
        }

        public override string ToString()
        {
            return base.ToString() +
                ", place= " + GetPlace()  +
                ", foundYear=" + GetFoundYear();
        }
    }
}
