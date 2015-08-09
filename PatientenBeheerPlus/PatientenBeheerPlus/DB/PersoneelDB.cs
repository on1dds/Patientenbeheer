using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace PatientenBeheerPlus
{
    class PersoneelDB
    {
        public static Personeel Get(int personeelid)
        {
            Personeel personeelslid = new Personeel();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Personeel WHERE PersoneelID= @personeelid", connection);
            selectCommand.Parameters.AddWithValue("@personeelid", personeelid);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    personeelslid.PersoneelID = (int)reader["PersoneelID"];
                    personeelslid.Voornaam = reader["Voornaam"].ToString();
                    personeelslid.Achternaam = reader["Achternaam"].ToString();
                    personeelslid.Functie = reader["Functie"].ToString();

                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }

            return personeelslid;
        }

        public static int Add(Personeel personeelslid)
        {
            SqlConnection connection = DB.GetConnection();
            string insertstring =
                "INSERT INTO Patient (Voornaam, Achternaam, Functie)" +
                "VALUES (@Voornaam, @Achternaam, @functie)";

            SqlCommand insertcmd = new SqlCommand(insertstring, connection);

            insertcmd.Parameters.AddWithValue("Voornaam", personeelslid.Voornaam);
            insertcmd.Parameters.AddWithValue("Achternaam", personeelslid.Achternaam);
            insertcmd.Parameters.AddWithValue("Functie", personeelslid.Functie);

            connection.Open();
            insertcmd.ExecuteNonQuery();
            string selectStatement = "SELECT IDENT_CURRENT('Personeel') FROM Personeel";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            int personeelid = Convert.ToInt32(selectCommand.ExecuteScalar());
            return personeelid;
        }


        public static List<Personeel> GetList()
        {
            List<Personeel> personeel = new List<Personeel>();
            personeel.Clear();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Personeel", connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Personeel p = new Personeel();
                    p.PersoneelID = (int)reader["PersoneelID"];
                    p.Voornaam = reader["Voornaam"].ToString();
                    p.Achternaam = reader["Achternaam"].ToString();
                    p.Functie = reader["Functie"].ToString();
                    personeel.Add(p);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
            return personeel;
        }
    }
}
