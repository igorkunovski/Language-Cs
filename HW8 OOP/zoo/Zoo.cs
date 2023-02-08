using HW8_OOP.animal;

namespace HW8_OOP.zoo
{
    public class Zoo
    {
        private List<Animal> animalsList = new List<Animal>();
    

    public void ShowAnimals()
    {
        
        if (animalsList.Count > 0)
        {
            Console.WriteLine("We have in Zoo at the moment:");
            int counter = 1;
            foreach (Animal animal in animalsList)
            {
                Console.WriteLine("Animal Nr." + counter + " - " + animal);
                counter++;
            }
        }
        else
        {
            Console.WriteLine("Zoo iz empty");
        }       
    }

    public void PutIntoZoo(Animal animal)
    {
        if(!animalsList.Contains(animal))
        {
            animalsList.Add(animal);
            Console.WriteLine(animal + "<--- added to zoo");
        }
        else
        {
            Console.WriteLine(animal + "This animal is already in Zoo");
        }
    }

    public void MakeAllAnimalsSound()
    {
        if (animalsList.Count > 0)
        {
            foreach (Animal animal in animalsList)
            {
                animal.MakeSound();
            }
        }
        else
        {
            Console.WriteLine("Zoo iz empty");
        }       
    }

    public void RemoveFromZooByIndex(int index)
    {
        if (animalsList.Count >= index && index > 0)
        {
            Console.WriteLine("" + animalsList.ElementAt(index - 1) + " is removed from Zoo");
            animalsList.RemoveAt(index-1);
        }
        else
        {
            Console.WriteLine("Incorrect index");
        }
    }

    public void MakeSoundByIndex(int index)
    {
        if(animalsList.Count >= index && index > 0)
        {
            animalsList.ElementAt(index - 1).MakeSound();
        }
        else
        {
            Console.WriteLine("Incorrect index");
        }
    }

    public void ShowAnimalByNumber(int index)
    {
        if(animalsList.Count >= index && index > 0)
        {
            Console.WriteLine("Animal Nr." + index + " " +  animalsList.ElementAt(index - 1));
        }
        else
        {
            Console.WriteLine("We have less animals than this number in the Zoo");
        }
    }
}
}
