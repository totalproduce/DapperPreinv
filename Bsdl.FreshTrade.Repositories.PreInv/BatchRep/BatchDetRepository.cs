using System;
using System.Collections.Generic;
using System.Linq;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.BatchRep
{
    public class BatchDetRepository : DapperRepositoryBase<DTOBatchDet>, IBatchDetRepository
    {
        private const string _sqlQuery = @"SELECT * FROM BATCHDET";

        public BatchDetRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return BatchDet.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "BATCHDET";
        }

        public override IBaseModel ToDbModel(DTOBatchDet item)
        {
            var result = new BatchDet();
            result.Bdtrecno = item.BdtRecNo;
            result.Bdtbatrecno = item.BdtBatRecNo;
            result.Bdtcurtotal = item.BdtCurTotal;
            result.Bdtedifile = item.BdtEdiFile;
            result.Bdtinvrecno = item.BdtInvRecNo;
            return result;
        }


        protected override List<DTOBatchDet> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            IEnumerable<BatchDet> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<BatchDet>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load BatchDet" + Environment.NewLine + ex.Message, ex);
            }

            return results
                .Select(item =>
                    new DTOBatchDet
                    {
                        BdtRecNo = item.Bdtrecno,
                        BdtBatRecNo = item.Bdtbatrecno,
                        BdtCurTotal = item.Bdtcurtotal,
                        BdtEdiFile = item.Bdtedifile,
                        BdtInvRecNo = item.Bdtinvrecno,
                    })
                .ToList();
        }

        protected override long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            return UnitOfWorkCurrent.GetNextIdentity("LstBdtRecNo", keyNumber ?? 1);
        }

    }
}

