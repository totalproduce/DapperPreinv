using Bsdl.FreshTrade.Domain.Basic.Exceptions;

namespace Bsdl.FreshTrade.Domain.Account.Exceptions
{
    /// <summary>
    /// thrown when sales office is null
    /// </summary>
    /// 
    public sealed class SalesOfficeNullException : FreshTradeException
    {           
        public SalesOfficeNullException()
            : base("Sales Office Is Null ")
        {

        }        
    }
}
