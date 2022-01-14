using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document_Confirmer.formwork;

namespace Document_Confirmer.documents
{
    interface Document
    {
        void DocumentAction(FormWorker FW);
    }
}
