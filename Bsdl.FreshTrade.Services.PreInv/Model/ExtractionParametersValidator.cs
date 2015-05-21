using System;
using System.Collections.Generic;
using System.Linq;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic;

namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    public class ExtractionParametersValidator
    {
        private readonly ISalesOfficeRepository _salesOfficeRepository;
        private readonly ICurrencyDictionaryRepository _currencyDictionaryRepository;
        private readonly ICompanyDictionaryRepository _companyDictionaryRepository;

        #region Helpers

        private void AccountParamsValidation(DTOPreInvExtractAccountParams accountParams)
        {
            if (accountParams == null)
            {
                throw new FreshTradeException("ExtractParams has no AccountParams specified");
            }
            bool categoriesExists = (accountParams.Categories != null) && (accountParams.Categories.Count > 0);
            if (accountParams.FilterType == PreInvExtractAccountFilterType.All)
            {
                if ((accountParams.AccountClassId.HasValue || categoriesExists))
                {
                    throw new FreshTradeException("AccountFilterType = All but either company or category specified");
                }
            }
            else
                if (accountParams.FilterType == PreInvExtractAccountFilterType.ByCategory)
                {
                    if (accountParams.AccountClassId.HasValue)
                    {
                        throw new FreshTradeException("AccountFilterType = ByCategory but company is specified as well");
                    }

                    if (!categoriesExists)
                    {
                        throw new FreshTradeException("Please specify at least one category");
                    }
                }
                else
                    if (accountParams.FilterType == PreInvExtractAccountFilterType.ByCustomer)
                    {
                        if (!accountParams.AccountClassId.HasValue)
                        {
                            throw new FreshTradeException("Please specify company");
                        }

                        if (categoriesExists)
                        {
                            throw new FreshTradeException("AccountFilterType = ByCustomer but catgories are specified as well");
                        }
                    }
        }

        private void ValidateDates(DTOPreInvExtractParams extractParams, IDTOSalesOffice salesOffice)
        {
            if (extractParams == null)
            {
                throw new ArgumentNullException("extractParams");
            }
            if (salesOffice == null)
            {
                throw new ArgumentNullException("salesOffice");
            }

            if (extractParams.CutOffDeliveryDate == default(DateTime))
            {
                throw new FreshTradeException("CutOffDeliveryDate is empty");
            }

            if (extractParams.TaxPointDate == default(DateTime))
            {
                throw new FreshTradeException("TaxPointDate is empty");
            }

            if ((extractParams.TaxPointDate < extractParams.CutOffDeliveryDate) && (!salesOffice.TaxDateBeforeDeliveryDate))
            {
                throw ErrorHelpers.TranslateErrorMessage(new FreshTradeException(1053, "Tax Point Date must come after the Cut off Delivery date"));
            }
        }

        private void ValidateCurrencyParameter(int currencyNo)
        {
            if (currencyNo <= 0)
            {
                throw ErrorHelpers.TranslateErrorMessage(new FreshTradeException(1055, "You must select a Currency"));
            }

            var currencies = _currencyDictionaryRepository.GetData(null, CachingStrategy.GlobalCache);
            if (!currencies.Exists(c => c.No == currencyNo))
            {
                throw ErrorHelpers.TranslateErrorMessage(new FreshTradeException(1056, "Unknown description for Currency No = " + currencyNo.ToString()));
            }
        }

        private void ValidateCompanyParameter(int companyNo)
        {
            if (companyNo <= 0)
            {
                throw ErrorHelpers.TranslateErrorMessage(new FreshTradeException(1057, "You must select a Company"));
            }

            var companies = _companyDictionaryRepository.GetData(null, CachingStrategy.GlobalCache);
            if (!companies.Exists(c => c.No == companyNo))
            {
                throw ErrorHelpers.TranslateErrorMessage(new FreshTradeException(1058, "Unknown Company No  = " + companyNo.ToString()));
            }
        }
        #endregion

        public ExtractionParametersValidator
        (
            ISalesOfficeRepository salesOfficeRepository,
            ICurrencyDictionaryRepository currencyDictionaryRepository,
            ICompanyDictionaryRepository companyDictionaryRepository
        )
        {
            _salesOfficeRepository = salesOfficeRepository;
            _currencyDictionaryRepository = currencyDictionaryRepository;
            _companyDictionaryRepository = companyDictionaryRepository;
        }

        public void Validate(DTOPreInvExtractParams extractParams)
        {
            if (extractParams == null)
            {
                throw new FreshTradeException("ExtractParams are empty.");
            }

            AccountParamsValidation(extractParams.AccountParams);

            if (extractParams.SalesOfficeNo != DTOSalesOffice.IncludeAllSalesOfficesNo)
            {
                DTOSalesOffice.ValidateSalesOfficeNumber(extractParams.SalesOfficeNo);
            }

            var salesOffice = _salesOfficeRepository.GetSalesOfficeByNo(extractParams.SalesOfficeNo);
            ValidateDates(extractParams, salesOffice);


            ValidateCurrencyParameter(extractParams.CurrencyNo);
            ValidateCompanyParameter(extractParams.CompanyNo);
        }
    }
}
