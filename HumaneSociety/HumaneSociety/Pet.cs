using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Pet
    {
        public bool adopted;
        public string room;
        public bool shot;
        public double price;
        public string name;
        public int Id;
        public string food;

        public Pet(bool adopted, string room, bool shot, double price, string name, int Id, string food)
        {
            this.adopted = adopted;
            this.room = room;
            this.shot = shot;
            this.price = price;
            this.name = name;
            this.Id = Id;
            this.food = food; 
        }


    }
}
