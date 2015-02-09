using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Repositories.PreInv.TempRep
{
    public class InvExtractHedRepository : DapperRepositoryBase<DTOInvExtractHead>, IInvExtractHedRepository
    {
        private const string _sqlQuery = @"SELECT LOWER(TRIM(L.LOGONNAME)) LOGONNAME, H.*
FROM PREINVTEMP_INVEXTRACTHED H
  INNER JOIN LOGONS L on L.LOGONNO = H.LOGONNO";

        private const string _sqlDeleteQuery = @"DELETE FROM PREINVTEMP_INVEXTRACTHED WHERE EXTRACTSESSIONID = {0}";

        public InvExtractHedRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOInvExtractHead, int>(i => i.ExtractSessionId, InvExtractHed.FieldNames.EXTRACTSESSIONID, FieldType.Integer),
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return InvExtractHed.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "PREINVTEMP_INVEXTRACTHED";
        }

        public override IBaseModel ToDbModel(DTOInvExtractHead item)
        {
            return new InvExtractHedEx
                             {
                                 Extractsessionid = item.ExtractSessionId,
                                 Logonno = item.UserId,
                                 Salesofficeno = item.SalesOfficeNo,
                                 Salesofficename = item.SalesOfficeName,
                                 Invoicetype = (int)item.InvoiceType,
                                 Invoicetypename = item.InvoiceTypeName,
                                 Createddate = item.CreatedDate,
                                 Reqdate = item.CutOffDeliveryDate,
                                 Taxdate = item.TaxPointDate,
                                 Invoiceordertype = item.InvoiceOrderType,
                                 Invoiceperiod = (int)item.InvoicePeriod,
                                 Invoiceperiodasstr = item.InvoicePeriodAsStr,
                                 Isintercompanytransfer = item.IsInterCompanyTransfer ? (short)1 : (short)0,
                                 Companyno = item.CompanyNo,
                                 Lastinvoiceno = item.LastInvoiceNo,
                                 LogonName = item.LogonName
                             };
        }

        protected override List<DTOInvExtractHead> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<InvExtractHedEx>(query);

            return results.Select(i => new DTOInvExtractHead
                                           {
                                               ExtractSessionId = i.Extractsessionid,
                                               UserId = i.Logonno,
                                               SalesOfficeNo = i.Salesofficeno,
                                               SalesOfficeName = i.Salesofficename,
                                               InvoiceType = (PreInvInvoiceType)i.Invoicetype, //Do not change to Enums<>.GetValue as it does not support flag enums
                                               InvoiceTypeName = i.Invoicetypename,
                                               CreatedDate = i.Createddate,
                                               CutOffDeliveryDate = i.Reqdate,
                                               TaxPointDate = i.Taxdate,
                                               InvoicePeriod = Enums<PreInvInvoicePeriodType>.GetValue(i.Invoiceperiod),
                                               InvoicePeriodAsStr = i.Invoiceperiodasstr,
                                               InvoiceOrderType = i.Invoiceordertype,
                                               IsInterCompanyTransfer = i.Isintercompanytransfer > 0,
                                               CompanyNo = i.Companyno,
                                               LastInvoiceNo = i.Lastinvoiceno,
                                               LogonName = i.LogonName
                                           }
                                 ).ToList();
        }

        public DTOInvExtractHead GetInvExtractHeadByExtractionSessionId(int extractionSessionID)
        {
            return
                GetData
                    (
                        new List<ISearchField>
                            {
                                new SearchFieldGeneric<DTOInvExtractHead, int>(k => k.ExtractSessionId).Apply(extractionSessionID, FieldType.Integer)
                            },
                        CachingStrategy.NoCache
                    ).FirstOrDefault();
        }

        public void DeleteByExtractSessionID(int extractSessionID)
        {
            string sqlQuery = string.Format(_sqlDeleteQuery, extractSessionID);
            UnitOfWorkCurrent.Execute(sqlQuery);
        }

    }
}
