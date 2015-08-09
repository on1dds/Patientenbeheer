using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PatientenBeheerPlus
{

    public static class PostcodeDB
    {
        // fields
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

        public static List<Postcode> GetList()
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

        // bijkomende functies

        public static string GetGemeente(int pc)
        {
            if (all_postcodes.Count == 0) all_postcodes = GetList();
            foreach (Postcode p in all_postcodes)
                if (p.PostcodeID == pc)
                    return p.Gemeente;
            return null;
        }
        public static string GetProvincie(int pc)
        {
            if (all_postcodes.Count == 0) all_postcodes = GetList(); 
            foreach (Postcode p in all_postcodes)
                if (p.PostcodeID == pc)
                    return p.Provincie;
            return null;
        }        

        public static int GetPostcodeID(string Postcode, string Gemeente)
        {
            if (all_postcodes.Count == 0) all_postcodes = GetList();
            foreach (Postcode pc in all_postcodes)
                if (pc.Code == Postcode || pc.Gemeente == Gemeente)
                    return pc.PostcodeID;
            return -1;
        }
    }
}
