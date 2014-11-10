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
    public class BatchRepository : DapperRepositoryBase<DTOBatch>, IBatchRepository
    {
        private const string _sqlQuery = @"SELECT * FROM BATCH";

        public BatchRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return Batch.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "BATCH";
        }

        public override IBaseModel ToDbModel(DTOBatch item)
        {
            var result = new Batch();
            result.Batrecno = item.BatRecNo;
            result.Batchallocflg = item.Batchallocflg;
            result.Batchcutoffdate = item.BatchCutOffDate;
            result.Batchinvperiod = item.BatchInvPeriod;
            result.Batchinvtype = item.BatchInvType;
            result.Batchmarketind = item.Batchmarketind;
            result.Batchmergetrans = item.BatchMergeTrans ? (short)1 : (short)0;
            result.Batchnetusername = item.BatchNetUserName;
            result.Batchno = item.BatchNo;
            result.Batchprintno = item.Batchprintno;
            result.Batchpstrecno = item.BatchPstRecNo;
            result.Batchsaloffno = item.BatchSalOffNo;
            result.Batchtaxdate = item.BatchTaxDate;
            result.Batchtimestamp = item.BatchTimeStamp;
            result.Batchtypeno = item.Batchtypeno; 
            return result;
        }


        protected override List<DTOBatch> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            IEnumerable<Batch> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<Batch>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load Batch" + Environment.NewLine + ex.Message, ex);
            }

            return results
                .Select(item =>
                    new DTOBatch
                    {
                        BatRecNo = item.Batrecno,
                        Batchallocflg = item.Batchallocflg,
                        BatchCutOffDate = item.Batchcutoffdate,
                        BatchInvPeriod = item.Batchinvperiod,
                        BatchInvType = item.Batchinvtype,
                        Batchmarketind = item.Batchmarketind,
                        BatchMergeTrans = (item.Batchmergetrans??0) > 0,
                        BatchNetUserName = item.Batchnetusername,
                        BatchNo = item.Batchno,
                        Batchprintno = item.Batchprintno,
                        BatchPstRecNo = item.Batchpstrecno,
                        BatchSalOffNo = item.Batchsaloffno,
                        BatchTaxDate = item.Batchtaxdate,
                        BatchTimeStamp = item.Batchtimestamp,
                        Batchtypeno = item.Batchtypeno,
                    })
                .ToList();
        }

        protected override long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            return UnitOfWorkCurrent.GetNextIdentity("LstBatRecNo", keyNumber ?? 1);
        }

    }
}

