using HW8_OOP.animal;
using HW8_OOP.bird;
using HW8_OOP.pet;
using HW8_OOP.user;
using HW8_OOP.wild;
using HW8_OOP.zoo;

public class Program {
    static void Main(string[] args)
    {

        Animal wolf = new Wolf(50, 40, "grey", "Russia", 2015, true);
        Animal dog = new Dog(50, 40, "grey", "Jack", "beagle", "brown", 2018, false);
        Animal stork = new Stork(100,5,"black",1000);

        Zoo zoo = new Zoo();
        zoo.PutIntoZoo(wolf);
        zoo.PutIntoZoo(dog);
        zoo.PutIntoZoo(stork);

        zoo.ShowAnimals();
        
        User user = new User();
        user.ChooseZoo(zoo);
        user.Run();
    }
}
