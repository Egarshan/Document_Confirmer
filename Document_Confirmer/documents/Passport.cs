using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document_Confirmer.formwork;

namespace Document_Confirmer.documents
{
    class Passport : Document
    {
        public int passport_ID;
        public string number;
        public String birth_date;
        public string extradition_city;
        public String extradition_date;
        public string subdivisions_code;

        public void DocumentAction(FormWorker FW)
        {
            FW.CheckForm(this);
        }
    }
}
