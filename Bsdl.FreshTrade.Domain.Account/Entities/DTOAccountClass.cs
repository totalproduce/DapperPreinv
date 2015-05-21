using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Enums;

namespace Bsdl.FreshTrade.Domain.Account.Entities
{
    public class DTOAccountClass
    {
        public int Id { get; set; } /*ClaRecNo*/

        public int AccountId { get; set; } /*AccRecNo*/

        public string AccountCode { get; set; }

        public int CurrencyNo { get; set; }

        public DTOAccountStatusType AccountStatus { get; set; }

        public DTOAccountType Type { get; set; }
    }
}
