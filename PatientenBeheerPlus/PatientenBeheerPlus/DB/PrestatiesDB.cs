using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace PatientenBeheerPlus
{
    class PrestatiesDB
    {
        public static Prestatie Get(int prestatienr)
        {
            Prestatie prestatie = new Prestatie();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Prestaties WHERE Prestatienr= @prestatienr", connection);
            selectCommand.Parameters.AddWithValue("@Prestatienr", prestatienr);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    prestatie.Prestatienr = (int)reader["Prestatienr"];
                    prestatie.PrestatieSoortID = (int)reader["PrestatieSoortID"];
                    prestatie.Opnamenr = (int)reader["Opnamenr"];
                    prestatie.Tijdstip = (DateTime)reader["Tijdstip"];
                    prestatie.UitvoerderID = (int)reader["UitvoerderID"];
                    prestatie.PrestatieStatusID = (int)reader["PrestatieStatusID"];
                    prestatie.Opmerking = reader["Opmerking"].ToString();
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }

            return prestatie;
        }
        public static int Add(Prestatie prestatie)
        {
            SqlConnection connection = DB.GetConnection();
            string insertstring =
                "INSERT INTO Prestaties (PrestatieSoortID, Opnamenr, Tijdstip, UitvoerderID, PrestatieStatusID, Opmerking)" +
                "VALUES (@PrestatieSoortID, @Opnamenr, @Tijdstip, @UitvoerderID, @PrestatieStatusID, @Opmerking)";

            SqlCommand insertcmd = new SqlCommand(insertstring, connection);

            insertcmd.Parameters.AddWithValue("PrestatieSoortID", prestatie.PrestatieSoortID);
            insertcmd.Parameters.AddWithValue("Opnamenr", prestatie.Opnamenr);
            insertcmd.Parameters.AddWithValue("Tijdstip", prestatie.Tijdstip);
            insertcmd.Parameters.AddWithValue("UitvoerderID", prestatie.UitvoerderID);
            insertcmd.Parameters.AddWithValue("PrestatieStatusID", prestatie.PrestatieStatusID);
            insertcmd.Parameters.AddWithValue("Opmerking", prestatie.Opmerking);


            connection.Open();
            insertcmd.ExecuteNonQuery();
            string selectStatement = "SELECT IDENT_CURRENT('Prestaties') FROM Prestaties";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            int prestatienr = Convert.ToInt32(selectCommand.ExecuteScalar());
            return prestatienr;
        }

        public static bool Update(Prestatie prestatie)
        {
            SqlConnection connection = DB.GetConnection();
            string updateStatement =
                "UPDATE Prestaties SET " +
                    "PrestatieSoortID = @PrestatieSoortID, " +
                    "Opnamenr = @Opnamenr, " +
                    "Tijdstip = @Tijdstip, " +
                    "UitvoerderID = @UitvoerderID, " +
                    "PrestatieStatusID = @PrestatieStatusID," +
                    "Opmerking = @Opmerking " + 
                "WHERE " +
                    "Prestatienr = @Prestatienr";

            SqlCommand insertCommand = new SqlCommand(updateStatement, connection);

            insertCommand.Parameters.AddWithValue("Prestatienr", prestatie.Prestatienr);
            insertCommand.Parameters.AddWithValue("PrestatieSoortID", prestatie.PrestatieSoortID);
            insertCommand.Parameters.AddWithValue("Opnamenr", prestatie.Opnamenr);
            insertCommand.Parameters.AddWithValue("Tijdstip", prestatie.Tijdstip);
            insertCommand.Parameters.AddWithValue("UitvoerderID", prestatie.UitvoerderID);
            insertCommand.Parameters.AddWithValue("PrestatieStatusID", prestatie.PrestatieStatusID);
            insertCommand.Parameters.AddWithValue("Opmerking", prestatie.Opmerking);

            try
            {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Delete(int prestatienr)
        {
            SqlConnection connection = DB.GetConnection();
            string deleteStatement = "DELETE FROM Prestaties WHERE Prestatienr=@prestatienr";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@prestatienr", prestatienr);
            try
            {
                connection.Open();
                deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
        }

        public static void DeleteList(List<Prestatie> prestatielijst)
        {
            foreach (Prestatie p in prestatielijst)
                Delete(p.Prestatienr);
        }
        public static List<Prestatie> GetList()
        {
            List<Prestatie> prestaties = new List<Prestatie>();
            prestaties.Clear();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Prestaties", connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Prestatie prestatie = new Prestatie();

                    prestatie.Prestatienr = (int)reader["Prestatienr"];
                    prestatie.PrestatieSoortID = (int)reader["PrestatieSoortID"];
                    prestatie.Opnamenr = (int)reader["Opnamenr"];
                    prestatie.Tijdstip = (DateTime)reader["Tijdstip"];
                    prestatie.UitvoerderID = (int)reader["UitvoerderID"];
                    prestatie.PrestatieStatusID = (int)reader["PrestatieStatusID"];
                    prestatie.Opmerking = reader["Opmerking"].ToString();
                    prestaties.Add(prestatie);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
            return prestaties;
        }
    }
}
