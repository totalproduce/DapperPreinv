using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.DeliveryRep
{
    public class DeliveryTypeRepository : DapperRepositoryBase<DTODeliveryType>, IDeliveryTypeRepository
    {
        private const string _sqlQuery = @"SELECT * FROM DLVTYPE";

        public DeliveryTypeRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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

        protected override List<DTODeliveryType> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<Dlvtype>(query);

            return results
                    .Select(item =>
                        new DTODeliveryType
                        {
                            Id = item.Dltrecno,
                            GoodsOnConsignment = item.Goodsonconsignment == 1
                        })
                    .ToList();
        }
    }
}
