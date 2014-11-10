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

namespace Bsdl.FreshTrade.Repositories.PreInv.Audit
{
    public class DelAuditRecordRepository : DapperRepositoryBase<DTODelAuditRecord>, IDelAuditRecordRepository
    {
        private const string _sqlQuery = @"SELECT * FROM DELAUDIT_INT";

        public DelAuditRecordRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return DelAuditInt.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "DELAUDIT_INT";
        }

        public override IBaseModel ToDbModel(DTODelAuditRecord item)
        {
            var result = new DelAuditInt();
            result.Delaudintrecno = item.DelAudIntRecno;
            result.Delaudintdate = item.DelAudIntDate;
            result.Delaudintdelrecno = item.DelAudIntDelRecNo;
            result.Delaudintfrom = item.DelaudIntFrom;
            result.Delaudintgrpno = item.DelAudIntGrpNo;
            result.Delaudintto = item.DelAudIntTo;
            result.Delaudinttyp = item.DelAudIntTyp;
            result.Dprrecnoint = item.DprRecNoInt;
            result.Formintno = item.FormIntNo;
            result.Logonintno = item.LogonIntNo; 
            return result;
        }


        protected override List<DTODelAuditRecord> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            IEnumerable<DelAuditInt> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<DelAuditInt>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load DelAuditInt" + Environment.NewLine + ex.Message, ex);
            }

            return results
                .Select(item =>
                    new DTODelAuditRecord
                    {
                        DelAudIntRecno = item.Delaudintrecno,
                        DelAudIntDate = item.Delaudintdate,
                        DelAudIntDelRecNo = item.Delaudintdelrecno,
                        DelaudIntFrom = item.Delaudintfrom,
                        DelAudIntGrpNo = item.Delaudintgrpno,
                        DelAudIntTo = item.Delaudintto,
                        DelAudIntTyp = item.Delaudinttyp??0,
                        DprRecNoInt = item.Dprrecnoint,
                        FormIntNo = item.Formintno,
                        LogonIntNo = item.Logonintno,
                    })
                .ToList();
        }

        protected override long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
           var ids = UnitOfWorkCurrent.GenNextSequenceIDs("DELAUDIT_INT", keyNumber??1);
           return ids.FirstOrDefault();   
        }

    }
}

