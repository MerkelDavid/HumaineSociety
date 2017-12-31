using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HumaneSociety
{
    class DB
    {
        private SqlConnection seed;

        public DB()
        {
            seed = new SqlConnection("Data Source = DMERKEL; Initial Catalog = HumaneSocietyData; Integrated Security = True; Pooling = False");
        }
        public void AddPetToDB(Pet newPet)
        {
            seed.Open();

            SqlCommand command = seed.CreateCommand();
            SqlTransaction transaction;

            transaction = seed.BeginTransaction();

            //establishing connection to db
            command.Connection = seed;
            command.Transaction = transaction;

            //write sql statment
            command.CommandText = "INSERT INTO Pets (Name,RoomNumber,vaccinated,type,vaccinated,price) VALUES ('"+newPet.name+"',"+newPet.room+","+newPet.shot+",'"+newPet.type+"','"+newPet.shot+"','"+newPet.Price+"') ";

            //preparing the SQL statment
            command.ExecuteNonQuery();

            //Executing the statement
            transaction.Commit();

        }

        public void AddTypeToDB(string typeName, int size, string FoodType)
        {
            seed.Open();

            SqlCommand command = seed.CreateCommand();
            SqlTransaction transaction;

            transaction = seed.BeginTransaction();

            //establishing connection to db
            command.Connection = seed;
            command.Transaction = transaction;

            //write sql statment
            command.CommandText = "INSERT INTO types (TypeName,Size,FoodType) Values ('"+typeName+"',"+size+",'"+FoodType+"')";

            //preparing the SQL statment
            command.ExecuteNonQuery();

            //Executing the statement
            transaction.Commit();

        }
        public bool SetAdopter(int PetID,int AdopterID)
        {
            seed.Open();

            SqlCommand command = seed.CreateCommand();
            SqlTransaction transaction;

            transaction = seed.BeginTransaction();

            //establishing connection to db
            command.Connection = seed;
            command.Transaction = transaction;

            //write sql statment
            command.CommandText = "UPDATE Adopters SET PetID = "+PetID+" WHERE AdopterID = "+AdopterID ;

            try
            {
                //preparing the SQL statment
                command.ExecuteNonQuery();

                //Executing the statement
                transaction.Commit();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }


        public bool SetRoom(int PetID, int roomNumber)
        {
            seed.Open();

            SqlCommand command = seed.CreateCommand();
            SqlTransaction transaction;

            transaction = seed.BeginTransaction();

            //establishing connection to db
            command.Connection = seed;
            command.Transaction = transaction;

            //write sql statment
            command.CommandText = "UPDATE Pets SET RoomNumber = " + roomNumber + " WHERE PetID = " + PetID;

            try
            {
                //preparing the SQL statment
                command.ExecuteNonQuery();

                //Executing the statement
                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetShots(int PetID)
        {
            seed.Open();

            SqlCommand command = seed.CreateCommand();
            SqlTransaction transaction;

            transaction = seed.BeginTransaction();

            //establishing connection to db
            command.Connection = seed;
            command.Transaction = transaction;

            //write sql statment
            command.CommandText = "UPDATE Pets SET vaccinated = 1 WHERE PetID = " + PetID;

            try
            {
                //preparing the SQL statment
                command.ExecuteNonQuery();

                //Executing the statement
                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetPrice(int PetID,double newPrice)
        {
            seed.Open();

            SqlCommand command = seed.CreateCommand();
            SqlTransaction transaction;

            transaction = seed.BeginTransaction();

            //establishing connection to db
            command.Connection = seed;
            command.Transaction = transaction;

            //write sql statment
            command.CommandText = "UPDATE Pets SET Price = "+newPrice+" WHERE PetID = " + PetID;

            try
            {
                //preparing the SQL statment
                command.ExecuteNonQuery();

                //Executing the statement
                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetName(int PetID,string newName)
        {
            seed.Open();

            SqlCommand command = seed.CreateCommand();
            SqlTransaction transaction;

            transaction = seed.BeginTransaction();

            //establishing connection to db
            command.Connection = seed;
            command.Transaction = transaction;

            //write sql statment
            command.CommandText = "UPDATE Pets SET Name = "+newName+" WHERE PetID = " + PetID;

            try
            {
                //preparing the SQL statment
                command.ExecuteNonQuery();

                //Executing the statement
                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public List<Pet> GetAvailablePets()
        {
            List<Pet> ListOfPets = new List<HumaneSociety.Pet>();
            seed.Open();

            SqlCommand command = new SqlCommand("SELECT * From Pets WHERE AdopterID = null", seed);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListOfPets.Add(new HumaneSociety.Pet(Convert.ToInt32(reader.GetSqlInt32(0)),
                    reader.GetString(1),
                    Convert.ToInt32(reader.GetSqlInt32(2)),
                    Convert.ToInt32(reader.GetSqlInt32(3)),
                    Convert.ToInt32(reader.GetSqlInt32(4)),
                    Convert.ToBoolean(reader.GetSqlBoolean(5)),
                    Convert.ToDouble(reader.GetSqlDouble(6))
                    ));
            }

            return ListOfPets;

        }

        public bool DoesTypeExist(string type)
        {
            seed.Open();
            int tester =0;

            SqlCommand command = new SqlCommand("SELECT * From types WHERE TypeName = '"+type+"'", seed);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tester = Convert.ToInt32(reader.GetSqlInt32(0));
            }

            if (tester != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
