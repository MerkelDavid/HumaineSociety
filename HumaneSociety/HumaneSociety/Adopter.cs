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
        //List<Animal> searchedAnimals;

        public object First_Time_Owner { get; private set; }
        public object Wallet { get; private set; }
        public bool Have_Cats { get; private set; }
        public bool Have_Kids { get; private set; }
        public bool Have_Dogs { get; private set; }
        public string Name { get; private set; }

        public Adopter()
        {
            wallet = 400.00;
            //searchedAnimals = new List<Animal>();

        }
    //    public void AskForName()
    //    {
    //        Console.WriteLine("What is your name?");
    //        name = Console.ReadLine();
    //    }

    //    public void AskForAge()
    //    {
    //        int x;
    //        Console.WriteLine("What is your age?");
    //        string inputAge = Console.ReadLine();
    //        while (true)
    //        {
    //            if (Int32.TryParse(inputAge, out x))
    //            {
    //                age = x;
    //                break;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Write your name in integer format.");
    //                inputAge = Console.ReadLine();
    //            }
    //        }
    //    }
    //    public void GetDogInformation()
    //    {
    //        Console.WriteLine("Do you have dogs in your household?");
    //        string yesOrNo = Console.ReadLine();
    //        yesOrNo = CheckYesOrNo(yesOrNo);
    //        if (yesOrNo == "yes")
    //        {
    //            hasDogs = true;
    //        }
    //        else
    //        {
    //            hasDogs = false;
    //        }
    //    }
    //    public void GetCatInformation()
    //    {
    //        Console.WriteLine("Do you have any cats in your household?");
    //        string yesOrNo = Console.ReadLine();
    //        yesOrNo = CheckYesOrNo(yesOrNo);
    //        if (yesOrNo == "yes")
    //        {
    //            hasCats = true;
    //        }
    //        else
    //        {
    //            hasCats = false;
    //        }
    //    }
    //    public void GetChildrenInformation()
    //    {
    //        Console.WriteLine("Do you have children in your household?");
    //        string yesOrNo = Console.ReadLine();
    //        yesOrNo = CheckYesOrNo(yesOrNo);
    //        if (hasKids == "yes")
    //        {
    //            hasKids = true;
    //        }
    //        else
    //        {
    //            hasKids = false;
    //        }
    //    }

    //    public void CheckOtherAnimalInformation()
    //    {
    //        Console.WriteLine("Is there any animals you own in your household?");
    //        string yesOrNo = Console.ReadLine();
    //        yesOrNo = CheckYesOrNo(yesOrNo);
    //        if (hasOtherAnimals == "yes")
    //        {
    //            hasOtherAnimals = true;

    //        }
    //        else
    //        {
    //            hasOtherAnimals = false;
    //        }
    //    }

    //    public void CheckFirstTimeOwnerStatus()
    //    {
    //        Console.WriteLine("Is this your first time owning a pet?");
    //        string yesOrNo = Console.ReadLine();
    //        yesOrNo = CheckYesOrNo(yesOrNo);
    //        if (firstTimeOwner == "yes")
    //        {
    //            firstTimeOwner = true;
    //        }
    //        else
    //        {
    //            firstTimeOwner = false;
    //        }
    //    }
    //    private string CheckYesOrNo(string yesOrNo)
    //    {
    //        while (true)
    //        {
    //            if (yesOrNo == "yes" || yesOrNo == "no")
    //            {
    //                return yesOrNo;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Invalid input, please choose a yes or no answer");
    //                yesOrNo = Console.ReadLine();
    //            }
    //        }
    //    }

    //    public void CreateAdopterProfile()
    //    {
    //        adopter = new Adopter();
    //        adopter.Name = this.name;
    //        adopter.age = this.age;
    //        adopter.Have_Dogs = this.hasDogs;
    //        adopter.Have_Cats = this.hasCats;
    //        adopter.Have_Kids = this.hasKids;
    //        adopter.First_Time_Owner = this.FirstTimeOwner;
    //        adopter.Wallet = this.Wallet;
    //    }

    //    public Animal Search(List<Animal> possiblePets)
    //    {
    //        Console.WriteLine("What would you like to search by? Type or Size");
    //        string userSearchInput = Console.ReadLine().ToLower();
    //        userSearchInput = CheckSearch(userSearchInput);
    //        searchedAnimals = SearchToTakePlace(possiblePets, userSearchInput);
    //        DisplaySearchedAnimals(searchedAnimals);
    //        Animal pet;
    //        pet = ChooseToSearchAgain(searchedAnimals);
    //        return pet;

    //    }

    //    double wallet = 400.00;
    //    searchedAnimals = new List<Animal>();

    //    }
    //public void AskForName()
    //{
    //    Console.WriteLine("What is your name?");
    //    name = Console.ReadLine();
    //}

    //public void AskForAge()
    //{
    //    int x;
    //    Console.WriteLine("What is your age?");
    //    string inputAge = Console.ReadLine();
    //    while (true)
    //    {
    //        if (Int32.TryParse(inputAge, out x))
    //        {
    //            age = x;
    //            break;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Write your name in integer format.");
    //            inputAge = Console.ReadLine();
    //        }
    //    }
    //}
    //public void GetDogInformation()
    //{
    //    Console.WriteLine("Do you have dogs in your household?");
    //    string yesOrNo = Console.ReadLine();
    //    yesOrNo = CheckYesOrNo(yesOrNo);
    //    if (yesOrNo == "yes")
    //    {
    //        hasDogs = true;
    //    }
    //    else
    //    {
    //        hasDogs = false;
    //    }
    //}
    //public void GetCatInformation()
    //{
    //    Console.WriteLine("Do you have any cats in your household?");
    //    string yesOrNo = Console.ReadLine();
    //    yesOrNo = CheckYesOrNo(yesOrNo);
    //    if (yesOrNo == "yes")
    //    {
    //        hasCats = true;
    //    }
    //    else
    //    {
    //        hasCats = false;
    //    }
    //}
    //public void GetChildrenInformation()
    //{
    //    Console.WriteLine("Do you have children in your household?");
    //    string yesOrNo = Console.ReadLine();
    //    yesOrNo = CheckYesOrNo(yesOrNo);
    //    if (yesOrNo == "yes")
    //    {
    //        hasKids = true;
    //    }
    //    else
    //    {
    //        hasKids = false;
    //    }
    //}

    //public void CheckOtherAnimalInformation()
    //{
    //    Console.WriteLine("Is there any animals you own in your household?");
    //    string yesOrNo = Console.ReadLine();
    //    yesOrNo = CheckYesOrNo(yesOrNo);
    //    if (yesOrNo == "yes")
    //    {
    //        hasOtherAnimals = true;

    //    }
    //    else
    //    {
    //        hasOtherAnimals = false;
    //    }
    //}

    //public void CheckFirstTimeOwnerStatus()
    //{
    //    Console.WriteLine("Is this your first time owning a pet?");
    //    string yesOrNo = Console.ReadLine();
    //    yesOrNo = CheckYesOrNo(yesOrNo);
    //    if (yesOrNo == "yes")
    //    {
    //        firstTimeOwner = true;
    //    }
    //    else
    //    {
    //        firstTimeOwner = false;
    //    }
    //}
    //private string CheckYesOrNo(string yesOrNo)
    //{
    //    while (true)
    //    {
    //        if (yesOrNo == "yes" || yesOrNo == "no")
    //        {
    //            return yesOrNo;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input, please choose a yes or no answer");
    //            yesOrNo = Console.ReadLine();
    //        }
    //    }
    //}

    //public void CreateAdopterProfile()
    //{
    //    adopter = new Adopter();
    //    adopter.Name = this.name;
    //    adopter.age = this.age;
    //    adopter.Have_Dogs = this.hasDogs;
    //    adopter.Have_Cats = this.hasCats;
    //    adopter.Have_Kids = this.hasKids;
    //    adopter.First_Time_Owner = this.firstTimeOwner;
    //    adopter.Wallet = this.Wallet;
    //}

    //public Animal Search(List<Animal> possiblePets)
    //{
    //    Console.WriteLine("What would you like to search by? Type or Size");
    //    string userSearchInput = Console.ReadLine().ToLower();
    //    userSearchInput = CheckSearch(userSearchInput);
    //    searchedAnimals = SearchToTakePlace(possiblePets, userSearchInput);
    //    DisplaySearchedAnimals(searchedAnimals);
    //    Animal pet;
    //    pet = ChooseToSearchAgain(searchedAnimals);
    //    return pet;

    //}

    //private Animal ChooseToSearchAgain(List<Animal> searchedAnimals)
    //{
    //    throw new NotImplementedException();
    //}

    //private void DisplaySearchedAnimals(List<Animal> searchedAnimals)
    //{
    //    throw new NotImplementedException();
    //}

    //private string CheckSearch(string userSearchInput)
    //{
    //    throw new NotImplementedException();
    //}


    //private void SearchToTakePlace(List<Animal> possiblePets, string userSearchInput)
    //{
    //    List<Animal> searchedAnimals = new List<Animal>();
    //    switch (userSearchInput)
    //    {
    //        case "Size":
    //            searchedAnimals = searchBySize(possiblePets);
    //            return searchedAnimals;
    //        case "Type":
    //            searchedAnimals = searchByType(possiblePets);
    //            return searchedAnimals;
    //        default:
    //            break;
    //    }
    //}

    //private List<Animal> searchByType(List<Animal> possiblePets)
    //{
    //    List<Animal> searchedAnimals = new List<Animal>();
    //    string typeOptionChosen;
    //    Console.WriteLine("What animal would you like to look for today? You have the choice of a dog, cat, ");
    //    typeOptionChosen = Console.ReadLine().ToLower();
    //    typeOptionChosen = CheckTypeChoice(typeOptionChosen);
    //    foreach (var pet in possiblePets)
    //    {
    //        if (pet.Animal1 == typeOptionChosen)
    //        {
    //            searchedAnmals.Add(pet);
    //        }
    //    }
    //    CheckCount(searchedAnimals);
    //    return searchedAnimals;

    //}

    //private List<Animal> searchBySize(List<Animal> possiblePets)
    //{
    //    List<Animal> searchedAnimals = new List<Animal>();
    //    string typeOptionChosen;
    //    Console.WriteLine("Khat size would you like your animal to be> We have small, medium, and large");
    //    typeOptionChosen = Console.ReadLine().ToLower();
    //    typeOptionChosen = CheckSizeChoice(typeOptionChosen);
    //    foreach (var pet in possiblePets)
    //    {
    //        if (pet.Animal_Size == typeOptionChosen)
    //        {
    //            searchedAnimals.Add(pet);
    //        }
    //    }
    //    CheckCount(searchedAnimals);
    //    return searchedAnimals;
    //}
    //private string CheckTypeChoice(string typeOptionChosen)
    //{
    //    while (true)
    //    {
    //        if (typeOptionChosen == "dog" || typeOptionChosen == "cat")
    //        {
    //            return typeOptionChosen;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Wrong input. Please try again. You have the option for either a cat or a dog.");
    //            typeOptionChosen = Console.ReadLine().ToLower();
    //        }
        }
}
