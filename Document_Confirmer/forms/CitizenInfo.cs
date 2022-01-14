using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Document_Confirmer;
using Document_Confirmer.documents;
using Document_Confirmer.formwork;

namespace Document_Confirmer.forms
{
    public partial class CitizenInfo : Form
    {
        CustomsApp MainForm;
        DecisionWindow DesWin;

        int mode; //0 - регистрация, 1 - проверка
        int [] LenghtsChecker;
        int [] CompareChecker;
        int [] RelationsChecker;

        CitizenCard Citizen;
        StoryMaker StoryMaker;

        CorrectnessWorker CW;
        BDReader BDR;
        BDWriter BDW;

        Color originalColor;

        public CitizenInfo(string form_name, string actionBtn_name, int Mode, CustomsApp MainF)
        {
            
            InitializeComponent();
            
            MainForm = MainF;

            FormName_label.Text = form_name;
            Action_btn.Text = actionBtn_name;
            mode = Mode;

            Citizen = new CitizenCard();

            CW = new CorrectnessWorker();
            BDR = new BDReader();
            BDW = new BDWriter();

            originalColor = this.BackColor;

            if (mode == 1)
            {
                Counters_panel.Visible = true;
                StoryMaker = new StoryMaker();
                GetNewCitizen();
            }
        }

