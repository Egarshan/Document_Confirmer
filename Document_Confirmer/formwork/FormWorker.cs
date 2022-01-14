using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document_Confirmer.documents;

namespace Document_Confirmer.formwork
{
    interface FormWorker
    {
        void CheckForm(CitizenCard verifiable_user);
        void CheckForm(Passport verifiable_passport);
        void CheckForm(INN verifiable_inn);
        void CheckForm(Policy verifiable_policy);
    }
}
