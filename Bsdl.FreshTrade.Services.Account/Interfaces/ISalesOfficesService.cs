using System.Collections.Generic;
using System.ServiceModel;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;

namespace Bsdl.FreshTrade.Services.Account.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ISalesOfficesService
    {
        /// <summary>
        /// Get a list of the sales offices
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<DTOSalesOffice> GetSalesOffices();

        /*[OperationContract]
        [ServiceKnownType(typeof(SalesOfficeList))]
        ISalesOfficeList GetSalesOfficesByUser(IFreshTradeUser freshTradeUser);
        */
    }
}
