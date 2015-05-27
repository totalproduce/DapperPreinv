using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;

namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    class PersistanceProcessor
    {
        private ISalesOfficeRepository _salesOfficeRepository {get; set;}
        //IsEdiInv = Not ( tc["InvEdi"].isEmpty() )  ; set 'is Edi' global variable
        private bool IsEdiInv {get; set;}


        public PersistanceProcessor
        (
            ISalesOfficeRepository salesOfficeRepository
        )
        {
            _salesOfficeRepository = salesOfficeRepository;
        }

        protected bool updateEdi()
        {
            //todo write logic here
            return IsEdiInv;
        }

        public void Process(DTOPreInvExtractParams extractParams)
        {

        }
    }
}