        private void ToMainScreen_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MainForm.Show();
        }
        private void Flag_btn_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://www.youtube.com/watch?v=TpMAfJv7J2Y";
            System.Diagnostics.Process.Start(targetURL);
        }
        private void FillInfromation()
        {
            Citizen.first_name = FName_input.Text;
            Citizen.second_name = SName_input.Text;

            Citizen.citizen_passport.number = PNumber_input.Text;
            Citizen.citizen_passport.birth_date = PBirthDate_input.Text;
            Citizen.citizen_passport.extradition_city = PCity_input.Text;
            Citizen.citizen_passport.extradition_date = PExtraditionDate_input.Text;
            Citizen.citizen_passport.subdivisions_code = PSubdivison_input.Text;

            Citizen.citizen_inn.number = INNNumber_input.Text;
            Citizen.citizen_inn.extradition_date = INNGetDate_input.Text;
            Citizen.citizen_inn.region_code = INNRegionCode_input.Text;

            Citizen.citizen_policy.number = PolicyNumber_input.Text;
            Citizen.citizen_policy.active_date = PolicyActiveDate_input.Text;
        }
        private void DropErrorMessages()
        {
            CitizenError_label.Text = null;
            PassportError_label.Text = null;
            INNError_label.Text = null;
            PolicyError_label.Text = null;

            WrongINNNum_label.Visible = false;
            WrongINNReg_label.Visible = false;
            WrongPasN_label.Visible = false;
            WrongPasSubdiv_label.Visible = false;
            WrongPolNum_label.Visible = false;
        }
        private bool PassRegistration()
        {
            int i;

            if (CitizenError_label.Text != "" || PassportError_label.Text != "" || INNError_label.Text != "" || PolicyError_label.Text != "")
                return false;

            for (i = 0; i < LenghtsChecker.Length; i++)
                if (LenghtsChecker[i] == 1)
                {
                    return false;
                }

            for (i = 0; i < CompareChecker.Length; i++)
                if (CompareChecker[i] == 1)
                {
                    DesWin = new DecisionWindow(CompareChecker, this, BDR.GetCompareTable(), mode);
                    DesWin.Show();
                    return false;
                }

            return true;
        }
        private bool PassChecking()
        {
            int i;
            if (CitizenError_label.Text != "" || PassportError_label.Text != "" || INNError_label.Text != "" || PolicyError_label.Text != "")
                return false;

            for (i = 0; i < LenghtsChecker.Length; i++)
                if (LenghtsChecker[i] == 1)
                {
                    return false;
                }

            for (i = 0; i < RelationsChecker.Length; i++)
                if (RelationsChecker[i] == 1)
                {
                    DesWin = new DecisionWindow(RelationsChecker, this, BDR.GetCompareTable(), mode);
                    DesWin.Show();
                    return false;
                }

            return true;
        }
        private void CitizenInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DesWin != null)
                if (DesWin.GetValid())
                    if (mode == 0)
                        AcceptRegistration();
            MainForm.Show();
        }
        private void AcceptRegistration()
        {
            Citizen.citizen_passport.DocumentAction(BDW);
            Citizen.citizen_inn.DocumentAction(BDW);
            Citizen.citizen_policy.DocumentAction(BDW);
            Citizen.DocumentAction(BDW);
        }
        private void CheckForm()
        {
            Citizen.DocumentAction(CW);
            CitizenError_label.Text = CW.GetErrorMessage();
            CW.SetErrorsToNull();

            Citizen.citizen_passport.DocumentAction(CW);
            PassportError_label.Text = CW.GetErrorMessage();
            CW.SetErrorsToNull();

            Citizen.citizen_inn.DocumentAction(CW);
            INNError_label.Text = CW.GetErrorMessage();
            CW.SetErrorsToNull();

            Citizen.citizen_policy.DocumentAction(CW);
            PolicyError_label.Text = CW.GetErrorMessage();
            CW.SetErrorsToNull();

            LenghtsChecker = CW.GetLenghtsErrors();

            if (LenghtsChecker[0] == 1)
                WrongPasN_label.Visible = true;
            if (LenghtsChecker[1] == 1)
                WrongPasSubdiv_label.Visible = true;

            if (LenghtsChecker[2] == 1)
                WrongINNNum_label.Visible = true;
            if (LenghtsChecker[3] == 1)
                WrongINNReg_label.Visible = true;

            if (LenghtsChecker[4] == 1)
                WrongPolNum_label.Visible = true;

            Citizen.citizen_passport.DocumentAction(BDR);
            Citizen.citizen_inn.DocumentAction(BDR);
            Citizen.citizen_policy.DocumentAction(BDR);
            Citizen.DocumentAction(BDR);

            CompareChecker = BDR.GetWarningArray();
            if (mode == 1)
                RelationsChecker = BDR.GetRelationDocuments();
        }
        private void GetNewCitizen()
        {
            StoryMaker.MakeStory();

            int index = 0;
            FName_input.Text = StoryMaker.InputsValues[index++];
            SName_input.Text = StoryMaker.InputsValues[index++];

            PNumber_input.Text = StoryMaker.InputsValues[index++];
            PBirthDate_input.Value = DateTime.Parse(StoryMaker.InputsValues[index++]);
            PCity_input.Text = StoryMaker.InputsValues[index++];
            PExtraditionDate_input.Value = DateTime.Parse(StoryMaker.InputsValues[index++]);
            PSubdivison_input.Text = StoryMaker.InputsValues[index++];

            INNNumber_input.Text = StoryMaker.InputsValues[index++];
            INNGetDate_input.Value = DateTime.Parse(StoryMaker.InputsValues[index++]);
            INNRegionCode_input.Text = StoryMaker.InputsValues[index++];

            PolicyNumber_input.Text = StoryMaker.InputsValues[index++];
            PolicyActiveDate_input.Value = DateTime.Parse(StoryMaker.InputsValues[index++]);
        }
        private void CitizenInfo_BackColorChanged(object sender, EventArgs e)
        {
            if (this.BackColor == originalColor)
            {
                if (DesWin.GetValid())
                {
                    StoryMaker.FullPass += 1;
                    Passed_сount.Text = StoryMaker.FullPass.ToString();
                    if (StoryMaker.CalculateGangsta(RelationsChecker))
                    {
                        StoryMaker.GangstaPass += 1;
                        Gangsta_сount.Text = StoryMaker.GangstaPass.ToString();
                    }
                }
                else
                {
                    StoryMaker.FullDecline += 1;
                    Decline_count.Text = StoryMaker.FullDecline.ToString();
                }
                GetNewCitizen();
            }

        }
        private void Action_btn_Click(object sender, EventArgs e)
        {
            DropErrorMessages();
            FillInfromation();
            CheckForm();

            if (mode == 0)
            {
                if (PassRegistration())
                {
                    AcceptRegistration();
                    MessageBox.Show("Регистрация успешно завершена");
                    this.Close();
                }
            }
            else if (mode == 1)
            {
                if (PassChecking())
                {
                    DesWin = new DecisionWindow(CompareChecker, this, BDR.GetCompareTable(), mode);
                    DesWin.Show();
                }
            }
        }
    }
}
