using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Account.DBModel;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.DatabaseConnection;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Bsdl.FreshTrade.Repositories.Account.SalesOffice
{
    public class SalesOfficeRepository : DapperRepositoryBase<DTOSalesOffice>, ISalesOfficeRepository
    {

        private static string _salesOfficeQuerySql = @"
SELECT
        SO.*,
        NULL as CanSell, -- these are invalid and will need reviewed
        1 as CanAccts, -- these are invalid and will need reviewed,
        1 as CanChngStc -- these are invalid and will need reviewed
 FROM SALOFFNO SO
WHERE (SALOFFNO > 0)";

        public class SalesOfficeResultsLine : SalesOfficeResultsLineBase
        {
            public short? CanSell { get; set; }

            public short? CanAccts { get; set; }

            public short? CanChngStc { get; set; }
        }

        public SalesOfficeRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory, 
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeDescription, SalesOfficeResultsLineBase.FieldNames.SALOFFDESC, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeCode, SalesOfficeResultsLineBase.FieldNames.SALOFFCODE, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeCompanyName, SalesOfficeResultsLineBase.FieldNames.COMPANYNAME, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeCompanyAddress1, SalesOfficeResultsLineBase.FieldNames.COMPADD1, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeCompanyAddress2, SalesOfficeResultsLineBase.FieldNames.COMPADD2, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeCompanyAddress3, SalesOfficeResultsLineBase.FieldNames.COMPADD3, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeCompanyAddress4, SalesOfficeResultsLineBase.FieldNames.COMPADD4, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeCompanyVatNo, SalesOfficeResultsLineBase.FieldNames.COMPVATNO, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeCompanyPhoneNo, SalesOfficeResultsLineBase.FieldNames.COMPPHONE, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeCompanyFaxNo, SalesOfficeResultsLineBase.FieldNames.COMPFAX, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, string>(i => i.SalesOfficeCompanyAnaNo, SalesOfficeResultsLineBase.FieldNames.COMPANANO, FieldType.AlphaNumeric),
                    new SearchFieldDef<DTOSalesOffice, int>(i => i.SalesOfficeNumber, SalesOfficeResultsLineBase.FieldNames.SALOFFNO, FieldType.Integer),
                    new SearchFieldDef<DTOSalesOffice, bool>(i => i.InUse, SalesOfficeResultsLineBase.FieldNames.INUSE, FieldType.Bool),
                    new SearchFieldDef<DTOSalesOffice, int?>(i => i.InvoiceGenerationSessionNo, SalesOfficeResultsLineBase.FieldNames.INVSESSIONNO, FieldType.Integer)
                }
            )
        {
            _allowQueryWithoutFilter = true;
        }

        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return SalesOfficeResultsLineBase.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "SALOFFNO";
        }

        public override IBaseModel ToDbModel(DTOSalesOffice item)
        {
            return new SalesOfficeResultsLineBase
            {
                            Saloffno = item.SalesOfficeNumber,
                            Saloffdesc = item.SalesOfficeDescription,
                            Saloffcode = item.SalesOfficeCode,
                            Salbusunitrecno = item.SalesOfficeBusinessUnitNumber,
                            Nextinvoiceno = item.NextInvoiceNo,
                            Nextcdtnoteno = item.NextCreditNoteNo,
                            Lastbatchno = item.LastBatchNo,
                            Lastinvbatchno = item.LastInvoiceBatchNo,
                            Lastcdtbatchno = item.LastCreditBatchNo,
                            Lastdbtbatchno = item.LastDebitBatchNo,
                            Companyname = item.SalesOfficeCompanyName,
                            Compadd1 = item.SalesOfficeCompanyAddress1,
                            Compadd2 = item.SalesOfficeCompanyAddress2,
                            Compadd3 = item.SalesOfficeCompanyAddress3,
                            Compadd4 = item.SalesOfficeCompanyAddress4,
                            Compvatno = item.SalesOfficeCompanyVatNo,
                            Compphone = item.SalesOfficeCompanyPhoneNo,
                            Compfax = item.SalesOfficeCompanyFaxNo,
                            Companano = item.SalesOfficeCompanyAnaNo,
                            Accntsaloffno = item.AccountingSalesOfficeNo,
                            Taxdatebfdlvdate = (short?)(item.TaxDateBeforeDeliveryDate ? 1 : 0),
                            Lastpreinvupdateok = (short?)(item.LastPreInvUpdateOK ? 1 : 0),
                            Useseqinvnos = (short?)(item.UseSequentialInvoiceNos ? 1 : 0),
                            Inuse = (short?)(item.InUse ? 1 : 0),
                            Invsessionno = item.InvoiceGenerationSessionNo,
                            Usedby = item.UsedBy
            };
        }

        protected override List<DTOSalesOffice> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            var data = new List<DTOSalesOffice>();

            string query = ConstructQuery(_salesOfficeQuerySql, searchFields, null, false, topRows);

            data = ConnectionAndQueryHandler(query);

            return data;
        }

        /* AV: This seems to be not needed. For now commented - later will be removed.
        private const string SalesOfficeFreshTradeUserQuerySql = @"
        SELECT
                SALOFFNO.SALOFFNO AS SalesOfficeNumber,
                SALOFFNO.SALOFFDESC AS SalesOfficeDescription,
                SALOFFNO.SALOFFCODE AS SalesOfficeCode,
                SALOFFNO.SALBUSUNITRECNO AS SalesOfficeBusinessUnitNumber,
                SALOFFNO.NEXTINVOICENO AS NextInvoiceNo,
                SALOFFNO.NEXTCDTNOTENO AS NextCreditNoteNo,
                SALOFFNO.LASTBATCHNO AS LastBatchNo,
                SALOFFNO.LASTINVBATCHNO AS LastCreditBatchNo,
                SALOFFNO.LASTCDTBATCHNO AS LastCreditBatchNo,
                SALOFFNO.COMPANYNAME AS SalesOfficeCompanyName,
                SALOFFNO.COMPADD1 AS SalesOfficeCompanyAddress1,
                SALOFFNO.COMPADD2 AS SalesOfficeCompanyAddress2,
                SALOFFNO.COMPADD3 AS SalesOfficeCompanyAddress3,
                SALOFFNO.COMPADD4 AS SalesOfficeCompanyAddress4,
                SALOFFNO.COMPVATNO AS SalesOfficeCompanyVatNo,
                SALOFFNO.COMPPHONE AS SalesOfficeCompanyPhoneNo,
                SALOFFNO.COMPFAX AS SalesOfficeCompanyFaxNo,
                SALOFFNO.COMPANANO AS SalesOfficeCompanyAnaNo,
                SALOFFNO.TAXDATEBFDLVDATE as TaxDateBfDlvDate,
                LOGTOSALOFF.LogCanSell as CanSell,
                LOGTOSALOFF.LogCanAccts as CanAccts,
                LOGTOSALOFF.LogCanChngStc as CanChngStc
         FROM SALOFFNO, LOGTOSALOFF
        WHERE SALOFFNO.SALOFFNO = LOGTOSALOFF.SALOFFNO";
        
        public ISalesOfficeList GetDataForFreshTradeUser(int userDbID, List<ISearchField> searchFields)
        {
            ISalesOfficeList data = new SalesOfficeList();

            List<string> validSearchFields = new List<string>(new string[] { "LOGTOSALOFF.LOGONNO" });

            // Check that we have at least one search field defined
            CheckSearchFieldDefined(searchFields.Select(s => s.FieldName).ToList(), GetType().Name);

            // Check that at least one field in the search fields list is also in the valid search fields list
            CheckSearchFieldsInValidList(validSearchFields, searchFields.Select(s => s.FieldName).ToList());

            string query = ConstructQuery(SalesOfficeFreshTradeUserQuerySql, searchFields, _validAlphaFields, false);

            data = ConnectionAndQueryHandler(query);

            return data;
        }

        public void ValidateSalesOffice(ISalesOffice salesOffice)
        {
            SalesOfficeValidation.ValidateSalesOffice(salesOffice);
        }*/

        private List<DTOSalesOffice> ConnectionAndQueryHandler(string query)
        {
            IEnumerable<SalesOfficeResultsLine> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<SalesOfficeResultsLine>(query);
            }
            catch (Exception exception)
            {
                var ex = new DatabaseQueryException("Could not load Sales Offices" + Environment.NewLine + exception.Message);
                //AppError.SetError(ex, exception.StackTrace, ErrorType.Sql, exception.Message, query);
                throw ex;
            }

            var data = new List<DTOSalesOffice>();
            foreach (SalesOfficeResultsLine rl in results)
            {
                var salesOffice =
                    new Domain.Account.Entities.DTOSalesOffice
                        {
                            SalesOfficeNumber = rl.Saloffno,
                            SalesOfficeDescription = rl.Saloffdesc,
                            SalesOfficeCode = rl.Saloffcode,
                            SalesOfficeBusinessUnitNumber = rl.Salbusunitrecno,
                            NextInvoiceNo = rl.Nextinvoiceno,
                            NextCreditNoteNo = rl.Nextcdtnoteno,
                            LastBatchNo = rl.Lastbatchno,
                            LastInvoiceBatchNo = rl.Lastinvbatchno,
                            LastCreditBatchNo = rl.Lastcdtbatchno,
                            LastDebitBatchNo = rl.Lastdbtbatchno,
                            SalesOfficeCompanyName = rl.Companyname,
                            SalesOfficeCompanyAddress1 = rl.Compadd1,
                            SalesOfficeCompanyAddress2 = rl.Compadd2,
                            SalesOfficeCompanyAddress3 = rl.Compadd3,
                            SalesOfficeCompanyAddress4 = rl.Compadd4,
                            SalesOfficeCompanyVatNo = rl.Compvatno,
                            SalesOfficeCompanyPhoneNo = rl.Compphone,
                            SalesOfficeCompanyFaxNo = rl.Compfax,
                            SalesOfficeCompanyAnaNo = rl.Companano,
                            AccountingSalesOfficeNo = rl.Accntsaloffno,
                            TaxDateBeforeDeliveryDate = rl.Taxdatebfdlvdate == 1,
                            LastPreInvUpdateOK = rl.Lastpreinvupdateok == 1,
                            UseSequentialInvoiceNos = rl.Useseqinvnos == 1,
                            InUse = rl.Inuse == 1,
                            InvoiceGenerationSessionNo = rl.Invsessionno,
                            UsedBy = rl.Usedby,
                            CanSell = rl.CanSell == 1,
                            CanAccts = rl.CanAccts == 1,
                            CanChngStc = rl.CanChngStc == 1
                        };
                    
                data.Add(salesOffice);
            }

            return data;
        }

        public DTOSalesOffice GetSalesOfficeByNo(int salOffNo, bool forceRefresh = false)
        {
            return GetData
                (
                    new List<ISearchField>
                        {
                            new SearchFieldGeneric<DTOSalesOffice, int>(i => i.SalesOfficeNumber)
                                .Apply(salOffNo, FieldType.Integer)
                        },
                    CachingStrategy.PerRequest,
                    forceRefresh
                ).FirstOrDefault();
        }

    }    
}
