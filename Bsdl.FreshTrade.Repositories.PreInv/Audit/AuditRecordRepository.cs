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
    public class AuditRecordRepository : DapperRepositoryBase<DTOAuditRecord>, IAuditRecordRepository
    {
        private const string _sqlQuery = @"SELECT * FROM AUDITRECORD";

        public AuditRecordRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return AuditRecord.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "AUDITRECORD";
        }

        public override IBaseModel ToDbModel(DTOAuditRecord item)
        {
            var result = new AuditRecord();
            result.Auditrecordno = item.AuditRecordNo;
            result.Auditactionno = item.AuditActionNo;
            result.Auditchangedfrom = item.AuditChangedFrom;
            result.Auditchangedto = item.AuditChangedTo;
            result.Auditdate = item.AuditDate;
            result.Auditdoneby = item.AuditDoneBy;
            result.Auditformname = item.AuditFormName;
            result.Auditformno = item.AuditFormNo;
            result.Auditlinkrecno1 = item.AuditLinkRecNo1;
            result.Auditlinkrecno2 = item.AuditLinkRecNo2;
            result.Auditlinkrecno3 = item.Auditlinkrecno3;
            result.Auditrdtuser = item.Auditrdtuser;
            result.Audittypeno = item.AuditTypeNo;
            result.Lherecno = item.Lherecno;
            result.Lititeno = item.Lititeno;
            result.Porno = item.Porno;
            return result;
        }


        protected override List<DTOAuditRecord> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            IEnumerable<AuditRecord> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<AuditRecord>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load AuditRecord" + Environment.NewLine + ex.Message, ex);
            }

            return results
                .Select(item =>
                    new DTOAuditRecord
                    {
                        AuditRecordNo = item.Auditrecordno,
                        AuditActionNo = item.Auditactionno,
                        AuditChangedFrom = item.Auditchangedfrom,
                        AuditChangedTo = item.Auditchangedto,
                        AuditDate = item.Auditdate,
                        AuditDoneBy = item.Auditdoneby,
                        AuditFormName = item.Auditformname,
                        AuditFormNo = item.Auditformno,
                        AuditLinkRecNo1 = item.Auditlinkrecno1,
                        AuditLinkRecNo2 = item.Auditlinkrecno2,
                        Auditlinkrecno3 = item.Auditlinkrecno3,
                        Auditrdtuser = item.Auditrdtuser,
                        AuditTypeNo = item.Audittypeno,
                        Lherecno = item.Lherecno,
                        Lititeno = item.Lititeno,
                        Porno = item.Porno,
                    })
                .ToList();
        }

        protected override long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            return UnitOfWorkCurrent.GetNextIdentity("NXTAUDITRECNO", keyNumber ?? 1);
        }

    }
}

