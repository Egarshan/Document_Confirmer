using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Document_Confirmer.documents;

namespace Document_Confirmer.formwork
{   
    class BDWriter : FormWorker
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\REPOS\OOAD\Document_Confirmer\Document_Confirmer\DocumentsDB.mdf;Integrated Security=True";
        string sqlPost;

        private int FindLastRecordID(string Table, string ColName, SqlConnection SC)
        {
            int result;
            SqlCommand sqlCommand = new SqlCommand("SELECT TOP 1 * FROM ["+ Table + "] ORDER BY " + ColName + " desc", SC);
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            sqlReader.Read();
            result = (int)sqlReader.GetValue(0);
            sqlReader.Close();
            return result;
        }

        public void CheckForm(CitizenCard verifiable_citizen)
        {
            int [] DocID = { 0, 0, 0 };

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DocID[0] = FindLastRecordID("PASSPORT", "passport_id", connection);
            DocID[1] = FindLastRecordID("INN", "INN_id", connection);
            DocID[2] = FindLastRecordID("POLICY", "policy_id", connection);

            sqlPost = "INSERT INTO [CITIZEN] (first_name, last_name, passport_id, INN_id, policy_id) VALUES ('" + 
                verifiable_citizen.first_name + "', '" + verifiable_citizen.second_name + "', '" + DocID[0] + "', '" + DocID[1] +
                "', '" + DocID[2] + "')";

            using (SqlCommand cmd = new SqlCommand(sqlPost, connection))
            {
                cmd.Parameters.AddWithValue("first_name", verifiable_citizen.first_name);
                cmd.Parameters.AddWithValue("last_name", verifiable_citizen.second_name);
                cmd.Parameters.AddWithValue("passport_id", DocID[0]);
                cmd.Parameters.AddWithValue("INN_id", DocID[1]);
                cmd.Parameters.AddWithValue("policy_id", DocID[2]);       

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
        public void CheckForm(Passport verifiable_passport)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            sqlPost = "INSERT INTO [PASSPORT] (number, birth_date, extradition_place, extradition_date, subdivision_code) VALUES" +
                "('" + verifiable_passport.number + "', '" + verifiable_passport.birth_date + "', '" +
                verifiable_passport.extradition_city + "', '" + verifiable_passport.extradition_date + "', '" + verifiable_passport.subdivisions_code + "')";
            using (SqlCommand cmd = new SqlCommand(sqlPost, connection))
            {
                cmd.Parameters.AddWithValue("number", verifiable_passport.number);
                cmd.Parameters.AddWithValue("birth_date", verifiable_passport.birth_date);
                cmd.Parameters.AddWithValue("extradition_place", verifiable_passport.extradition_city);
                cmd.Parameters.AddWithValue("extradition_date", verifiable_passport.extradition_date);
                cmd.Parameters.AddWithValue("subdivision_code", verifiable_passport.subdivisions_code);

                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void CheckForm(INN verifiable_inn)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            sqlPost = "INSERT INTO [INN] (number, extradition_date, region_code) VALUES ('" + verifiable_inn.number + "', '" + 
                verifiable_inn.extradition_date + "', '" + verifiable_inn.region_code + "')";
            using (SqlCommand cmd = new SqlCommand(sqlPost, connection))
            {
                cmd.Parameters.AddWithValue("number", verifiable_inn.number);
                cmd.Parameters.AddWithValue("extradition_date", verifiable_inn.extradition_date);
                cmd.Parameters.AddWithValue("region_code", verifiable_inn.region_code);

                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void CheckForm(Policy verifiable_policy)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            sqlPost = "INSERT INTO [POLICY] (number, validity) VALUES ('" + verifiable_policy.number + "', '" + verifiable_policy.active_date + "')";
            using (SqlCommand cmd = new SqlCommand(sqlPost, connection))
            {
                cmd.Parameters.AddWithValue("number", verifiable_policy.number);
                cmd.Parameters.AddWithValue("validity", verifiable_policy.active_date);

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}
