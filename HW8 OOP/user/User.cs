using HW8_OOP.zoo;
using HW8_OOP.config;
using HW8_OOP.zoo;

namespace HW8_OOP.user
{
    public class User
    {
        Zoo zoo;
        private int userChoice;

       SupportMetods sm = new SupportMetods();

        public void ChooseZoo(Zoo zoo)
        {
            this.zoo = zoo;
        }

        public void Run()
        {
            
            ConsoleView.ShowMainMenu();

            userChoice = sm.ChooseNumber();
            if (userChoice != 7) 
            {
                sm.Process(userChoice, zoo);
                Run();
            }else
            {
                ConsoleView.ExitFromProgram();
            }
             
        }

    }
}