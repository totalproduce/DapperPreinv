using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Reports.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Repositories.PreInv.Reports
{
    public class SummaryReportRepository : DapperRepositoryBase<WideSummaryReportItem>, ISummaryReportRepository
    {
        private const string EXTRACTSESSIONID = "EXTRACTSESSIONID";

        private const string SqlQuery =
@"SELECT
  SORT1,
  INVOICENO,
  INVOICETYPE,
  HOFCSTCODE,
  QTYTOTAL,
  GOODSTOTAL,
  VATTOTAL,
  ONINVDSCNT,
  OFFINVRBT + OFFINVONPAY as REBATE,
  INVOICETOTAL,
  RAWHANDCOMMAMT,
  RAWVATONCHGS
FROM PREINVTEMP_INVTOT";

        public SummaryReportRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory, IEnumerable<ISearchFieldDef> validSearchFields)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<WideSummaryReportItem, int>(i => i.ExtractSessionID, EXTRACTSESSIONID, FieldType.Integer)
                }
            )

        {
        }

        protected override List<WideSummaryReportItem> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(SqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<WideSummaryReportItem>(query);

            return results.OrderBy(i => i.Sort1).ToList();
        }

        public List<WideSummaryReportItem> GetByExtractSessionID(int extractSessionID)
        {
            var searchParams =
                new List<ISearchField>
                    {
                        new SearchFieldGeneric<WideSummaryReportItem, int>(i => i.ExtractSessionID).Apply(extractSessionID, FieldType.Integer)
                    };

            return GetData(searchParams, CachingStrategy.NoCache);
        }

    }
}
