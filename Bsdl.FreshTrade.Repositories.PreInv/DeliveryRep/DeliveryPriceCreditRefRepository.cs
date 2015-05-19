using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.DeliveryRep
{
    public class DeliveryPriceCreditRefRepository : DapperRepositoryBase<DTODeliveryPriceCreditRef>, IDeliveryPriceCreditRefRepository
    {
        private const string _sqlQuery = @"SELECT * FROM DELPRICE_CREDITREF";

        public DeliveryPriceCreditRefRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTODeliveryPrice, int>(i => i.Id, DelPriceCreditRef.FieldNames.DPRCDTREFNO, FieldType.Integer)
                }
            )
        {
        }

        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return DelPriceCreditRef.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "DELPRICE_CREDITREF";
        }

        public override IBaseModel ToDbModel(DTODeliveryPriceCreditRef item)
        {
            var result = new DelPriceCreditRef();
            result.Dprcdtrefno = item.Id;
            result.Creditref = item.CreditRef;
            result.Dlvordno = item.DeliveryHeadId;
            result.Invstatus = item.InvStatus;
            return result;
        }


        protected override List<DTODeliveryPriceCreditRef> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<DelPriceCreditRef>(query);

            return results
                    .Select(item =>
                        new DTODeliveryPriceCreditRef
                        {
                            Id = item.Dprcdtrefno,
                            CreditRef = item.Creditref,
                            DeliveryHeadId = item.Dlvordno,
                            InvStatus = item.Invstatus
                        })
                    .ToList();
        }

        public List<DTODeliveryPriceCreditRef> GetByIds(List<int> ids)
        {
            return GetDataInChunks(i => i.Id, ids);
        }
    }
}
