using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document_Confirmer.formwork;

namespace Document_Confirmer.documents
{
    class Policy : Document
    {
        public int policy_ID;
        public string number;
        public String active_date;

        public void DocumentAction(FormWorker FW)
        {
            FW.CheckForm(this);
        }
    }
}
