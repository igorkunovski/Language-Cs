using HW8_OOP.animal;
using HW8_OOP.bird;
using HW8_OOP.pet;
using HW8_OOP.wild;
using HW8_OOP.zoo;

namespace HW8_OOP.config
{
    public class SupportMetods
    {
        public int ChooseNumber()
        {
            try{
                Console.Write("Insert number:  ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException) {
            Console.WriteLine("Must be int number");
            
        }
        return ChooseNumber();
    }

    public void Process(int userChoice, Zoo zoo) {
        switch (userChoice) 
        {
            case 1:
                Animal newAnimal = AnimalCreation();

                if (newAnimal != null) {
                    zoo.PutIntoZoo(newAnimal);
                    zoo.ShowAnimals();
                }
               
                break;
            case 2:
                zoo.RemoveFromZooByIndex(ChooseNumber());
                break;
            case 3:
                zoo.ShowAnimalByNumber(ChooseNumber());
                break;
            case 4:
                zoo.ShowAnimals();
                break;
            case 5:
                zoo.MakeSoundByIndex(ChooseNumber());
                break;
            case 6:
                zoo.MakeAllAnimalsSound();
                break;
            default:
                Console.WriteLine("Incorrect number");
                break;
        }
    }


        private Animal? AnimalCreation()
        {
            int height, flyHeight, birthYear, foundYear;
            float weight;
            String eyeColor, name, breed, color, place;
            bool hasWool, trained, leader;

            Console.WriteLine("1. Chicken, 2. Stork, 3. Cat, 4. Dog, 5. Tiger, 6. Wolf");
            Console.WriteLine("Please choose number of Animal to insert and press Enter");
            
            int userChoice = ChooseNumber();
        
        switch (userChoice) 
        {
                case 1 : 
                {
                    Console.Write("Insert height:  ");
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insert weight:  ");
                    weight = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Insert eye color:  ");
                    eyeColor = Console.ReadLine();

                    return new Chicken(height, weight, eyeColor);
                }
                case 2 : 
                {
                    Console.Write("Insert height:  ");
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insert weight:  ");
                    weight = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Insert eye color:  ");
                    eyeColor = Console.ReadLine();
                    Console.Write("Insert fly height:  ");
                    flyHeight = Convert.ToInt32(Console.ReadLine());

                    return new Stork(height, weight, eyeColor, flyHeight);
                }
                case 3 : 
                {
                    Console.Write("Insert height:  ");
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insert weight:  ");
                    weight = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Insert eye color:  ");
                    eyeColor = Console.ReadLine();

                    Console.Write("Insert name:  ");
                    name = Console.ReadLine();
                    Console.Write("Insert breed:  ");
                    breed = Console.ReadLine();
                    Console.Write("Insert color:  ");
                    color = Console.ReadLine();
                    Console.Write("Insert birth year:  ");
                    birthYear = (int)Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Has wool? True or False:  ");
                    hasWool = Convert.ToBoolean(Console.ReadLine());

                    return new Cat(height, weight, eyeColor, name, breed, color, birthYear, hasWool);
                }
                case 4 : 
                {
                    Console.Write("Insert height:  ");
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insert weight:  ");
                    weight = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Insert eye color:  ");
                    eyeColor = Console.ReadLine();

                    Console.Write("Insert name:  ");
                    name = Console.ReadLine();
                    Console.Write("Insert breed:  ");
                    breed = Console.ReadLine();
                    Console.Write("Insert color:  ");
                    color = Console.ReadLine();
                    Console.Write("Insert birth year:  ");
                    birthYear = (int)Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Has wool? True or False:  ");
                    hasWool = Convert.ToBoolean(Console.ReadLine());

                    Console.Write("Trained? True or False:  ");
                    trained = Convert.ToBoolean(Console.ReadLine());

                    return new Dog(height, weight, eyeColor, name, breed, color, birthYear, trained);
                }
                case 5 : 
                {
                    Console.Write("Insert height:  ");
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insert weight:  ");
                    weight = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Insert eye color:  ");
                    eyeColor = Console.ReadLine();

                    Console.Write("Insert place:  ");
                    place = Console.ReadLine();
                    Console.Write("Insert found year:  ");
                    foundYear = (int)Convert.ToUInt32(Console.ReadLine());
                    return new Tiger(height, weight, eyeColor, place, foundYear);
                }
                case 6 : 
                {
                    Console.Write("Insert height:  ");
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insert weight:  ");
                    weight = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Insert eye color:  ");
                    eyeColor = Console.ReadLine();

                    Console.Write("Insert place:  ");
                    place = Console.ReadLine();
                    Console.Write("Insert found year");
                    foundYear = (int)Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Is it leader? True or False:  ");
                    leader = Convert.ToBoolean(Console.ReadLine());
                    return new Wolf(height, weight, eyeColor, place, foundYear, leader);
                }
            }
            return null;
        } 
        
    }
}

        