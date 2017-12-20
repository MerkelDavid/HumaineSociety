using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Adopter
    {
        private double wallet;
        private string name;
        private int age;
        private bool hasDogs;
        private bool hasCats;
        private bool hasOtherAnimals;
        private bool hasKids;
        private bool firstTimeOwner;
        private Adopter adopter;
        private List<Animal> searchedAnimals;

        public Adopter()
        {
            wallet = 400.00;
            searchedAnimals = new List<Animal>();

        }
        public void AskForName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        public void AskForAge()
        {
            int x;
            Console.WriteLine("What is your age?");
            string inputAge = Console.ReadLine();
            while (true)
            {
                if (Int32.TryParse(inputAge, out x))
                {
                    age = x;
                    break;
                }
                else
                {
                    Console.WriteLine("Write your name in integer format.");
                    inputAge = Console.ReadLine();
                }
            }
        }
        public void GetDogInformation()
        {
            Console.WriteLine("Do you have dogs in your household?");
            string yesOrNo = Console.ReadLine();
            yesOrNo = CheckYesOrNo(yesOrNo);
            if (yesOrNo == "yes")
            {
                hasDogs = true;
            }
            else
            {
                hasDogs = false;
            }
        }
        public void GetCatInformation()
        {
            Console.WriteLine("Do you have any cats in your household?");
            string yesOrNo = Console.ReadLine();
            yesOrNo = CheckYesOrNo(yesOrNo);
            if (yesOrNo == "yes")
            {
                hasCats = true;
            }
            else
            {
                hasCats = false;
            }
        }
        public void GetChildrenInformation()
        {
            Console.WriteLine("Do you have children in your household?");
            string yesOrNo = Console.ReadLine();
            yesOrNo = CheckYesOrNo(yesOrNo);
            if (hasKids == "yes")
            {
                hasKids = true;
            }
            else
            {
                hasKids = false;
            }
        }

        public void CheckOtherAnimalInformation()
        {
            Console.WriteLine("Is there any animals you own in your household?");
            string yesOrNo = Console.ReadLine();
            yesOrNo = CheckYesOrNo(yesOrNo);
            if (hasOtherAnimals == "yes")
            {
                hasOtherAnimals = true;

            }
            else
            {
                hasOtherAnimals = false;
            }
        }

        public void CheckFirstTimeOwnerStatus()
        {
            Console.WriteLine("Is this your first time owning a pet?");
            string yesOrNo = Console.ReadLine();
            yesOrNo = CheckYesOrNo(yesOrNo);
            if (firstTimeOwner == "yes")
            {
                firstTimeOwner = true;
            }
            else
            {
                firstTimeOwner = false;
            }
        }
        private string CheckYesOrNo(string yesOrNo)
        {
            while (true)
            {
                if (yesOrNo == "yes" || yesOrNo == "no")
                {
                    return yesOrNo;
                }
                else
                {
                    Console.WriteLine("Invalid input, please choose a yes or no answer");
                    yesOrNo = Console.ReadLine();
                }
            }
        }

        public void CreateAdopterProfile()
        {
            adopter = new Adopter();
            adopter.Name = this.name;
            adopter.age = this.age;
            adopter.Have_Dogs = this.hasDogs;
            adopter.Have_Cats = this.hasCats;
            adopter.Have_Kids = this.hasKids;
            adopter.First_Time_Owner = this.FirstTimeOwner;
            adopter.Wallet = this.Wallet;
        }

        public Animal Search(List<Animal> possiblePets)
        {
            Console.WriteLine("What would you like to search by? Type or Size");
            string userSearchInput = Console.ReadLine().ToLower();


        }
    }
}
