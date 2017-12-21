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

        //public bool CheckShots(animal)
        //{
        //    if(animalShot == true)
        //    {
        //        return true;
        //    }
        //}

        //public bool GiveShot(animal)
        //{
        //    if(animalShot == false)
        //    {
        //        return animalShot == true;
        //    }
        //}

        //public bool SetStatusToAdopted(animal)
        //{
        //    if(adopted == false)
        //    {
        //        return adopted = true;
        //    }
        //}

        //public string GetAnimalRoom(animal)
        //{
        //    Console.WriteLine(animal.room);            
        //}

        //public string GetAnimalFood(animal, animal.food)
        //{
        //    Console.WriteLine("This {0} eats {1} per week");
        //}

        public double AcceptPayment()
        {
            return storeCashBox.storeMoney = pet.price + storeCashBox.storeMoney;
        }

        public double TakePaymentFromCust()
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
                return false;
            }
            return false;
        }

        

        // collect money
    }
}
