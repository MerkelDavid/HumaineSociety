using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HumaneSociety
{
    class Adopter
    {
        public double wallet;
        string name;
        int age;
        bool hasDogs;
        bool hasCats;
        bool hasOtherAnimals;
        bool hasKids;
        bool firstTimeOwner;
        public Adopter adopter;
        List<Animal> searchedAnimals;

        public object First_Time_Owner
        { get; private set; }
        public object Wallet { get; private set; }
        public bool Has_Cats { get; private set; }
        public bool Has_Kids { get; private set; }
        public bool Have_Dogs { get; private set; }
        public string Name { get; private set; }

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
            if (hasKids == true)
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
            if (hasOtherAnimals == true)
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
            if (firstTimeOwner == true)
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


        public Animal Search(List<Animal> possiblePets)
        {
            Console.WriteLine("What would you like to search by? Type or Size");
            string userSearchInput = Console.ReadLine().ToLower();
            userSearchInput = CheckSearch(userSearchInput);
            searchedAnimals = SearchToTakePlace(possiblePets, userSearchInput);
            DisplaySearchedAnimals(searchedAnimals);
            Animal pet;
            pet = ChooseToSearchAgain(searchedAnimals);
            return pet;

        }

        private Animal ChooseToSearchAgain(List<Animal> searchedAnimals)
        {
            Console.WriteLine("Have you found what you are looking for? Type Yes or No");
            string yesOrNo = Console.ReadLine().ToLower();
            yesOrNo = CheckYesOrNo(yesOrNo);
            if (yesOrNo == "yes")
            {
                Animal pet;
                pet = ChooseAnimal(possiblePets);
                return pet;
            }
        }

        private Animal ChooseAnimal(object possiblePets)
        {
            throw new NotImplementedException();
        }

        private List<Animal> SearchToTakePlace(List<Animal> possiblePets, string userSearchInput)
        {
            List<Animal> searchedAnimals = new List<Animal>();
            switch (userSearchInput)
            {
                case "Size":
                    searchedAnimals = searchBySize(possiblePets);
                    return searchedAnimals;
                case "Type":
                    searchedAnimals = searchByType(possiblePets);
                    return searchedAnimals;
                default:
                    break;
            }


        }

        public void CreateAdopterProfile()
        {
            adopter = new Adopter();
            adopter.Name = this.name;
            adopter.age = this.age;
            adopter.Have_Dogs = this.hasDogs;
            adopter.Has_Cats = this.hasCats;
            adopter.Has_Kids = this.hasKids;
            adopter.First_Time_Owner = this.firstTimeOwner;
            adopter.Wallet = this.Wallet;
        }

       


        private void DisplaySearchedAnimals(List<Animal> searchedAnimals)
        {
            int Count = 1;
            Console.WriteLine("Here are the options that best suit you for a pet");
            foreach (var Animal in possiblePets)
            {
                Console.WriteLine("{0}. {1} of {2} animal", Count, Count.Animal1);
                Count++;
            }
        }

        private string CheckSearch(string userSearchInput)
        {
            if (possibleAnimals.Count <= 1)
            {
                Console.WriteLine("No animals fit your criteria. Come back another timem");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return possibleAnimals.Count;
        }

        internal class possibleAnimals
        {
        }


        private List<Animal> searchByType(List<Animal> possiblePets)
        {
            List<Animal> searchedAnimals = new List<Animal>();
            string typeOptionChosen;
            Console.WriteLine("What animal would you like to look for today? You have the choice of a dog, cat, ");
            typeOptionChosen = Console.ReadLine().ToLower();
            typeOptionChosen = CheckTypeChoice(typeOptionChosen);
            foreach (var pet in possiblePets)
            {
                if (pet.Animal1 == typeOptionChosen)
                {
                    searchedAnmals.Add(pet);
                }
            }
            CheckCount(searchedAnimals);
            return searchedAnimals;

        }

        private void CheckCount(List<Animal> searchedAnimals)
        {
            throw new NotImplementedException();
        }

        private List<Animal> searchBySize(List<Animal> Animal)
        {
            List<Animal> searchedAnimals = new List<Animal>();
            string typeOptionChosen;
            Console.WriteLine("Khat size would you like your animal to be> We have small, and large");
            typeOptionChosen = Console.ReadLine().ToLower();
            typeOptionChosen = CheckSizeChoice(typeOptionChosen);
            foreach (var pet in Animal)
            {
                if ( pet.searchBySize == typeOptionChosen)
                {
                    searchedAnimals.Add(pet);
                }
            }
            CheckCount(searchedAnimals);
            return searchedAnimals;
        }

        private string CheckSizeChoice(string typeOptionChosen)
        {
            throw new NotImplementedException();
        }

        private string CheckTypeChoice(string typeOptionChosen)
        {
            while (true)
            {
                if (typeOptionChosen == "dog" || typeOptionChosen == "cat")
                {
                    return typeOptionChosen;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please try again. You have the option for either a cat or a dog.");
                    typeOptionChosen = Console.ReadLine().ToLower();
                }
            }
        }
    }
}

    