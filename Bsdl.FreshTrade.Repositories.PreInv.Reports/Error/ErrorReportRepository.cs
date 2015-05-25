using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Reports.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Reports.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Reports.Error
{
    public class ErrorReportRepository : DapperRepositoryBase<WideErrorReportItem>, IErrorReportRepository
    {
        private const string _sqlQuery = @"SELECT
  ER.LogRecNo,
  ED.ERRREASON,
  ER.OrdCstCode,
  ER.OrdCustOrdNo,
  ER.DlvOrdNo,
  ER.EXTRACTSESSIONID,
  ED.ERRISCRITICAL
FROM PREINVTEMP_InvErr ER
  INNER JOIN PREINVERRORS ED on ED.ERRNO = ER.ErrNo
";

        public ErrorReportRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<WideErrorReportItem, int>(i => i.ExtractSessionID, ErrorReportItem.FieldNames.EXTRACTSESSIONID, FieldType.Integer)
                }
            )
        {
        }

        protected override List<WideErrorReportItem> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<ErrorReportItem>(query);

            return results
                    .Select(item =>
                        new WideErrorReportItem
                        {
                            LogRecNo = item.LogRecNo,
                            ErrReason = item.ErrReason,
                            OrdCstCode = item.OrdCstCode,
                            OrdCustOrdNo = item.OrdCustOrdNo,
                            DlvOrdNo = item.DlvOrdNo,
                            ErrIsCritical = item.ErrIsCritical,
                            ExtractSessionID = item.ExtractSessionID
                        })
                    .ToList();
        }

        public List<WideErrorReportItem> GetByExtractSessionID(int extractSessionID)
        {
            var searchParams =
                new List<ISearchField>
                    {
                        new SearchFieldGeneric<WideErrorReportItem, int>(i => i.ExtractSessionID).Apply(extractSessionID, FieldType.Integer)
                    };

            return GetData(searchParams, CachingStrategy.NoCache);
        }

    }

}
