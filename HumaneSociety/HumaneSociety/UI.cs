using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class UI
    {      
        private string welcomeChoice;
        private string password;
        private string empPassword;
        private string employeeChoice;

        public UI()
        {
            empPassword = "PawPrint22";
        }

        public void StartHumaneSociety()
        {
            Welcome();
            CustEmployeeSwitch();
        }
        public string Welcome()
        {
            Console.WriteLine("Welcome to Pawlicious Pet Palace, the Humane Society that can meet all of your needs!");
            Console.WriteLine("Are you a customer or an employee?");
            return welcomeChoice = Console.ReadLine();
        }

        public void CustEmployeeSwitch()
        {
            try
            {
                if (welcomeChoice == "adopter")
                {
                    //AdopterPath();
                }
                else if (welcomeChoice == "employee")
                {
                    EmployeePath();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("That was not an option, try again. Check caps lock as all user input is case sensitive.");
                // Collection of beginning functions ex. Welcome(); CustEmployeeSwitch(); ect...               
            }
        }

        public void EmployeePath()
        {
            GetPassword();
            CheckPassword();
            EmployeeMenu();
        }

        public string GetPassword()
        {
            Console.WriteLine("Please enter the employee password now. Password is case sensitive.");
            return password = Console.ReadLine();
        }

        public void CheckPassword()
        {
            try
            {
                if (password == empPassword)
                {
                    //EmployeePath();
                }

            }
            catch (Exception)
            {
            Console.WriteLine("The password you entered is incorrect, please try again and remember case sensitivity.");
            EmployeePath();                
            }
                
        }

        public string EmployeeMenu()
        {
            Console.WriteLine("Employee options, please enter the cooresponding number");
            Console.WriteLine("1. Check if animal has its shots.");
            Console.WriteLine("2. Check the type and amount of food needed for pet.");
            Console.WriteLine("3. Set status of animal to 'adopted'");           
            Console.WriteLine("4. Take payment for adoption of pet.");
            return employeeChoice = Console.ReadLine();
        }

        

        public
        
        
    }
}
