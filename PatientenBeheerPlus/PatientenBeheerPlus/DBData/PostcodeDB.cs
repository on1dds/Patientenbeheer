using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Patientenbeheer
{

    public static class PostcodeDB
    {
        // fields

        public static string[] PostcodeTabel = { "PostcodeID", "Postcode", "Gemeente", "Provincie" };

        static List<Postcode> all_postcodes = new List<Postcode>();

        // methods

        public static void Initialize()
        {
            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Postcode", connection);

            all_postcodes.Clear();

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Postcode pc = new Postcode();
                    pc.PostcodeID = (int)reader["PostcodeID"];
                    pc.Code = reader["Postcode"].ToString();
                    pc.Gemeente = reader["Gemeente"].ToString();
                    pc.Provincie = reader["Provincie"].ToString();
                    all_postcodes.Add(pc);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
        }

        public static List<Postcode> GetPostcodeLijst()
        {
            List<Postcode> pclijst = new List<Postcode>();
            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Postcode", connection);

            pclijst.Clear();

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Postcode pc = new Postcode();
                    pc.PostcodeID = (int)reader["PostcodeID"];
                    pc.Code = reader["Postcode"].ToString();
                    pc.Gemeente = reader["Gemeente"].ToString();
                    pc.Provincie = reader["Provincie"].ToString();
                    pclijst.Add(pc);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }

            return pclijst;
        }


        public static string ToString(int pc)
        {
            foreach (Postcode p in all_postcodes)
                if (p.PostcodeID == pc) 
                    return p.Code + " " + p.Gemeente;
            return null;           
        }

        public static Postcode Get(int postcodeid)
        {
            Postcode postcode = new Postcode();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Postcode WHERE PostcodeID= @postcodeid", connection);
            selectCommand.Parameters.AddWithValue("@postcodeid", postcodeid);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    postcode.PostcodeID = (int)reader["PostcodeID"];
                    postcode.Code = reader["Postcode"].ToString();
                    postcode.Gemeente = reader["Gemeente"].ToString();
                    postcode.Provincie = reader["Provincie"].ToString();
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }

            return postcode;
        }
        public static int AddPatient(Patient patient)
        {
            SqlConnection connection = DB.GetConnection();
            string insertstring =
                "INSERT Patient (Voornaam, Achternaam, Straat, Huisnummer, PostcodeID, Telefoonnummer, Geboortedatum)" +
                "VALUES (@Voornaam, @Achternaam, @Straat, @Huisnummer, @PostcodeID, @Telefoonnummer, @Geboortedatum)";

            SqlCommand insertcmd = new SqlCommand(insertstring, connection);

            insertcmd.Parameters.AddWithValue("Voornaam", patient.Voornaam);
            insertcmd.Parameters.AddWithValue("Achternaam", patient.Achternaam);
            insertcmd.Parameters.AddWithValue("Straat", patient.Straat);
            insertcmd.Parameters.AddWithValue("Huisnummer", patient.Huisnummer);
            insertcmd.Parameters.AddWithValue("PostcodeID", patient.PostcodeID);
            insertcmd.Parameters.AddWithValue("Telefoonnummer", patient.Telefoonnummer);
            insertcmd.Parameters.AddWithValue("Geboortedatum", patient.Geboortedatum);

            connection.Open();
            insertcmd.ExecuteNonQuery();
            string selectStatement = "SELECT IDENT_CURRENT('Patient') FROM Patient";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            int patientnr = Convert.ToInt32(selectCommand.ExecuteScalar());
            return patientnr;
        }
        public static bool UpdatePatient(Patient oldpatient, Patient newpatient)
        {
            SqlConnection connection = DB.GetConnection();
            string updatestring =
                "UPDATE Patient SET " +
                    "Voornaam = @Voornaam, " +
                    "Achternaam = @Achternaam, " +
                    "Straat = @Straat, " +
                    "Huisnummer = @Huisnummer, " +
                    "PostcodeID = @PostcodeID, " +
                    "Telefoonnummer = @Telefoonnummer, " +
                    "Geboortedatum = @Geboortedatum " +
                "WHERE Patientnr = @OldPatientnr";

            SqlCommand updateCommand = new SqlCommand(updatestring, connection);

            updateCommand.Parameters.AddWithValue("@Voornaam", newpatient.Voornaam);
            updateCommand.Parameters.AddWithValue("@Achternaam", newpatient.Achternaam);
            updateCommand.Parameters.AddWithValue("@NStraat", newpatient.Straat);
            updateCommand.Parameters.AddWithValue("@NHuisnummer", newpatient.Huisnummer);
            updateCommand.Parameters.AddWithValue("@NPostcodeID", newpatient.PostcodeID);
            updateCommand.Parameters.AddWithValue("@Telefoonnummer", newpatient.Telefoonnummer);
            updateCommand.Parameters.AddWithValue("@Geboortedatum", newpatient.Geboortedatum);

            updateCommand.Parameters.AddWithValue("@OldPatientnr", oldpatient.Patientnr);

            try
            {

                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public static void DeletePostcode(int postcodeid)
        {
            SqlConnection connection = DB.GetConnection();
            string deleteStatement = "DELETE FROM Postcode WHERE PostcodeID=@postcodeid";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@postcodeid", postcodeid);
            try
            {
                deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public static string GetGemeente(int pc)
        {
            if (all_postcodes.Count == 0) all_postcodes = GetPostcodeLijst();
            foreach (Postcode p in all_postcodes)
                if (p.PostcodeID == pc)
                    return p.Gemeente;
            return null;
        }
        public static string GetProvincie(int pc)
        {
            if (all_postcodes.Count == 0) all_postcodes = GetPostcodeLijst(); 
            foreach (Postcode p in all_postcodes)
                if (p.PostcodeID == pc)
                    return p.Provincie;
            return null;
        }
        
        public static int GetPostcodeID(string Postcode, string Gemeente)
        {
            if (all_postcodes.Count == 0) all_postcodes = GetPostcodeLijst();
            foreach (Postcode pc in all_postcodes)
                if (pc.Code == Postcode || pc.Gemeente == Gemeente)
                    return pc.PostcodeID;
            return -1;
        }
    }
}
