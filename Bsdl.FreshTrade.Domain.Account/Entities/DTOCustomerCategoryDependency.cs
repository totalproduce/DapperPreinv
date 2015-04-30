using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.Account.Entities
{
    public class DTOCustomerCategoryDependency
    {
        public int CustomerId { get; set; } /*ClaRecNo*/

        public int CategoryNo { get; set; }
    }
}
