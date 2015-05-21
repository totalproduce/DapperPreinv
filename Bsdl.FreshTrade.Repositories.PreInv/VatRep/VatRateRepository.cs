﻿using System.Collections.Generic;
using System.Linq;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.VatRep
{
    public class VatRateRepository : DapperRepositoryBase<DTOVatRate>, IVatRateRepository
    {
        private const string _sqlQuery = @"SELECT * FROM VATRATES";

        public VatRateRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOVatRate, int>(i => i.Id, VatRates.FieldNames.VATRECNO, FieldType.Integer)
                }
            )
        {
        }

        protected override List<DTOVatRate> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<VatRates>(query);

            return results
                    .Select(item =>
                        new DTOVatRate
                        {
                            Id = item.Vatrecno,
                            VatRate = item.Vatrate,
                            VatRate2 = item.Vatrate2
                        })
                    .ToList();
        }
    }
}
