using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document_Confirmer.formwork;

namespace Document_Confirmer.documents
{
    class INN : Document
    {
        public int inn_ID;
        public string number;
        public String extradition_date;
        public string region_code;

        public void DocumentAction(FormWorker FW)
        {
            FW.CheckForm(this);
        }
    }
}
