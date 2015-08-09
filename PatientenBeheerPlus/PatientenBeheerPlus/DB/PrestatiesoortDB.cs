using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PatientenBeheerPlus
{
    public static class PrestatiesoortDB
    {
        public static Prestatiesoort Get(int prestatiesoortid)
        {
            Prestatiesoort soort = new Prestatiesoort();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Prestatiesoort WHERE PrestatieSoortID= @prestatiesoortid", connection);
            selectCommand.Parameters.AddWithValue("@PrestatieSoortID", prestatiesoortid);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    soort.PrestatieSoortID = (int)reader["PrestatieSoortID"];
                    soort.Naam = reader["Naam"].ToString();
                    soort.Omschrijving = reader["Omschrijving"].ToString();
                    soort.Kostprijs = (double)reader["Kostprijs"];
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }

            return soort;
        }

        public static List<Prestatiesoort> GetList()
        {
            List<Prestatiesoort> soorten = new List<Prestatiesoort>();
            soorten.Clear();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Prestatiesoort", connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Prestatiesoort soort = new Prestatiesoort();
                    soort.PrestatieSoortID = (int)reader["PrestatieSoortID"];
                    soort.Naam = reader["Naam"].ToString();
                    soort.Omschrijving = reader["Omschrijving"].ToString();
                    soort.Kostprijs = (double)reader["Kostprijs"];
                    soorten.Add(soort);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
            return soorten;
        }

    }
}
