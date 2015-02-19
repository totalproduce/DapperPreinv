using System.Collections.Generic;
using System.Linq;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Reports.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.Reports
{
    public class DetailReportRepository : DapperRepositoryBase<WideDetailReportItem>, IDetailReportRepository
    {
        private const string EXTRACTSESSIONID = "EXTRACTSESSIONID";

        private const string SqlQuery =
@"SELECT *
FROM
(
  SELECT
    Tot.EXTRACTSESSIONID,
    Tot.SORT1,
    Tot.INVOICENO,
    Tot.BATCHNO,
    Tot.INVOICETYPE,
    Tot.BATCHTYPE,
    Tot.HOFCSTCODE,
    Tot.QTYTOTAL,
    Tot.GOODSTOTAL,
    Tot.VATTOTAL,
    Tot.ONINVDSCNT as ONINVDSCNTTOTAL,
    Tot.OFFINVRBT + Tot.OFFINVONPAY as Rebate ,
    Tot.INVOICETOTAL,
    Tot.RAWHANDCOMMAMT,
    Tot.RAWVATONCHGS as RAWVATONCHGSTOTAL,
    Tot.CURDESC,
    S1Tot.S1TotQTYTOTAL,
    S1Tot.S1TotGOODSTOTAL,
    S1Tot.S1TotVATTOTAL,
    S1Tot.S1TotONINVDSCNTTOTAL,
    S1Tot.S1TotRebate ,
    S1Tot.S1TotINVOICETOTAL,
    S1TotRAWHANDCOMMAMT,
    S1TotRAWVATONCHGSTOTAL,
    GTot.GTotQTYTOTAL,
    GTot.GTotGOODSTOTAL,
    GTot.GTotVATTOTAL,
    GTot.GTotONINVDSCNTTOTAL,
    GTot.GTotRebate ,
    GTot.GTotINVOICETOTAL,
    GTotRAWHANDCOMMAMT,
    GTotRAWVATONCHGSTOTAL,
    Prt.DLVINVOICENO,
    Prt.DLVORDNO,
    Prt.DLVDELDATE,
    Prt.DLVPRGHEDNO,
    Prt.DLVPODNO,
    Prt.ORDCUSTORDNO,
    Prt2.DELQTY,
    Prt2.DELPRICE,
    Prt2.GOODS,
    Prt2.VAT,
    Prt2.ONINVDSCNT,
    Prt2.PRCPRDREF,
    Prt2.PRDRECDESC,
    Prt2.RAWHANDAMT + Prt2.RAWCOMMAMT as CommHandAmt,
    Prt2.RAWVATONCHGS,
    Prt2.UNITMEASURE
  FROM PREINVTEMP_INVTOT Tot
    INNER JOIN
      (
        SELECT
          Tot.EXTRACTSESSIONID,
          Tot.SORT1,
          Sum(Tot.QTYTOTAL) as S1TotQTYTOTAL,
          Sum(Tot.GOODSTOTAL) as S1TotGOODSTOTAL,
          Sum(Tot.VATTOTAL) as S1TotVATTOTAL,
          Sum(Tot.ONINVDSCNT) as S1TotONINVDSCNTTOTAL,
          Sum(Tot.OFFINVRBT + Tot.OFFINVONPAY) as S1TotRebate,
          Sum(Tot.INVOICETOTAL) as S1TotINVOICETOTAL,
          Sum(Tot.RAWHANDCOMMAMT) as S1TotRAWHANDCOMMAMT,
          Sum(Tot.RAWVATONCHGS) as S1TotRAWVATONCHGSTOTAL
        FROM PREINVTEMP_INVTOT Tot
        GROUP BY Tot.EXTRACTSESSIONID, Tot.SORT1
      ) S1Tot on S1Tot.EXTRACTSESSIONID = Tot.EXTRACTSESSIONID AND S1Tot.SORT1 = Tot.SORT1
    INNER JOIN
      (
        SELECT 
          Tot.EXTRACTSESSIONID,
          Sum(Tot.QTYTOTAL) as GTotQTYTOTAL,
          Sum(Tot.GOODSTOTAL) as GTotGOODSTOTAL,
          Sum(Tot.VATTOTAL) as GTotVATTOTAL,
          Sum(Tot.ONINVDSCNT) as GTotONINVDSCNTTOTAL,
          Sum(Tot.OFFINVRBT + Tot.OFFINVONPAY) as GTotRebate ,
          Sum(Tot.INVOICETOTAL) as GTotINVOICETOTAL,
          Sum(Tot.RAWHANDCOMMAMT) as GTotRAWHANDCOMMAMT,
          Sum(Tot.RAWVATONCHGS) as GTotRAWVATONCHGSTOTAL
        FROM PREINVTEMP_INVTOT Tot
        GROUP BY Tot.EXTRACTSESSIONID
      ) GTot on GTot.EXTRACTSESSIONID = Tot.EXTRACTSESSIONID
    INNER JOIN PREINVTEMP_INVPRT Prt on Tot.INVOICENO = Prt.DLVINVOICENO AND Tot.EXTRACTSESSIONID = Prt.EXTRACTSESSIONID
    INNER JOIN PREINVTEMP_INVPRT2 Prt2 on Prt2.DLVORDNO = Prt.DLVORDNO AND Tot.EXTRACTSESSIONID = Prt2.EXTRACTSESSIONID
  ORDER BY Tot.SORT1, Tot.INVOICENO, Tot.HOFCSTCODE, Prt.DLVORDNO
) T";

        public DetailReportRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory, IEnumerable<ISearchFieldDef> validSearchFields)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<WideDetailReportItem, int>(i => i.ExtractSessionID, EXTRACTSESSIONID, FieldType.Integer)
                }
            )

        {
        }

        protected override List<WideDetailReportItem> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(SqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<WideDetailReportItem>(query);

            return results.ToList();
        }

        public List<WideDetailReportItem> GetByExtractSessionID(int extractSessionID)
        {
            var searchParams =
                new List<ISearchField>
                    {
                        new SearchFieldGeneric<WideDetailReportItem, int>(i => i.ExtractSessionID).Apply(extractSessionID, FieldType.Integer)
                    };

            return GetData(searchParams, CachingStrategy.NoCache);
        }    }
}
