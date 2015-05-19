using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.Domain.Account.Exceptions
{
    /// <summary>
    /// thrown when sales office Id is not valid
    /// </summary>
    /// 
    public sealed class SalesOfficeIdInvalidValueException : FreshTradeException
    {
        public SalesOfficeIdInvalidValueException(int id)
            : base("Sales Office Id Is invalid : " + id + " Permitted range " + DTOSalesOffice.MinSalesOfficeId + " -> " + DTOSalesOffice.MaxSalesOfficeId) 
        {

        }        
    
    }
}
