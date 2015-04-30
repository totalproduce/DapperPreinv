using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.DiscountRep
{
    public class DiscountRatesRepository : DapperRepositoryBase<DTODiscountRates>, IDiscountRatesRepository
    {
        private const string _sqlQuery = @"SELECT * FROM DISRATES";

        public DiscountRatesRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
                (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                    {
                        new SearchFieldDef<DTODiscountRates, int>(i => i.DraRecNo, DisRates.FieldNames.DRARECNO,
                                                                  FieldType.Integer)
                    }
                )
        {
        }

        protected override List<DTODiscountRates> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache,
                                                                  uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<DisRates>(query);

            return results
                .Select(item =>
                        new DTODiscountRates
                            {
                                DraRecNo = item.Drarecno,
                                ThisSeqNo = item.Thisseqno,
                                ThisRate = item.Thisrate,
                                ThisPercRate = item.Thispercrate,
                                ThisDedStr = item.Thisdedstr.TrimEnd(),
                                ThisOn = item.Thison,
                                ThisStndUnitRate = item.Thisstndunitrate,
                                DisGlRecNo = item.Disglrecno
                            })
                .ToList();
        }

        public List<DTODiscountRates> GetDiscountRatesByRecNos(List<int> RecNos)
        {
            return GetDataInChunks(i => i.DraRecNo, RecNos);
        }
    }
}
