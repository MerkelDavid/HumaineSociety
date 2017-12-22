using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Employee
    {
        
        StoreCashBox storeCashBox;
        Pet pet;
        Adopter adopter;

        public bool CheckShots(Pet animal)
        {
            if (animal.shot == true)
            {
                return true;
            }
            return false;
        }

        public bool GiveShot(bool shot)
        {
            if (shot == false)
            {
                return shot == true;
            }
            return false;
        }

        public bool SetStatusToAdopted(bool adopted)
        {
            if (adopted == false)
            {
                return adopted = true;
            }
            return false;
        }

        public void GetAnimalRoom(string room)
        {
            Console.WriteLine(room);
        }

        public void GetAnimalFood(string food)
        {
            Console.WriteLine(food);
        }

        public double AcceptPayment()
        {
            return storeCashBox.storeMoney = pet.price + storeCashBox.storeMoney;
        }

        public double TakePaymentFromCust(double price)
        {
            return adopter.wallet = pet.price - adopter.wallet;
        }

        public bool CheckCustomerWalletForPayment()
        {
            if(adopter.wallet > pet.price)
            {
                return true;
            }
            else if(adopter.wallet < pet.price)
            {
                Console.WriteLine("You do not have enough money for this pet. Please think about the pet, its food, and any other 'home' accomadations it might need!");
                return false;
            }
            return false;
        }

        
    
        
    }
}
