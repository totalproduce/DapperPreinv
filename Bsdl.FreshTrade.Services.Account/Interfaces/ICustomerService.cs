using System.Collections.Generic;
using System.ServiceModel;
using Bsdl.FreshTrade.Domain.Account.Entities;

namespace Bsdl.FreshTrade.Services.Account.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ICustomerService
    {
        [OperationContract]
        List<DTOCustomerGroup> GetCustomerGroups(bool isCustomer);// isCustomer=false means supplier

        [OperationContract]
        List<DTOCustomerCategory> GetCustomerCategoriesByGroup(int custGroupId);

    }
}
