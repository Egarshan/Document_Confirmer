using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document_Confirmer.formwork;

namespace Document_Confirmer.documents
{
    class CitizenCard : Document
    {
        public string first_name;
        public string second_name;

        public int PassportID;
        public int INNID;
        public int PolicyID;

        public Passport citizen_passport;
        public INN citizen_inn;
        public Policy citizen_policy;

        public CitizenCard()
        {
            citizen_passport = new Passport();
            citizen_inn = new INN();
            citizen_policy = new Policy();
        }
        public void DocumentAction(FormWorker FW)
        {
            FW.CheckForm(this);
        }
    }
}
