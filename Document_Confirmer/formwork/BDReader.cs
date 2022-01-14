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
    class BDReader : FormWorker
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\REPOS\OOAD\Document_Confirmer\Document_Confirmer\DocumentsDB.mdf;Integrated Security=True";
        string sqlExpression;
        int[] WarningArray = { 0, 0, 0, 0 };
        int[] RelationDocuments = { 0, 0, 0 };

        CitizenCard ComparedCitizen;

        SqlDataAdapter adapter;
        DataTable table;

        public BDReader()
        {
            ComparedCitizen = new CitizenCard();
        }
        public int[] GetWarningArray()
        {
            return WarningArray;
        }
        public int[] GetRelationDocuments()
        {
            return RelationDocuments;
        }

        public DataTable GetCompareTable()
        {
            return table;
        }

        public void CheckForm(CitizenCard verifiable_citizen)
        {
            ComparedCitizen.first_name = null;
            ComparedCitizen.second_name = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                sqlExpression = "SELECT * FROM CITIZEN WHERE first_name = '" + verifiable_citizen.first_name + "'" + 
                    " AND last_name = '" + verifiable_citizen.second_name + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                WarningArray[0] = 0;

                if (sqlReader.HasRows)
                {
                    sqlReader.Read();
                    ComparedCitizen.first_name = (string)sqlReader.GetValue(1);
                    ComparedCitizen.second_name = (string)sqlReader.GetValue(2);
                    ComparedCitizen.first_name = ComparedCitizen.first_name.Replace(" ", "");
                    ComparedCitizen.second_name = ComparedCitizen.second_name.Replace(" ", "");

                    ComparedCitizen.PassportID = (int)sqlReader.GetValue(3);
                    ComparedCitizen.PolicyID = (int)sqlReader.GetValue(4);
                    ComparedCitizen.INNID = (int)sqlReader.GetValue(5);

                    WarningArray[0] = 1;
                }

                sqlReader.Close();
                connection.Close();

                for (int i = 0; i < WarningArray.Length; i++)
                    if (WarningArray[i] == 1)
                    {
                        FillDataTable();
                        break;
                    }

                RelationDocuments[0] = 0;
                RelationDocuments[1] = 0;
                RelationDocuments[2] = 0;
                if (ComparedCitizen.PassportID != ComparedCitizen.citizen_passport.passport_ID)
                    RelationDocuments[0] = 1;
                if (ComparedCitizen.PolicyID != ComparedCitizen.citizen_policy.policy_ID)
                    RelationDocuments[1] = 1;
                if (ComparedCitizen.INNID != ComparedCitizen.citizen_inn.inn_ID)
                    RelationDocuments[2] = 1;
            }
        }
        public void CheckForm(Passport verifiable_passport)
        {
            ComparedCitizen.citizen_passport.number = null;
            ComparedCitizen.citizen_passport.birth_date = null;
            ComparedCitizen.citizen_passport.extradition_city = null;
            ComparedCitizen.citizen_passport.extradition_date = null;
            ComparedCitizen.citizen_passport.subdivisions_code = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                sqlExpression = "SELECT * FROM PASSPORT WHERE number = '" + verifiable_passport.number + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                WarningArray[1] = 0;

                if (sqlReader.HasRows)
                {
                    sqlReader.Read();
                    ComparedCitizen.citizen_passport.passport_ID = (int)sqlReader.GetValue(0);
                    ComparedCitizen.citizen_passport.number = (string)sqlReader.GetValue(1);
                    ComparedCitizen.citizen_passport.birth_date = (string)sqlReader.GetValue(2);
                    ComparedCitizen.citizen_passport.extradition_city = (string)sqlReader.GetValue(3);
                    ComparedCitizen.citizen_passport.extradition_city = ComparedCitizen.citizen_passport.extradition_city.Replace(" ","");
                    ComparedCitizen.citizen_passport.extradition_date = (string)sqlReader.GetValue(4);
                    ComparedCitizen.citizen_passport.subdivisions_code = (string)sqlReader.GetValue(5);

                    WarningArray[1] = 1;
                }

                sqlReader.Close();
                connection.Close();
            }
        }
        public void CheckForm(INN verifiable_inn)
        {
            ComparedCitizen.citizen_inn.number = null;
            ComparedCitizen.citizen_inn.extradition_date = null;
            ComparedCitizen.citizen_inn.region_code = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                sqlExpression = "SELECT * FROM INN WHERE number = '" + verifiable_inn.number + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                WarningArray[2] = 0;

                if (sqlReader.HasRows)
                {
                    sqlReader.Read();
                    ComparedCitizen.citizen_inn.inn_ID = (int)sqlReader.GetValue(0);
                    ComparedCitizen.citizen_inn.number = (string)sqlReader.GetValue(1);
                    ComparedCitizen.citizen_inn.extradition_date = (string)sqlReader.GetValue(2);
                    ComparedCitizen.citizen_inn.region_code = (string)sqlReader.GetValue(3);

                    WarningArray[2] = 1;
                }

                sqlReader.Close();
                connection.Close();
            }
        }
        public void CheckForm(Policy verifiable_policy)
        {
            ComparedCitizen.citizen_policy.number = null;
            ComparedCitizen.citizen_policy.active_date = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                sqlExpression = "SELECT * FROM POLICY WHERE number = '" + verifiable_policy.number + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                WarningArray[3] = 0;

                if (sqlReader.HasRows)
                {
                    sqlReader.Read();
                    ComparedCitizen.citizen_policy.policy_ID = (int)sqlReader.GetValue(0);
                    ComparedCitizen.citizen_policy.number = (string)sqlReader.GetValue(1);
                    ComparedCitizen.citizen_policy.active_date = (string)sqlReader.GetValue(2);

                    WarningArray[3] = 1;
                }

                sqlReader.Close();
                connection.Close();
            }
        }

        private void FillDataTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                sqlExpression = "SELECT * FROM FULLINFO_VIEW WHERE";
                if (WarningArray[0] == 1)
                    sqlExpression += "(ИМЯ = '" + ComparedCitizen.first_name + "' AND ФАМИЛИЯ = '" + ComparedCitizen.second_name + "') OR";
                if (WarningArray[1] == 1)
                    sqlExpression += " ПАССПОРТ = '" + ComparedCitizen.citizen_passport.number + "' OR";
                if (WarningArray[2] == 1)
                    sqlExpression += " ИНН = '" + ComparedCitizen.citizen_inn.number + "' OR";
                if (WarningArray[3] == 1)
                    sqlExpression += " ПОЛИС = '" + ComparedCitizen.citizen_policy.number + "' ";
                sqlExpression = sqlExpression.Remove(sqlExpression.LastIndexOf(" "));

                adapter = new SqlDataAdapter(sqlExpression, connection);
                table = new DataTable();
                adapter.Fill(table);

                connection.Close();
            }
        }
    }
}
