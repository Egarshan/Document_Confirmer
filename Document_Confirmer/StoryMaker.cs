using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Document_Confirmer
{
    class StoryMaker
    {
        public int FullPass;
        public int FullDecline;
        public int GangstaPass;

        int RecordsCount;
        double GangstaPossibility;
        int PAS_ID, INN_ID, POL_ID;
        int User_ID;
        
        double Event;
        double[] possibilities = { 0.4, 0.2, 0.2, 0.2 };

        Random rnd;

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlReader;

        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\REPOS\OOAD\Document_Confirmer\Document_Confirmer\DocumentsDB.mdf;Integrated Security=True";
        public string[] InputsValues;
        string sqlExpression;

        public StoryMaker()
        {
            FullPass = 0;
            FullDecline = 0;
            GangstaPass = 0;
            rnd = new Random();
            InputsValues = new string[12];
        }

        public bool CalculateGangsta(int [] Relations)
        {
            int RelSum = 0;
            for (int i = 0; i < Relations.Length; i++)
                RelSum += Relations[i];

            switch (RelSum)
            {
                case 3:
                    GangstaPossibility = 0.98;
                    break;
                
                case 2:
                    GangstaPossibility = 0.78;
                    break;

                case 1:
                    GangstaPossibility = 0.58;
                    break;

                case 0:
                    if (rnd.NextDouble() - 0.5 < 0)
                        GangstaPossibility = 0.08;
                    else
                        GangstaPossibility = 0;
                    break;
            }

            double ev = rnd.NextDouble();
            if ((ev - GangstaPossibility) < 0) return true;
            else return false;
        }
        private void FullDocFiller(string sqlExpr, int i_start, int i_end)
        {
            sqlCommand = new SqlCommand(sqlExpr, sqlConnection);
            sqlReader = sqlCommand.ExecuteReader();
            int index = 1;

            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                for (int i = i_start; i < i_end; i++)
                    InputsValues[i] = sqlReader.GetValue(index++).ToString();
            }
            sqlReader.Close();
        }
        private void SetUserID()
        {
            sqlExpression = "SELECT TOP 1 * FROM (SELECT TOP " + rnd.Next(1, RecordsCount) + " * FROM [CITIZEN] ORDER BY ID) temp ORDER BY ID DESC";
            sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
            sqlReader = sqlCommand.ExecuteReader();
            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                User_ID = (int)sqlReader.GetValue(0);
            }
            sqlReader.Close();

            sqlCommand = new SqlCommand("SELECT * FROM [CITIZEN] WHERE ID = '" + User_ID + "'", sqlConnection);
            sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                PAS_ID = (int)sqlReader.GetValue(3);
                INN_ID = (int)sqlReader.GetValue(5);
                POL_ID = (int)sqlReader.GetValue(4);
            }
            sqlReader.Close();
        }
        private void StoryOne()
        {
            SetUserID();
            FullDocFiller(sqlExpression, 0, 2);

            sqlExpression = "SELECT * FROM [PASSPORT] WHERE passport_id = '" + PAS_ID + "'";
            FullDocFiller(sqlExpression, 2, 7);

            sqlExpression = "SELECT * FROM [INN] WHERE INN_id = '" + INN_ID + "'";
            FullDocFiller(sqlExpression, 7, 10);

            sqlExpression = "SELECT * FROM [POLICY] WHERE policy_id = '" + POL_ID + "'";
            FullDocFiller(sqlExpression, 10, 12);
        }
        private void StoryTwo()
        {
            SetUserID();
            FullDocFiller(sqlExpression, 0, 2);

            sqlExpression = "SELECT * FROM [POLICY] WHERE policy_id = '" + POL_ID + "'";
            FullDocFiller(sqlExpression, 10, 12);

            sqlExpression = "SELECT * FROM [INN] WHERE INN_id = '" + INN_ID + "'";
            FullDocFiller(sqlExpression, 7, 10);

            SetUserID();
            sqlExpression = "SELECT * FROM [PASSPORT] WHERE passport_id = '" + PAS_ID + "'";
            FullDocFiller(sqlExpression, 2, 7); 
        }
        private void StoryThree()
        {
            SetUserID();
            FullDocFiller(sqlExpression, 0, 2);

            sqlExpression = "SELECT * FROM [POLICY] WHERE policy_id = '" + POL_ID + "'";
            FullDocFiller(sqlExpression, 10, 12);

            SetUserID();
            sqlExpression = "SELECT * FROM [PASSPORT] WHERE passport_id = '" + PAS_ID + "'";
            FullDocFiller(sqlExpression, 2, 7);

            SetUserID();
            sqlExpression = "SELECT * FROM [INN] WHERE INN_id = '" + INN_ID + "'";
            FullDocFiller(sqlExpression, 7, 10);
        }
        private void StoryFour()
        {
            SetUserID();
            FullDocFiller(sqlExpression, 0, 2);

            SetUserID();
            sqlExpression = "SELECT * FROM [PASSPORT] WHERE passport_id = '" + PAS_ID + "'";
            FullDocFiller(sqlExpression, 2, 7);

            SetUserID();
            sqlExpression = "SELECT * FROM [INN] WHERE INN_id = '" + INN_ID + "'";
            FullDocFiller(sqlExpression, 7, 10);

            SetUserID();
            sqlExpression = "SELECT * FROM [POLICY] WHERE policy_id = '" + POL_ID + "'";
            FullDocFiller(sqlExpression, 10, 12);
        }

        public void MakeStory()
        {
            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            sqlCommand = new SqlCommand("SELECT COUNT(*) FROM [CITIZEN]", sqlConnection);
            sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                RecordsCount = (int)sqlReader.GetValue(0);
            }
            sqlReader.Close();

            Event = rnd.NextDouble();
            int ind = -1;

            while (Event > 0)
                Event -= possibilities[++ind];

            switch (ind)
            {
                case 0:
                    StoryOne();
                    break;

                case 1:
                    StoryTwo();
                    break;

                case 2:
                    StoryThree();
                    break;

                case 3:
                    StoryFour();
                    break;
            }

            InputsValues[0] = InputsValues[0].Replace(" ", "");
            InputsValues[1] = InputsValues[1].Replace(" ", "");
            InputsValues[4] = InputsValues[4].Replace(" ", "");
            InputsValues[6] = InputsValues[6].Replace(" ", "");

            sqlConnection.Close();
        }
    }
}
