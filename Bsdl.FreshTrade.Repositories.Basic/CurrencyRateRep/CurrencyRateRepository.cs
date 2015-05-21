using System;
using System.Collections.Generic;
using System.Linq;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;

using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.CurrencyRateRep
{

    public class CurrencyRateRepository : DapperRepositoryBase<DTOCurrencyRate>, ICurrencyRateRepository
    {
        private const string _sqlQuery = @"SELECT * FROM ACCCURRRATE";

        public CurrencyRateRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return CurrencyRate.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "ACCCURRRATE";
        }

        public override IBaseModel ToDbModel(DTOCurrencyRate item)
        {
            var result = new CurrencyRate();
            result.Ratcurno = item.CurNo;
            result.Ratratefrombase = item.RateFromBase;
            result.Ratratefromeuro = item.RateFromEuro;
            result.Ratratetobase= item.RateToBase;
            result.Ratratetoeuro= item.RateToEuro;
            result.Ratusefor= item.UseFor;
            return result;
        }

        protected override List<DTOCurrencyRate> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOCurrencyRate>();

            IEnumerable<CurrencyRate> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<CurrencyRate>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load CURRENCYRATE" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOCurrencyRate
                            {
                              CurNo = item.Ratcurno,
                              RateFromBase = item.Ratratefrombase ?? 0,
                              RateFromEuro = item.Ratratefromeuro ?? 0,
                              RateToBase = item.Ratratetobase ?? 0,
                              RateToEuro = item.Ratratetoeuro ?? 0,
                              UseFor= item.Ratusefor
                }
                        );
                }
            }

            return data;
        }

        public DTOCurrencyRate GetRateByCurrencyNo(int curNo, int rateUseFor)
        {
            return GetData(null, CachingStrategy.PerRequest).First(i => (i.CurNo == curNo) && (i.UseFor == rateUseFor));
        }

        public decimal GetRateToEuro(int curNo, int rateUseFor)
        {
            return GetRateByCurrencyNo(curNo, rateUseFor).RateToEuro;
        }

        public decimal GetRateFromEuro(int curNo, int rateUseFor)
        {
            return GetRateByCurrencyNo(curNo, rateUseFor).RateFromEuro;
        }

        public decimal GetRateToBase(int curNo, int rateUseFor)
        {
            return GetRateByCurrencyNo(curNo, rateUseFor).RateToBase;
        }

        public decimal GetRateFromBase(int curNo, int rateUseFor)
        {
            return GetRateByCurrencyNo(curNo, rateUseFor).RateFromBase;
        }

    }
}

