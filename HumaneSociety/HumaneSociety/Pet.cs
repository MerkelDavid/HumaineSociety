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
        }
        public int room;
        public int Room
        {
            get { return room; }
        }
        public bool shot;
        public bool Shot
        {
            get { return shot; }
        }
        public double price;
        public double Price
        {
            get { return price; }
        }
        public string name;
        public string Name
        {
            get { return name; }
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

        }
        public string type;
        public string Type
        {
            get { return type; }
        }
        public int size;
        public string Size
        {
            get { if (size == 1) { return "small"; }
                else if (size == 2) { return "medium"; }
                else return "large"; }
        }

        public Pet(int id, string name,int room, int adopter, string type, bool vaccinated,double price)
        {
            if (adopter == 0)
            {
                this.adopted = false;
            }
            else
            {
                adopted = true;
            }
            this.room = room;
            this.shot = vaccinated;
            this.price = price;
            this.name = name;
            this.id = id;
            this.type = type;
        }

        //returns true if the adoption went through
        public bool SetAdopter(int AdopterID)
        {
           return DBConnect.SetAdopter(ID, AdopterID);
        }

        public bool SetRoom(int roomNumber)
        {
            return DBConnect.SetRoom(ID, roomNumber);
        }

        public bool SetShots()
        {
            return DBConnect.SetShots(ID);
        }

        public bool setPrice(double price)
        {
            return DBConnect.SetPrice(ID, price);
        }
    }
}
