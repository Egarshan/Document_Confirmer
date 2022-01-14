using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document_Confirmer.forms;
using Document_Confirmer.documents;

namespace Document_Confirmer.forms
{
    public partial class DecisionWindow : Form
    {
        CitizenInfo CititeznForm;
        int WarningSum;
        int CitizenFormMode;
        bool isPassed;
        Color backUp;

        public DecisionWindow(int [] warning_lvls, CitizenInfo CiniteznF, DataTable dataTable, int mode)
        {
            InitializeComponent();
            CititeznForm = CiniteznF;
            CitizenFormMode = mode;

            for (int i = 0; i < warning_lvls.Length; i++)
                WarningSum += warning_lvls[i];

            if (CitizenFormMode == 0)
                switch (WarningSum)
                {
                    case 1:
                        WarningLevel_label.Text = "Низкий уровень подозрительности"; //Скорее всего, однофамилец с таким же именем, но стоит проверить
                        WarningLevel_label.BackColor = Color.LightGreen;
                        break;

                    case 2:
                        WarningLevel_label.Text = "Средний уровень подозрительности"; //решение остается за таможенником (если гражданин предъявляет доп. документы о том, 
                        WarningLevel_label.BackColor = Color.Yellow;                  //что его основные документы оформлены верно, то он пропускается)
                        break;

                    case 3:
                        WarningLevel_label.Text = "Высокий уровень подозрительности"; //возможна подмена документов. Гражданина под стражу до выяснения объстоятельств
                        WarningLevel_label.BackColor = Color.Red;
                        AcceptAction_btn.Visible = false;
                        break;

                    case 4:
                        WarningLevel_label.Text = "Критический уровень подозрительности"; //ложная информация или подделанные документы. Гражданина в тюрьму!
                        WarningLevel_label.BackColor = Color.Purple;
                        AcceptAction_btn.Visible = false;
                        break;
                }
                
            else if (CitizenFormMode == 1)
            {
                backUp = Application.OpenForms["CitizenInfo"].BackColor;
                Application.OpenForms["CitizenInfo"].BackColor = Color.WhiteSmoke;
                switch (WarningSum)
                {
                    case 3:
                        WarningLevel_label.Text = "Критический уровень подозрительности";
                        WarningLevel_label.BackColor = Color.Purple;
                        break;

                    case 2:
                        WarningLevel_label.Text = "Высокий уровень подозрительности";
                        WarningLevel_label.BackColor = Color.Red;
                        break;

                    case 1:
                        WarningLevel_label.Text = "Средний уровень подозрительности";
                        WarningLevel_label.BackColor = Color.Yellow;
                        break;

                    case 0:
                        if (warning_lvls[0] == 0) { }
                        WarningLevel_label.Text = "Низкий уровень подозрительности";
                        WarningLevel_label.BackColor = Color.LightGreen;
                        break;
                }
            }   

            CompareTable.DataSource = dataTable;
        }
        public bool GetValid()
        {
            return isPassed;
        }

        private void AcceptAction_btn_Click(object sender, EventArgs e)
        {
            isPassed = true;
            if (CitizenFormMode == 0)
            {
                CititeznForm.Dispose();
                MessageBox.Show("Регистрация успешно завершена");
            }          
            else if (CitizenFormMode == 1)
            {
                MessageBox.Show("Гражданин пропущен");
                Application.OpenForms["CitizenInfo"].BackColor = backUp;
            }
            this.Dispose();
        }
        private void CancelAction_btn_Click(object sender, EventArgs e)
        {
            isPassed = false;
            if (CitizenFormMode == 0)
            {
                CititeznForm.Dispose();
                MessageBox.Show("Регистрация отклонена");
            }    
            else if (CitizenFormMode == 1)
            {
                MessageBox.Show("Гражданин не пропущен");
                Application.OpenForms["CitizenInfo"].BackColor = backUp;
            }
            this.Dispose();
        }
    }
}
