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

namespace Document_Confirmer
{
    public partial class CustomsApp : Form
    {
        public CustomsApp()
        {
            InitializeComponent();
        }
        private void OpenCitizenForm(bool isChecking)
        {
            if (isChecking)
            {
                CitizenInfo NCForm = new CitizenInfo("Проверка документов", "Проверить", 1, this);
                NCForm.Show();
            }
            else
            {
                CitizenInfo NCForm = new CitizenInfo("Регистрация нового гражданина", "Завершить", 0, this);
                NCForm.Show();
            }
            this.Hide();
        }

        private void New_citizen_btn_Click(object sender, EventArgs e)
        {
            OpenCitizenForm(false);
        }

        private void Check_citizen_btn_Click(object sender, EventArgs e)
        {
            OpenCitizenForm(true);
        }
    }
}
