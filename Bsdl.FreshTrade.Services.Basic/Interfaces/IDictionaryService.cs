using Bsdl.FreshTrade.Domain.Basic.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Bsdl.FreshTrade.Services.Basic.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IDictionaryService: IFreshTradeServiceBase
    {
        [OperationContract]
        List<DTOCompany> GetCompanyData();

        [OperationContract]
        List<DTOCurrency> GetCurrencyData();

        decimal ConvertCurrency(decimal value, int fromCurrency, int toCurrency, int useFor);

        decimal RoundCurrency(decimal value, int currency);
        string CurrencyAsString(decimal value, int currency);
    }
}
