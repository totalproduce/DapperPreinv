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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Repositories.PreInv.Audit
{
    public class DelAuditRecordRepository : DapperRepositoryBase<DTODelAuditRecord>, IDelAuditRecordRepository
    {
        private const string _sqlQuery = @"SELECT * FROM DELAUDIT";

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
            return DelAudit.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "DELAUDIT";
        }

        public override IBaseModel ToDbModel(DTODelAuditRecord item)
        {
            var result = new DelAudit();
            result.Delaudrecno = item.Id;
            result.Delauddate = item.DelAudDate;
            result.Delaudtime = item.DelAudDate.HasValue ? item.DelAudDate.Value.ToString("HH:mm:ss") : "";
            result.Delauddelrecno = item.DelAudDelRecNo;
            result.Delaudfrom = item.DelAudFrom;
            result.Delaudgrpno = item.DelAudGrpNo;
            result.Delaudto = item.DelAudTo;
            result.Delaudtyp = item.DelAudTyp;
            result.Dprrecno = item.DprRecNo;
            result.Formno = item.FormNo;
            result.Formname = item.FormName;
            result.Logonno = item.LogonNo;
            result.Dprtoaction = item.DprRecNo == null ? 1 : 0;
            return result;
        }


        protected override List<DTODelAuditRecord> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            IEnumerable<DelAudit> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<DelAudit>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load DelAuditInt" + Environment.NewLine + ex.Message, ex);
            }

            return results
                .Select(item =>
                    new DTODelAuditRecord
                    {
                        Id = item.Delaudrecno,
                        DelAudDate = item.Delauddate,
                        DelAudDelRecNo = item.Delauddelrecno,
                        DelAudFrom = item.Delaudfrom,
                        DelAudGrpNo = item.Delaudgrpno,
                        DelAudTo = item.Delaudto,
                        DelAudTyp = item.Delaudtyp??0,
                        DprRecNo = item.Dprrecno,
                        FormNo = item.Formno,
                        FormName = item.Formname,
                        LogonNo = item.Logonno,
                    })
                .ToList();
        }

        protected override long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            return UnitOfWorkCurrent.GetNextIdentity("DaudLstRefNo", keyNumber ?? 1);
        }

    }
}

