using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.OrderRep
{
    public class OrderRepository : DapperRepositoryBase<DTOOrder>, IOrderRepository
    {
        private const string _sqlQuery = @"SELECT O.* FROM ORDERS O
  INNER JOIN (SELECT DLVORDRECNO FROM DELHED WHERE DLVRELINV = 'Rel' GROUP BY DLVORDRECNO) T ON T.DLVORDRECNO = O.ORDRECNO
WHERE O.ORDSALTYP = 'S'";

        public OrderRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent, 
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOOrder, int>(i => i.Id, Order.FieldNames.ORDRECNO, FieldType.Integer),
                    new SearchFieldDef<DTOOrder, int?>(i => i.AccountClassId, Order.FieldNames.ORDCSTCODE, FieldType.Integer)
                }
            )
        {
        }

        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return Order.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "ORDERS";
        }

        protected override List<DTOOrder> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, false, topRows);
            var results = UnitOfWorkCurrent.Query<Order>(query);

            return results
                    .Select(item => 
                        new DTOOrder
                            {
                                Id = item.Ordrecno,
                                AccountClassId = item.Ordcstcode,
                                CustomerOrderNo = item.Ordcustordno,
                                OrderDate = item.Orddate,
                                SalesPerson = item.Ordsmnno
                            })
                    .ToList();
        }

        public List<DTOOrder> GetOrdersByAccountClassIDs(List<int> accountClassIds)
        {
            return GetDataInChunks(i => i.AccountClassId, accountClassIds);
        }

        public List<DTOOrder> GetOrdersByIDs(List<int> orderIds)
        {
            return GetDataInChunks(i => i.Id, orderIds);
        }

    }
}
