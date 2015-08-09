using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PatientenBeheerPlus
{
    class AfdelingDB
    {
        // fields
        static List<Afdeling> all_afdeling = new List<Afdeling>();

        public static string ToString(int afdeling)
        {
            foreach (Afdeling a in all_afdeling)
                if (a.AfdelingID == afdeling)
                    return a.Afdelingnaam;
            return null;
        }


        public static Afdeling Get(int afdelingid)
        {
            Afdeling afd = new Afdeling();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Afdeling WHERE AfdelingID= @afdelingid", connection);
            selectCommand.Parameters.AddWithValue("@afdelingid", afdelingid);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    afd.AfdelingID = (int)reader["AfdelingID"];
                    afd.Afdelingnaam = reader["Afdelingnaam"].ToString();
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }

            return afd;
        }

        public static List<Afdeling> GetList()
        {
            List<Afdeling> afdlijst = new List<Afdeling>();
            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Afdeling", connection);

            afdlijst.Clear();

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Afdeling afd = new Afdeling();
                    afd.AfdelingID = (int)reader["AfdelingID"];
                    afd.Afdelingnaam = reader["Afdelingnaam"].ToString();
                    afdlijst.Add(afd);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }

            return afdlijst;
        }

        // bijkomende functies
    }
}
