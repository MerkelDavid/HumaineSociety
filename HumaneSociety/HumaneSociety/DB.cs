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
            seed = new SqlConnection("Data Source = DMERKEL; Initial Catalog = HumaneSociety; Integrated Security = True; Pooling = False");
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
            command.CommandText = "INSERT INTO Pets (Name,RoomNumber,vaccinated,type) VALUES ('"+Pet.name+"',"+Pet.roomNumber+","+Pet.vaccinated+",'"+Pet.type+"') ";

            //preparing the SQL statment
            command.ExecuteNonQuery();

            //Executing the statement
            transaction.Commit();

        }

        public List<Pet> GetAvailablePets()
        {
            List<Pet> ListOfPets = new List<HumaneSociety.Pet>();
            seed.Open();

            SqlCommand command = new SqlCommand("SELECT * From Pets", seed);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListOfPets.Add(new HumaneSociety.Pet(reader.GetSqlInt16(0), reader.GetString(1), reader.GetSqlInt32(2), reader.GetSqlInt32(3), reader.GetSqlInt32(4), reader.GetSqlBoolean(5), reader.GetSqlDouble(6));
            }
            Console.WriteLine("");

        }

    }
}
