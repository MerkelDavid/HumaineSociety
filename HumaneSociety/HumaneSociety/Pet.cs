using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{

    class Pet
    {
        DB DBConnect = new DB();
        public bool adopted;
        public bool Adopted
        {
            get { return Adopted; }
            //set { DBConnect.SetAdoption(id); }
        }
        public int room;
        public int Room
        {
            get { return room; }
            //set { DBConnect.SetRoom(id); }
        }
        public bool shot;
        public bool Shot
        {
            get { return shot; }
            //set { DBConnect.SetShots(id); }
        }
        public double price;
        public double Price
        {
            get { return price; }
            //set { DBConnect.SetPrice(id); }
        }
        public string name;
        public string Name
        {
            get { return name; }
            //set { DBConnect.SetName(id); }
        }
        public int id;
        public int ID {
            get
            {
                return id;
            }
         }
        public string food;
        public string Food
        {
            get
            {
                return food;
            }
            //set { DBConnect.SetFood(id); }
        }

        public Pet(int Id, string Name,int room, int adopter, int type, bool vaccinated,double price)
        {
            this.adopted = adopted;
            this.room = room;
            this.shot = shot;
            this.price = price;
            this.name = name;
            this.id = Id;
            this.food = food; 
        }


    }
}
