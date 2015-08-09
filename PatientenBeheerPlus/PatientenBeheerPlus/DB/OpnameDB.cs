using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PatientenBeheerPlus
{
    public static class OpnameDB
    {
        public static Opname Get(int opnamenr)
        {
            Opname opname = new Opname();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Opname WHERE OpnameNr = @opnamenr", connection);
            selectCommand.Parameters.AddWithValue("@opnamenr", opnamenr);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    opname.Opnamenr = (int)reader["Opnamenr"];
                    opname.Patientnr = (int)reader["Patientnr"];
                    opname.AfdelingID = (int)reader["AfdelingID"];
                    opname.Opnamedatum = (DateTime)reader["Opnamedatum"];
                    opname.Ontslagdatum = (DateTime)reader["Ontslagdatum"];
                    opname.AfdelingID = (int)reader["AfdelingID"];
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }

            return opname;
        }
        public static int Add(Opname opname)
        {
            SqlConnection connection = DB.GetConnection();
            string insertstring =
                "INSERT Opname (Patientnr, Opnamedatum, Ontslagdatum, AfdelingID)" +
                "VALUES (@Patientnr, @Opnamedatum, @Ontslagdatum, @AfdelingID)";

            SqlCommand insertcmd = new SqlCommand(insertstring, connection);

            insertcmd.Parameters.AddWithValue("Patientnr", opname.Patientnr);
            insertcmd.Parameters.AddWithValue("Opnamedatum", opname.Opnamedatum);
            insertcmd.Parameters.AddWithValue("Ontslagdatum", opname.Ontslagdatum);
            insertcmd.Parameters.AddWithValue("AfdelingID", opname.AfdelingID);

            connection.Open();
            insertcmd.ExecuteNonQuery();
            string selectStatement = "SELECT IDENT_CURRENT('Opname') FROM Opname";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            int opnamenr = Convert.ToInt32(selectCommand.ExecuteScalar());
            return opnamenr;
        }
        public static void Delete(int opnamenr)
        {
            // verwijder alle afhankelijke prestaties
            List<Prestatie> prestaties = PrestatiesDB.GetList();
            prestaties =
                (
                    from prestatie in prestaties
                    where prestatie.Opnamenr == opnamenr
                    select prestatie
                ).ToList();
            PrestatiesDB.DeleteList(prestaties);

            // verwijder de opname
            SqlConnection connection = DB.GetConnection();
            string deleteStatement = "DELETE FROM Opname WHERE opnamenr=@opnamenr";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@opnamenr", opnamenr);
            try
            {
                connection.Open();
                deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
        }
        public static bool Update(Opname opname)
        {
            SqlConnection connection = DB.GetConnection();
            string updateStatement =
                "UPDATE Opname SET " +
                    "Patientnr = @Patientnr," +
                    "Opnamedatum = @Opnamedatum," +
                    "Ontslagdatum = @Ontslagdatum," +
                    "AfdelingID = @AfdelingID " +
                "WHERE " +
                    "Patientnr = @Patientnr";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@Patientnr", opname.Patientnr);
            updateCommand.Parameters.AddWithValue("@Opnamedatum", opname.Opnamedatum);
            updateCommand.Parameters.AddWithValue("@Ontslagdatum", opname.Ontslagdatum);
            updateCommand.Parameters.AddWithValue("@AfdelingID", opname.AfdelingID);

            try
            {
                connection.Open();
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
            finally
            {
                connection.Close();
            }
        }

        public static List<Opname> GetList()
        {
            List<Opname> opnames = new List<Opname>();
            opnames.Clear();

            SqlConnection connection = DB.GetConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Opname", connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Opname p = new Opname();
                    p.Opnamenr = (int)reader["Opnamenr"];
                    p.Patientnr = (int)reader["Patientnr"];
                    p.AfdelingID = (int)reader["AfdelingID"];
                    p.Opnamedatum = (DateTime)reader["Opnamedatum"];
                    p.Ontslagdatum = (DateTime)reader["Ontslagdatum"];
                    p.Patientnr = (int)reader["Patientnr"];
                    opnames.Add(p);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
            opnames = opnames.OrderBy(o=>o.Opnamedatum).ToList();
            return opnames;
        }
        public static List<Opname> GetList(Patient patient)
        {
            List<Opname> Opnames = new List<Opname>();
            Opnames = OpnameDB.GetList();

            // toon enkel opnames van de geselecteerde patient
            Opnames =
            (
                from opname in Opnames
                where opname.Patientnr == patient.Patientnr
                orderby opname.Opnamedatum descending
                select opname
            ).ToList();

            return Opnames;
        }
        public static void DeleteList(List<Opname> opnamelijst)
        {
            foreach (Opname opn in opnamelijst)
                Delete(opn.Opnamenr);
        }

        public static void DeletePatientOpnames(int patientnr)
        {
            foreach (Opname opn in GetList())
                if(opn.Patientnr== patientnr)
                    Delete(opn.Opnamenr);
        }

    }

}
