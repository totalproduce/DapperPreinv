using System.Collections.Generic;
using System.ServiceModel;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;

namespace Bsdl.FreshTrade.Services.Account.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IAccountsService
    {
        [OperationContract]
        List<WideAccountInfo> GetAccountsBySalesOffice(int salesOfficeNo, DTOAccountType? accountType = null);
    }
}
