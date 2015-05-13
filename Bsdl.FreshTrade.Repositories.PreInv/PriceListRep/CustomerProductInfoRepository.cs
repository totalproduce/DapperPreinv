using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.PriceListRep
{
    public class CustomerProductInfoRepository : DapperRepositoryBase<DTOCustomerProductInfo>, ICustomerProductInfoRepository
    {
        private const string _sqlQuery = @"SELECT * FROM PRCCSTINFO";

        public CustomerProductInfoRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOCustomerProductInfo, int>(i => i.Id, PrcCstInfo.FieldNames.PPCCLTRECNO, FieldType.Integer),
                    new SearchFieldDef<DTOCustomerProductInfo, string>(i => i.ClientProductNo, PrcCstInfo.FieldNames.PPCCLIENTPRDNO, FieldType.AlphaNumeric)
                }
            )
        {
        }

        protected override List<DTOCustomerProductInfo> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<PrcCstInfo>(query);

            return results
                .Select(item =>
                    new DTOCustomerProductInfo
                    {
                        Id = item.Ppccltrecno,
                        GroupNo = item.Ppcgrpno,
                        ClientProductNo = item.Ppcclientprdno,
                        ProductDescription = item.Ppcprddesc,
                        TradedUnit = item.Ppctradedunit,
                        UnitCount = item.Ppcunitcount
                    })
                .ToList();
        }

        public List<DTOCustomerProductInfo> GetCustomerProductInfosByClientProductNos(List<string> clientProductNos)
        {
            return GetDataInChunks(i => i.ClientProductNo, clientProductNos);
        }
    }
}
