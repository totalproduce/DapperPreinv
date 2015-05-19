using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Entities;

namespace Bsdl.FreshTrade.Services.Basic.Dictionary
{
    public class DictionaryService : FreshTradeServiceBase, IDictionaryService
    {
        #region initialization routine

        private ICurrencyDictionaryRepository _currencyDictionaryRepository;
        protected ICurrencyDictionaryRepository CurrencyDictionaryRepository
        {
            get
            {
                if (_currencyDictionaryRepository == null)
                {
                    _currencyDictionaryRepository = UnitOfWorkCurrent.GetRepository<ICurrencyDictionaryRepository>();
                }
                return _currencyDictionaryRepository;
            }
        }

        private ICurrencyRateRepository _currencyRateRepository;
        protected ICurrencyRateRepository CurrencyRateRepository
        {
            get
            {
                if (_currencyRateRepository == null)
                {
                    _currencyRateRepository = UnitOfWorkCurrent.GetRepository<ICurrencyRateRepository>();
                }
                return _currencyRateRepository;
            }
        }

        private ICompanyDictionaryRepository _companyDictionaryRepository;
        protected ICompanyDictionaryRepository CompanyDictionaryRepository
        {
            get
            {
                if (_companyDictionaryRepository == null)
                {
                    _companyDictionaryRepository = UnitOfWorkCurrent.GetRepository<ICompanyDictionaryRepository>();
                }
                return _companyDictionaryRepository;
            }
        }

        public DictionaryService(IRepositoryFactory repositoryFactory)
            : base(repositoryFactory)
        {
        }
        #endregion

        public List<DTOCurrency> GetCurrencyData()
        {
            return CurrencyDictionaryRepository.GetData(new List<ISearchField>(), CachingStrategy.GlobalCache);
        }


        public List<DTOCompany> GetCompanyData()
        {
            return CompanyDictionaryRepository.GetData(new List<ISearchField>(), CachingStrategy.GlobalCache);
        }

        public decimal ConvertCurrency(decimal value, int fromCurrency, int toCurrency, int useFor)
        { //TODO To test this piece !

            if (fromCurrency == toCurrency) { return RoundCurrency(value, toCurrency); }

            var lRates = CurrencyRateRepository.GetData(null, CachingStrategy.PerRequest).Where(c => c.UseFor == useFor).ToList();

            var fromRate = lRates.FirstOrDefault(r => r.CurNo == fromCurrency);

            if (fromRate == null)
            {
                throw new FreshTradeException("Currency conversion rates not found");
            }

            switch (toCurrency)
            {
                case DTOCurrency.BaseCurrencyNo:
                    return RoundCurrency(value * fromRate.RateToBase, toCurrency);
                case DTOCurrency.EuroCurrencyNo:
                    return RoundCurrency(value * fromRate.RateToEuro, toCurrency);
            }

            var toRate = lRates.FirstOrDefault(r => r.CurNo == toCurrency);

            if (toRate == null)
            {
                throw new FreshTradeException("Currency conversion rates not found");
            }

            switch (fromCurrency)
            {
                case DTOCurrency.BaseCurrencyNo:
                    return RoundCurrency(value * toRate.RateFromBase, toCurrency);
                case DTOCurrency.EuroCurrencyNo:
                    return RoundCurrency(value * fromRate.RateFromEuro, toCurrency);
            }

            // unclear tringulation algorithm
            var currInfo = CurrencyDictionaryRepository.GetData(null, CachingStrategy.PerRequest).FirstOrDefault(cd => cd.No == toCurrency);
            bool tringulate = currInfo != null && currInfo.IsTriangulate;

            if (tringulate)
            {
                return RoundCurrency(value * fromRate.RateToBase * toRate.RateFromBase, toCurrency);
            }

            throw new FreshTradeException("Currency conversion rates not suitable for triangulation");
        }

        public decimal RoundCurrency(decimal value, int currency)
        {
            var currInfo = CurrencyDictionaryRepository.GetData(null, CachingStrategy.PerRequest).FirstOrDefault(cd => cd.No == currency);
            if (currInfo != null && currInfo.DecimalPlaces.HasValue)
            {
               return Math.Round(value, currInfo.DecimalPlaces.Value, MidpointRounding.AwayFromZero);
            }
            return value;
        }

        public string CurrencyAsString(decimal value, int currency)
        {
            var currInfo = CurrencyDictionaryRepository.GetData(null, CachingStrategy.PerRequest).FirstOrDefault(cd => cd.No == currency);
            var lFormatCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            if (currInfo != null && currInfo.DecimalPlaces.HasValue)
            {
                if (currInfo.DecimalPlaces.HasValue)
                {
                    lFormatCulture.NumberFormat.CurrencyDecimalDigits = currInfo.DecimalPlaces.Value;
                }
                if (currInfo.CurSymbol != null)
                {
                    lFormatCulture.NumberFormat.CurrencySymbol = currInfo.CurSymbol;
                }
                if (!string.IsNullOrWhiteSpace(currInfo.CurDecimalPoint))
                {
                    lFormatCulture.NumberFormat.CurrencyDecimalSeparator = currInfo.CurDecimalPoint;
                }
                if (currInfo.CurThousandSeparator != null)
                {
                    lFormatCulture.NumberFormat.CurrencyGroupSeparator = currInfo.CurThousandSeparator;
                }
                if (currInfo.CurSymbolAtFront)
                {
                    lFormatCulture.NumberFormat.CurrencyPositivePattern = 0;
                    lFormatCulture.NumberFormat.CurrencyNegativePattern = 2;
                }
                else
                {
                    lFormatCulture.NumberFormat.CurrencyPositivePattern = 1;
                    lFormatCulture.NumberFormat.CurrencyNegativePattern = 5;
                }
            }
            return value.ToString("C", lFormatCulture);
        }
    }
}
