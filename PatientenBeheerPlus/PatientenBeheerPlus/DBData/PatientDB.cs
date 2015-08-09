using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Patientenbeheer
{
    static public class PatientDB
    {
        public static Patient GetPatient(int patientnr)
        {
            Patient patient = new Patient();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Patient WHERE Patientnr= @patientnr", connection);
            selectCommand.Parameters.AddWithValue("@patientnr", patientnr);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if(reader.Read())
                {
                    patient.Patientnr = (int)reader["Patientnr"];
                    patient.Voornaam = reader["Voornaam"].ToString();
                    patient.Achternaam = reader["Achternaam"].ToString();
                    patient.Straat = reader["Straat"].ToString();
                    patient.Huisnummer = reader["Huisnummer"].ToString();
                    patient.PostcodeID = (int)reader["PostcodeID"];
                    patient.Telefoonnummer = reader["Telefoonnummer"].ToString();
                    patient.Geboortedatum = (DateTime)reader["Geboortedatum"];
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }

            return patient;
        }
        public static int AddPatient(Patient patient)
        {
            SqlConnection connection = DB.GetConnection();
            string insertstring =
                "INSERT Patient (Voornaam, Achternaam, Straat, Huisnummer, PostcodeID, Telefoonnummer, Geboortedatum)" +
                "VALUES (@Voornaam, @Achternaam, @Straat, @Huisnummer, @PostcodeID, @Telefoonnummer, @Geboortedatum)";

            SqlCommand insertcmd = new SqlCommand(insertstring, connection);

            insertcmd.Parameters.AddWithValue("Voornaam",patient.Voornaam);
            insertcmd.Parameters.AddWithValue("Achternaam",patient.Achternaam);
            insertcmd.Parameters.AddWithValue("Straat",patient.Straat);
            insertcmd.Parameters.AddWithValue("Huisnummer",patient.Huisnummer);
            insertcmd.Parameters.AddWithValue("PostcodeID",patient.PostcodeID);
            insertcmd.Parameters.AddWithValue("Telefoonnummer",patient.Telefoonnummer);
            insertcmd.Parameters.AddWithValue("Geboortedatum",patient.Geboortedatum);

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
        public static void DeletePatient(int patientnr)
        {

            SqlConnection connection = DB.GetConnection();
            string deleteStatement = "DELETE FROM Patient WHERE patientnr=@patientnr";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@patientnr", patientnr);
            try
            {
                connection.Open();
                deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
        }

        public static List<Patient> GetPatientenLijst()
        {
            List<Patient> patienten = new List<Patient>();
            patienten.Clear();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Patient", connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Patient p = new Patient();
                    p.Patientnr = (int)reader["Patientnr"];
                    p.Voornaam = reader["Voornaam"].ToString();
                    p.Achternaam = reader["Achternaam"].ToString();
                    p.Straat = reader["Straat"].ToString();
                    p.Huisnummer = reader["Huisnummer"].ToString();
                    p.PostcodeID = (int)reader["PostcodeID"];
                    p.Telefoonnummer = reader["Telefoonnummer"].ToString();
                    p.Geboortedatum = (DateTime)reader["Geboortedatum"];
                    patienten.Add(p);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
            return patienten;
        }
    }
}
