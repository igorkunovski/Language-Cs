using System.Collections;
using HW8_OOP.animal;

namespace HW8_OOP.pet
{
    public abstract class Pet : Animal, IAffectionate
    {

        private String name;
        private String breed;
        private String color;
        private int birthYear;

        private List<String> vaccinationList;

        protected Pet(int height, float weight, string eyeColor, String name, String breed, String color, int birthYear) : base(height, weight, eyeColor)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.birthYear = birthYear;
            this.vaccinationList = new List<String>();
        }
    

        public String GetName() 
        {
            return name;
        }

    public String GetBreed()
    {
        return breed;
    }

    public String GetColor() 
    {
        return color;
    }

    public int GetBirthYear() 
    {
        return birthYear;
    }

    public String GetVaccinations() 
    {
        String vacinations = "Vaccines: ";
        if(vaccinationList.Count > 0)
        {
            foreach(String vaccine in vaccinationList)
            {
                vacinations += ", " + vaccine;
            }
        }
        return vacinations;
    }

    public void AddVaccination(String vaccine)
    {
        vaccinationList.Add(vaccine);
    }

        public abstract void Affect();

        public override string ToString()
        {
            return "name='" + GetName() + '\'' +
                ", breed='" + GetBreed() + '\'' +
                ", color='" + GetColor() + '\'' +
                ", birth=" + GetBirthYear() + ", " +
                 base.ToString() +
                ", vaccinations=" + GetVaccinations();
        }
    } 
}
